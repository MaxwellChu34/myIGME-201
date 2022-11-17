using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chu_MultipleForms
{
    public partial class GameForm : Form
    {
        public GameForm(int low, int high)
        {
            InitializeComponent();
            Random rand = new Random();
            int nRandom = rand.Next(1, 11);
            timer1.Start();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32 idleTime = System.Environment.TickCount - timer1.Interval;
            if (idleTime > 45000)
            {
                //MessageBox.Show("Game Over.");
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
