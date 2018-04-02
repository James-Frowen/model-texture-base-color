using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_texture_base_color
{
    public partial class Form1 : Form
    {
        const byte OUTLINE_THRESHOLD = 100;
        const string LOAD_FORMATS = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        const string SAVE_FORMATS = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

        readonly Image loading = Properties.Resources.LoadingImage;

        Random rand = new Random();
        Bitmap outLine;
        Bitmap texture;
        Bitmap result;

        bool resultTaskFinished;

        public Form1()
        {
            InitializeComponent();
            setupDialogs(this.openOutlineDialog, "Open Outline Image");
            setupDialogs(this.openTextureDialog, "Open Texture Image");
            setupDialogs(this.saveOutputDialog, "Save Result Image");

            setupPictureBox(this.outlineBox);
            setupPictureBox(this.textureBox);
            setupPictureBox(this.resultBox);

            checkCreatebuttonEnabled();
            checkSavebuttonEnabled();
        }
        private static void setupDialogs(FileDialog dialog, string title = "Select File")
        {
            if (dialog is OpenFileDialog open)
            {
                open.Multiselect = false;
                dialog.Filter = LOAD_FORMATS;
            }
            else if (dialog is SaveFileDialog save)
            {
                dialog.Filter = SAVE_FORMATS;
            }
            dialog.Title = title;
        }
        private static void setupPictureBox(PictureBox box)
        {
            box.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkCreatebuttonEnabled()
        {
            this.createResultButton.Enabled = this.outLine != null && this.texture != null;
        }
        private void checkSavebuttonEnabled()
        {
            this.saveResultButton.Enabled = this.result != null;
        }

        private void openOutlineButton_Click(object sender, EventArgs e)
        {
            if (this.openOutlineDialog.ShowDialog() == DialogResult.OK)
            {
                this.outLine = new Bitmap(this.openOutlineDialog.FileName);
                this.outlineBox.Image = this.outLine;
                checkCreatebuttonEnabled();
            }
        }

        private void openTextureButton_Click(object sender, EventArgs e)
        {
            if (this.openTextureDialog.ShowDialog() == DialogResult.OK)
            {
                this.texture = new Bitmap(this.openTextureDialog.FileName);
                this.textureBox.Image = this.texture;
                checkCreatebuttonEnabled();
            }
        }

        private void createResultButton_Click(object sender, EventArgs e)
        {
            this.resultBox.Image = this.loading;

            this.resultTaskFinished = false;
            Task task = new Task(() =>
            {
                this.result = new Bitmap(this.outLine);

                var width = this.result.Width;
                var height = this.result.Height;
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        var outLineColor = this.outLine.GetPixel(x, y);
                        if (outLineColor.A > OUTLINE_THRESHOLD)
                        {
                            this.result.SetPixel(x, y, texturePixel(x, y));
                        }
                    }
                }

                this.resultBox.Image = this.result;
                this.resultTaskFinished = true;
            });
            this.timer1.Start();
            task.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.resultTaskFinished)
            {
                this.checkSavebuttonEnabled();
                this.timer1.Stop();
            }
        }

        private Color texturePixel(int xIn, int yIn)
        {
            //var x = xIn % this.texture.Width;
            //var y = yIn % this.texture.Height;

            // add tiled or other methods here?

            return this.texture.GetPixel(
                this.rand.Next(this.texture.Width),
                this.rand.Next(this.texture.Height)
            );
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            if (this.saveOutputDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = this.saveOutputDialog.FileName;

                ImageFormat format;
                switch (this.saveOutputDialog.FilterIndex)
                {
                    case 1:
                    default:
                        format = ImageFormat.Png;
                        break;
                    case 2:
                        format = ImageFormat.Jpeg;
                        break;
                    case 3:
                        format = ImageFormat.Bmp;
                        break;
                    case 4:
                        format = ImageFormat.Gif;
                        break;

                }

                this.result.Save(fileName, format);
            }
        }
    }
}
