using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_texture_base_color
{
    public partial class ColorForm : Form
    {
        Button colorButton;
        Color Color {
            get { return this.colorButton.BackColor; }
            set {
                this.colorButton.BackColor = value;
                this.colorDisplayPanel.BackColor = value;
            }
        }
        byte R
        {
            get { return this.Color.R; }
            set { this.Color = Color.FromArgb(this.A, value, this.G, this.B); }
        }
        byte G
        {
            get { return this.Color.G; }
            set { this.Color = Color.FromArgb(this.A, this.R, value, this.B); }

        }
        byte B
        {
            get { return this.Color.B; }
            set { this.Color = Color.FromArgb(this.A, this.R, this.G, value); }

        }
        byte A
        {
            get { return this.Color.A; }
            set { this.Color = Color.FromArgb(value, this.R, this.G, this.B); }

        }
        public ColorForm(Button colorButton)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.colorButton = colorButton;
            this.textBox1.Text = this.Color.R.ToString();
            this.textBox2.Text = this.Color.G.ToString(); 
            this.textBox3.Text = this.Color.B.ToString();
            this.textBox4.Text = this.Color.A.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isValidColorNumber(this.textBox1.Text, out byte n))
            {
                this.R = n;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isValidColorNumber(this.textBox2.Text, out byte n))
            {
                this.G = n;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (isValidColorNumber(this.textBox3.Text, out byte n))
            {
                this.B = n;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (isValidColorNumber(this.textBox4.Text, out byte n))
            {
                this.A = n;
            }
        }
        private bool isValidColorNumber(string text, out byte number)
        {
            return byte.TryParse(text, out number);
        }
        

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
