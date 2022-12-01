using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace CHU_UT3_Presidents
{
    public partial class Form1 : Form
    {
        bool start = false;
        string prefix = "https://en.m.wikipedia.org/wiki/";

        public Form1()
        {
            InitializeComponent();

            this.timer1.Tick += new EventHandler(Timer__Tick);


            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
                    control.MouseHover += new EventHandler(TextBox__MouseHover);
                }
            }

            this.BHTextBox.Validating += new CancelEventHandler(BHTextBox__Validating);
            this.FDRTextBox.Validating += new CancelEventHandler(FDRTextBox__Validating);
            this.WJCTextBox.Validating += new CancelEventHandler(WJCTextBox__Validating);
            this.JBTextBox.Validating += new CancelEventHandler(JBTextBox__Validating);
            this.FPTextBox.Validating += new CancelEventHandler(FPTextBox__Validating);
            this.GWBTextBox.Validating += new CancelEventHandler(GWBTextBox__Validating);
            this.BOTextBox.Validating += new CancelEventHandler(BOTextBox__Validating);
            this.JFKTextBox.Validating += new CancelEventHandler(JFKTextBox__Validating);
            this.WMTextBox.Validating += new CancelEventHandler(WMTextBox__Validating);
            this.RRTextBox.Validating += new CancelEventHandler(RRTextBox__Validating);
            this.DDETextBox.Validating += new CancelEventHandler(DDETextBox__Validating);
            this.MVTextBox.Validating += new CancelEventHandler(MVTextBox__Validating);
            this.GWTextBox.Validating += new CancelEventHandler(GWTextBox__Validating);
            this.JATextBox.Validating += new CancelEventHandler(JATextBox__Validating);
            this.TRTextBox.Validating += new CancelEventHandler(TRTextBox__Validating);
            this.TJTextBox.Validating += new CancelEventHandler(TJTextBox__Validating);

            this.BHRadioButton.Click += new EventHandler(BHRadioButton__Click);
            this.FDRRadioButton.Click += new EventHandler(FDRRadioButton__Click);
            this.WJCRadioButton.Click += new EventHandler(WJCRadioButton__Click);
            this.JBRadioButton.Click += new EventHandler(JBRadioButton__Click);
            this.FPRadioButton.Click += new EventHandler(FPRadioButton__Click);
            this.GWBRadioButton.Click += new EventHandler(GWBRadioButton__Click);
            this.BORadioButton.Click += new EventHandler(BORadioButton__Click);
            this.JFKRadioButton.Click += new EventHandler(JFKRadioButton__Click);
            this.WMRadioButton.Click += new EventHandler(WMRadioButton__Click);
            this.RRRadioButton.Click += new EventHandler(RRRadioButton__Click);
            this.DDERadioButton.Click += new EventHandler(DDERadioButton__Click);
            this.MVRadioButton.Click += new EventHandler(MVRadioButton__Click);
            this.GWRadioButton.Click += new EventHandler(GWRadioButton__Click);
            this.JARadioButton.Click += new EventHandler(JARadioButton__Click);
            this.TRRadioButton.Click += new EventHandler(TRRadioButton__Click);
            this.TJRadioButton.Click += new EventHandler(TJRadioButton__Click);

            this.allRadioButton.Click += new EventHandler(AllRadioButton__Click);
            this.demRadioButton.Click += new EventHandler(DemRadioButton__Click);
            this.repRadioButton.Click += new EventHandler(RepRadioButton__Click);
            this.demRepRadioButton.Click += new EventHandler(DemRepRadioButton__Click);
            this.fedRadioButton.Click += new EventHandler(FedRadioButton__Click);

            this.pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            this.exitButton.Click += new EventHandler(ExitButton__Click);
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            bool check = true;
            foreach(Control control in this.Controls){
                if (control.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.Text = "0";
                    }
                }
            }
            if ((Int32.Parse(BHTextBox.Text)) != 23)
            {
                check = false;
            }
            if ((Int32.Parse(FDRTextBox.Text)) != 32)
            {
                check = false;
            }
            if ((Int32.Parse(WJCTextBox.Text)) != 42)
            {
                check = false;
            }
            if ((Int32.Parse(JBTextBox.Text)) != 15)
            {
                check = false;
            }
            if ((Int32.Parse(FPTextBox.Text)) != 14)
            {
                check = false;
            }
            if ((Int32.Parse(GWBTextBox.Text)) != 43)
            {
                check = false;
            }
            if ((Int32.Parse(BOTextBox.Text)) != 44)
            {
                check = false;
            }
            if ((Int32.Parse(JFKTextBox.Text)) != 35)
            {
                check = false;
            }
            if ((Int32.Parse(WMTextBox.Text)) != 25)
            {
                check = false;
            }
            if ((Int32.Parse(RRTextBox.Text)) != 40)
            {
                check = false;
            }
            if ((Int32.Parse(DDETextBox.Text)) != 34)
            {
                check = false;
            }
            if ((Int32.Parse(MVTextBox.Text)) != 8)
            {
                check = false;
            }
            if ((Int32.Parse(GWTextBox.Text)) != 1)
            {
                check = false;
            }
            if ((Int32.Parse(JATextBox.Text)) != 2)
            {
                check = false;
            }
            if ((Int32.Parse(TRTextBox.Text)) != 26)
            {
                check = false;
            }
            if ((Int32.Parse(TJTextBox.Text)) != 3)
            {
                check = false;
            }
            if (check == true)
            {
                timer1.Stop();
                wikiGroupBox.Text = "https://www.youtube.com/embed/18212B4yfLg?autoplay=1";
                webBrowser.Navigate("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");
                exitButton.Enabled = true;
                return;
            }
            if(toolStripProgressBar1.Value == 0)
            {
                timer1.Stop();
                foreach(Control control in this.Controls)
                {
                    if(control.GetType() == typeof(TextBox))
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = "0";
                    }
                }
                toolStripProgressBar1.Value = 240;
                start = false;
                return;
            }
            toolStripProgressBar1.Value--;
        }

        private void BHTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if((Int32.Parse(BHTextBox.Text)) != 23)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void FDRTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(FDRTextBox.Text)) != 32)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void WJCTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(WJCTextBox.Text)) != 42)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void JBTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(JBTextBox.Text)) != 15)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void FPTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(FPTextBox.Text)) != 14)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void GWBTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(GWBTextBox.Text)) != 43)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void BOTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(BOTextBox.Text)) != 44)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void JFKTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(JFKTextBox.Text)) != 35)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void WMTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(WMTextBox.Text)) != 25)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void RRTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(RRTextBox.Text)) != 40)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void DDETextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(DDETextBox.Text)) != 34)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void MVTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(MVTextBox.Text)) != 8)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void GWTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(GWTextBox.Text)) != 1)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void JATextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(JATextBox.Text)) != 2)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void TRTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(TRTextBox.Text)) != 26)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void TJTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Int32.Parse(TJTextBox.Text)) != 3)
            {
                this.errorProvider1.SetError(textbox, "That is the wrong number.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(textbox, null);
                e.Cancel = false;
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
            if (!start)
            {
                start = true;
                timer1.Start();
            }
        }

        private void TextBox__MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            toolTip1.SetToolTip(textBox, "Which # President?");
        }

        private void BHRadioButton__Click(object sender, EventArgs e)
        {
            BHRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Benjamin_Harrison";
            webBrowser.Navigate(prefix + "Benjamin_Harrison");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }

        private void FDRRadioButton__Click(object sender, EventArgs e)
        {
            FDRRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Franklin_D_Roosevelt";
            webBrowser.Navigate(prefix + "Franklin_D_Roosevelt");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
        }

        private void WJCRadioButton__Click(object sender, EventArgs e)
        {
            WJCRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "William_J_Clinton";
            webBrowser.Navigate(prefix + "William_J_Clinton");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
        }

        private void JBRadioButton__Click(object sender, EventArgs e)
        {
            JBRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "James_Buchanan";
            webBrowser.Navigate(prefix + "James_Buchanan");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
        }

        private void FPRadioButton__Click(object sender, EventArgs e)
        {
            FPRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Franklin_Pierce";
            webBrowser.Navigate(prefix + "Franklin_Pierce");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
        }

        private void GWBRadioButton__Click(object sender, EventArgs e)
        {
            GWBRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "George_W_Bush";
            webBrowser.Navigate(prefix + "George_W_Bush");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
        }

        private void BORadioButton__Click(object sender, EventArgs e)
        {
            BORadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Barack_Obama";
            webBrowser.Navigate(prefix + "Barack_Obama");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
        }

        private void JFKRadioButton__Click(object sender, EventArgs e)
        {
            JFKRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "John_F_Kennedy";
            webBrowser.Navigate(prefix + "John_F_Kennedy");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
        }

        private void WMRadioButton__Click(object sender, EventArgs e)
        {
            WMRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "William_McKinley";
            webBrowser.Navigate(prefix + "William_McKinley");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
        }

        private void RRRadioButton__Click(object sender, EventArgs e)
        {
            RRRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Ronald_Reagan";
            webBrowser.Navigate(prefix + "Ronald_Reagan");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
        }

        private void DDERadioButton__Click(object sender, EventArgs e)
        {
            DDERadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Dwight_D_Eisenhower";
            webBrowser.Navigate(prefix + "Dwight_D_Eisenhower");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
        }

        private void MVRadioButton__Click(object sender, EventArgs e)
        {
            MVRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Martin_VanBuren";
            webBrowser.Navigate(prefix + "Martin_VanBuren");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
        }

        private void GWRadioButton__Click(object sender, EventArgs e)
        {
            GWRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "George_Washington";
            webBrowser.Navigate(prefix + "George_Washington");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
        }

        private void JARadioButton__Click(object sender, EventArgs e)
        {
            JARadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "John_Adams";
            webBrowser.Navigate(prefix + "John_Adams");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
        }

        private void TRRadioButton__Click(object sender, EventArgs e)
        {
            TRRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Theodore_Roosevelt";
            webBrowser.Navigate(prefix + "Theodore_Roosevelt");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
        }

        private void TJRadioButton__Click(object sender, EventArgs e)
        {
            TJRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Thomas_Jefferson";
            webBrowser.Navigate(prefix + "Thomas_Jefferson");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
        }

        private void AllRadioButton__Click(object sender, EventArgs e)
        {
            BHRadioButton.Show();
            FDRRadioButton.Show();
            WJCRadioButton.Show();
            JBRadioButton.Show();
            FPRadioButton.Show();
            GWBRadioButton.Show();
            GWBRadioButton.Show();
            BORadioButton.Show();
            JFKRadioButton.Show();
            WMRadioButton.Show();
            RRRadioButton.Show();
            DDERadioButton.Show();
            MVRadioButton.Show();
            GWRadioButton.Show();
            JARadioButton.Show();
            TRRadioButton.Show();
            TJRadioButton.Show();

            BHRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Benjamin_Harrison";
            webBrowser.Navigate(prefix + "Benjamin_Harrison");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }

        private void DemRadioButton__Click(object sender, EventArgs e)
        {
            FDRRadioButton.Show();
            WJCRadioButton.Show();
            JBRadioButton.Show();
            FPRadioButton.Show();
            BORadioButton.Show();
            JFKRadioButton.Show();
            MVRadioButton.Show();

            BHRadioButton.Hide();
            GWBRadioButton.Hide();
            WMRadioButton.Hide();
            RRRadioButton.Hide();
            DDERadioButton.Hide();
            GWRadioButton.Hide();
            JARadioButton.Hide();
            TRRadioButton.Hide();
            TJRadioButton.Hide();

            FDRRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Franklin_D_Roosevelt";
            webBrowser.Navigate(prefix + "Franklin_D_Roosevelt");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
        }

        private void RepRadioButton__Click(object sender, EventArgs e)
        {
            BHRadioButton.Show();
            GWBRadioButton.Show();
            WMRadioButton.Show();
            RRRadioButton.Show();
            DDERadioButton.Show();
            TRRadioButton.Show();

            FDRRadioButton.Hide();
            WJCRadioButton.Hide();
            JBRadioButton.Hide();
            FPRadioButton.Hide();
            BORadioButton.Hide();
            JFKRadioButton.Hide();
            MVRadioButton.Hide();
            GWRadioButton.Hide();
            JARadioButton.Hide();
            TJRadioButton.Hide();

            BHRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Benjamin_Harrison";
            webBrowser.Navigate(prefix + "Benjamin_Harrison");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }

        private void DemRepRadioButton__Click(object sender, EventArgs e)
        {
            TJRadioButton.Show();

            BHRadioButton.Hide();
            FDRRadioButton.Hide();
            WJCRadioButton.Hide();
            JBRadioButton.Hide();
            FPRadioButton.Hide();
            GWBRadioButton.Hide();
            BORadioButton.Hide();
            JFKRadioButton.Hide();
            WMRadioButton.Hide();
            RRRadioButton.Hide();
            DDERadioButton.Hide();
            MVRadioButton.Hide();
            GWRadioButton.Hide();
            JARadioButton.Hide();
            TRRadioButton.Hide();

            TJRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "Thomas_Jefferson";
            webBrowser.Navigate(prefix + "Thomas_Jefferson");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
        }

        private void FedRadioButton__Click(object sender, EventArgs e)
        {
            GWRadioButton.Show();
            JARadioButton.Show();

            BHRadioButton.Hide();
            FDRRadioButton.Hide();
            WJCRadioButton.Hide();
            JBRadioButton.Hide();
            FPRadioButton.Hide();
            GWBRadioButton.Hide();
            BORadioButton.Hide();
            JFKRadioButton.Hide();
            WMRadioButton.Hide();
            RRRadioButton.Hide();
            DDERadioButton.Hide();
            MVRadioButton.Hide();
            TRRadioButton.Hide();
            TJRadioButton.Hide();

            GWRadioButton.Checked = true;
            wikiGroupBox.Text = prefix + "George_Washington";
            webBrowser.Navigate(prefix + "George_Washington");
            pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
        }

        private void PictureBox__MouseHover(object sender, EventArgs e)
        {
            pictureBox.Width = 280;
            pictureBox.Height = 450;
        }

        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Width = 140;
            pictureBox.Height = 225;
        }


        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}