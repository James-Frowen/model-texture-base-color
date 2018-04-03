using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        const string LOAD_FORMATS = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        const string SAVE_FORMATS = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

        private readonly Image loading = Properties.Resources.LoadingImage;

        private string outlinePath;
        private Bitmap outline;
        private string texturePath;
        private Bitmap texture;
        private Bitmap result;

        public ColorForm colorForm;
        private Imagecreator creator;
        int ms;

        public Form1()
        {
            InitializeComponent();
            setupDialogs(this.openOutlineDialog, "Open Outline Image");
            setupDialogs(this.openTextureDialog, "Open Texture Image");
            setupDialogs(this.openResultDialog, "Open Texture Image");
            setupDialogs(this.saveOutputDialog, "Save Result Image");

            setupPictureBox(this.outlineBox);
            setupPictureBox(this.textureBox);
            setupPictureBox(this.resultBox);

            checkCreatebuttonEnabled();
            checkSavebuttonEnabled();

            this.setButtonColor();
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
            this.createResultButton.Enabled = this.outline != null && this.texture != null;
        }
        private void checkSavebuttonEnabled()
        {
            this.saveResultButton.Enabled = this.result != null;
        }

        private void openOutlineButton_Click(object sender, EventArgs e)
        {
            if (this.openOutlineDialog.ShowDialog() == DialogResult.OK)
            {
                this.outlinePath = this.openOutlineDialog.FileName;
                this.outline = new Bitmap(this.outlinePath);
                this.outlineBox.Image = this.outline;
                checkCreatebuttonEnabled();
            }
        }

        private void openTextureButton_Click(object sender, EventArgs e)
        {
            if (this.openTextureDialog.ShowDialog() == DialogResult.OK)
            {
                this.texturePath = this.openTextureDialog.FileName;
                this.texture = new Bitmap(this.texturePath);
                this.textureBox.Image = this.texture;
                checkCreatebuttonEnabled();
            }
        }

        private void createResultButton_Click(object sender, EventArgs e)
        {
            this.resultBox.Image = this.loading;

            bool alphaOnly = this.alphaOnlyToggle.Checked;
            Color threshold = this.colorButton.BackColor;
            bool tiled = this.tiledTextureToggle.Checked;
            double xScale = double.Parse(this.scaleX.Text);
            double yScale = double.Parse(this.scaleY.Text);

            this.creator = new Imagecreator(alphaOnly, threshold, tiled, xScale, yScale, this.outline, this.texture);
            
            this.timer1.Start();
            this.creator.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ms += this.timer1.Interval;
            this.label3.Text = this.ms.ToString();
            if (this.creator.Finished)
            {
                this.result = this.creator.Result;
                this.resultBox.Image = this.result;
                this.checkSavebuttonEnabled();
                this.timer1.Stop();
                this.creator = null;
                this.ms = 0;
            }
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

                if (fileName == this.texturePath)
                {
                    this.texture.Dispose();
                    this.texture = null;
                    this.textureBox.Image = null;
                    this.texturePath = "";
                    checkCreatebuttonEnabled();
                }
                else if (fileName == this.outlinePath)
                {
                    this.outline.Dispose();
                    this.outline = null;
                    this.outlineBox.Image = null;
                    this.outlinePath = "";
                    checkCreatebuttonEnabled();
                }

                this.result.Save(fileName, format);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.setButtonColor();
            }
        }

        private void setButtonColor()
        {
            this.colorButton.BackColor = this.colorDialog.Color;
            this.colorButton.ForeColor = this.colorDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.colorForm == null)
            {
                this.colorForm = new ColorForm(this, this.colorButton);
                this.colorForm.Show();
            }
            else
            {
                this.colorForm.Focus();
            }
        }
    }
}