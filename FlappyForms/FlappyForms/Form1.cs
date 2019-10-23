using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyForms
{
    public partial class MainForm : Form
    {
        int flappyVelocity = 10;
        public MainForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flappyBox.Location.Y < moveArea.Height - flappyBox.Height)
            {
                flappyBox.Location = new Point(flappyBox.Location.X, flappyBox.Location.Y + flappyVelocity);
            }
        }
    }
}
