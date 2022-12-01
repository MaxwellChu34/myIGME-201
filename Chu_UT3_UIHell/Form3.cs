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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(Button1__Click);
        }

        public void Button1__Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
