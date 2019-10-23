namespace FlappyForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moveArea = new System.Windows.Forms.Panel();
            this.flappyBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moveArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // moveArea
            // 
            this.moveArea.Controls.Add(this.flappyBox);
            this.moveArea.Location = new System.Drawing.Point(0, 0);
            this.moveArea.Name = "moveArea";
            this.moveArea.Size = new System.Drawing.Size(800, 450);
            this.moveArea.TabIndex = 0;
            // 
            // flappyBox
            // 
            this.flappyBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flappyBox.Location = new System.Drawing.Point(250, 150);
            this.flappyBox.Name = "flappyBox";
            this.flappyBox.Size = new System.Drawing.Size(30, 30);
            this.flappyBox.TabIndex = 0;
            this.flappyBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.moveArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel moveArea;
        private System.Windows.Forms.PictureBox flappyBox;
        private System.Windows.Forms.Timer timer1;
    }
}

