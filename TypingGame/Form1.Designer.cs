namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelText = new System.Windows.Forms.TextBox();
            this.scoreText = new System.Windows.Forms.TextBox();
            this.needText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 611);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.scoreText);
            this.panel2.Controls.Add(this.needText);
            this.panel2.Controls.Add(this.levelText);
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 108);
            this.panel2.TabIndex = 0;
            // 
            // levelText
            // 
            this.levelText.BackColor = System.Drawing.Color.Black;
            this.levelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelText.ForeColor = System.Drawing.Color.White;
            this.levelText.Location = new System.Drawing.Point(3, 40);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(136, 22);
            this.levelText.TabIndex = 0;
            this.levelText.TabStop = false;
            this.levelText.Text = "Level:";
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.Black;
            this.scoreText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(128, 40);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(100, 22);
            this.scoreText.TabIndex = 1;
            this.scoreText.TabStop = false;
            // 
            // needText
            // 
            this.needText.BackColor = System.Drawing.Color.Black;
            this.needText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.needText.ForeColor = System.Drawing.Color.White;
            this.needText.Location = new System.Drawing.Point(322, 40);
            this.needText.Name = "needText";
            this.needText.Size = new System.Drawing.Size(100, 22);
            this.needText.TabIndex = 2;
            this.needText.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 562);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Typing Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox levelText;
        private System.Windows.Forms.TextBox scoreText;
        private System.Windows.Forms.TextBox needText;
    }
}

