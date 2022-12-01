using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chu_UT3_UIHell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.checkBox.Click += new EventHandler(CheckBox__Click);
            this.button.Click += new EventHandler(Button__Click);
            this.textBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
            this.radioButton.Click += new EventHandler(RadioButton__Click);
        }

        private void CheckBox__Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 4; i++)
            {
                Form3 form3 = new Form3();
                form3.Show();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void Button__Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void TextBox__KeyPress(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void PictureBox__MouseHover(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/blackgoose.png";
        }

        private void RadioButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
