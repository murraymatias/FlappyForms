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

            Random r = new Random();

            upTube.Size = new Size(this.Width / 10, this.Height);
            upTube2.Size = new Size(this.Width / 10, this.Height);
            upTube3.Size = new Size(this.Width / 10, this.Height);
            upTube4.Size = new Size(this.Width / 10, this.Height);
            upTube5.Size = new Size(this.Width / 10, this.Height);

            downTube.Size = new Size(this.Width / 10, this.Height);
            downTube2.Size = new Size(this.Width / 10, this.Height);
            downTube3.Size = new Size(this.Width / 10, this.Height);
            downTube4.Size = new Size(this.Width / 10, this.Height);
            downTube5.Size = new Size(this.Width / 10, this.Height);

            upTube.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height+this.Height * 0.2), Convert.ToInt32(-this.Height+this.Height * 0.5)));
            downTube.Location = new Point(this.Width, upTube.Location.Y + Convert.ToInt32(this.Height * 1.3));

            upTube2.Location = new Point(this.Width + this.Width/4, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
            downTube2.Location = new Point(this.Width + this.Width / 4, upTube2.Location.Y + Convert.ToInt32(this.Height * 1.3));

            upTube3.Location = new Point(this.Width + this.Width / 2, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
            downTube3.Location = new Point(this.Width + this.Width / 2, upTube3.Location.Y + Convert.ToInt32(this.Height * 1.3));

            upTube4.Location = new Point(this.Width + this.Width * 3 / 4, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
            downTube4.Location = new Point(this.Width + this.Width * 3 / 4, upTube4.Location.Y + Convert.ToInt32(this.Height * 1.3));

            upTube5.Location = new Point(this.Width * 2, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
            downTube5.Location = new Point(this.Width * 2, upTube5.Location.Y + Convert.ToInt32(this.Height * 1.3));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            //Actualiza posion de flappy
            if (flappyBox.Location.Y < moveArea.Height - flappyBox.Height)
            {
                flappyBox.Location = new Point(flappyBox.Location.X, flappyBox.Location.Y + flappyVelocity);
            }

            //Disminuye la velocidad del salto ("gravedad")
            if(flappyVelocity < 5)
            {
                flappyVelocity++;
            }

            //Avanza los tubos
            upTube5.Location = new Point(upTube5.Location.X - 2, upTube5.Location.Y);
            downTube5.Location = new Point(downTube5.Location.X - 2, downTube5.Location.Y);

            upTube4.Location = new Point(upTube4.Location.X - 2, upTube4.Location.Y);
            downTube4.Location = new Point(downTube4.Location.X - 2, downTube4.Location.Y);

            upTube3.Location = new Point(upTube3.Location.X - 2, upTube3.Location.Y);
            downTube3.Location = new Point(downTube3.Location.X - 2, downTube3.Location.Y);

            upTube2.Location = new Point(upTube2.Location.X - 2, upTube2.Location.Y);
            downTube2.Location = new Point(downTube2.Location.X - 2, downTube2.Location.Y);

            upTube.Location = new Point(upTube.Location.X - 2, upTube.Location.Y);
            downTube.Location = new Point(downTube.Location.X - 2, downTube.Location.Y);

            //Reposicionamiento
            if(upTube.Location.X <= -this.Width * 0.25)
            {
                upTube.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
                downTube.Location = new Point(this.Width, upTube.Location.Y + Convert.ToInt32(this.Height * 1.3));
            }

            if(upTube2.Location.X <= -this.Width * 0.25)
            {
                upTube2.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
                downTube2.Location = new Point(this.Width, upTube2.Location.Y + Convert.ToInt32(this.Height * 1.3));
            }

            if (upTube3.Location.X <= -this.Width * 0.25)
            {
                upTube3.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
                downTube3.Location = new Point(this.Width, upTube3.Location.Y + Convert.ToInt32(this.Height * 1.3));
            }

            if(upTube4.Location.X <= -this.Width * 0.25)
            {
                upTube4.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
                downTube4.Location = new Point(this.Width, upTube4.Location.Y + Convert.ToInt32(this.Height * 1.3));
            }

            if(upTube5.Location.X <= -this.Width * 0.25)
            {
                upTube5.Location = new Point(this.Width, r.Next(Convert.ToInt32(-this.Height + this.Height * 0.2), Convert.ToInt32(-this.Height + this.Height * 0.5)));
                downTube5.Location = new Point(this.Width, upTube5.Location.Y + Convert.ToInt32(this.Height * 1.3));
            }

            
            //Compueba colisiones
            if((flappyBox.Location.Y <= upTube.Location.Y + upTube.Height && flappyBox.Location.X + flappyBox.Width >= upTube.Location.X && flappyBox.Location.X <= upTube.Location.X + upTube.Width) ||
                (flappyBox.Location.Y + flappyBox.Height >= downTube.Location.Y && flappyBox.Location.X + flappyBox.Width >= downTube.Location.X && flappyBox.Location.X <= downTube.Location.X + downTube.Width) ||
                (flappyBox.Location.Y <= upTube2.Location.Y + upTube2.Height && flappyBox.Location.X + flappyBox.Width >= upTube2.Location.X && flappyBox.Location.X <= upTube2.Location.X + upTube2.Width) ||
                (flappyBox.Location.Y + flappyBox.Height >= downTube2.Location.Y && flappyBox.Location.X + flappyBox.Width >= downTube2.Location.X && flappyBox.Location.X <= downTube2.Location.X + downTube2.Width)||
                (flappyBox.Location.Y <= upTube3.Location.Y + upTube3.Height && flappyBox.Location.X + flappyBox.Width >= upTube3.Location.X && flappyBox.Location.X <= upTube3.Location.X + upTube3.Width) ||
                (flappyBox.Location.Y + flappyBox.Height >= downTube3.Location.Y && flappyBox.Location.X + flappyBox.Width >= downTube3.Location.X && flappyBox.Location.X <= downTube3.Location.X + downTube3.Width) ||
                (flappyBox.Location.Y <= upTube4.Location.Y + upTube4.Height && flappyBox.Location.X + flappyBox.Width >= upTube4.Location.X && flappyBox.Location.X <= upTube4.Location.X + upTube4.Width) ||
                (flappyBox.Location.Y + flappyBox.Height >= downTube4.Location.Y && flappyBox.Location.X + flappyBox.Width >= downTube4.Location.X && flappyBox.Location.X <= downTube4.Location.X + downTube4.Width) ||
                (flappyBox.Location.Y <= upTube5.Location.Y + upTube5.Height && flappyBox.Location.X + flappyBox.Width >= upTube5.Location.X && flappyBox.Location.X <= upTube5.Location.X + upTube5.Width) ||
                (flappyBox.Location.Y + flappyBox.Height >= downTube5.Location.Y && flappyBox.Location.X + flappyBox.Width >= downTube5.Location.X && flappyBox.Location.X <= downTube5.Location.X + downTube5.Width))
            {
                timer1.Stop();
                MessageBox.Show("Sos un boludo", "Perdiste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Arranca el timer con la tecla S
            if(e.KeyCode == Keys.S)
            {
                timer1.Start();
            }

            //Genera el salto de flappy modificando su velocidad de movimiento
            if(e.KeyCode == Keys.Space)
            {
                flappyVelocity = -6;
                flappyBox.Location = new Point(flappyBox.Location.X, flappyBox.Location.Y + flappyVelocity);
            }
        }
    }
}
