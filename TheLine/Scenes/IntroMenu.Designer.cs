namespace TheLine
{
    partial class IntroMenu
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
            this.btNewRun = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNewRun
            // 
            this.btNewRun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNewRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btNewRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewRun.ForeColor = System.Drawing.Color.White;
            this.btNewRun.Location = new System.Drawing.Point(0, 0);
            this.btNewRun.Name = "btNewRun";
            this.btNewRun.Size = new System.Drawing.Size(800, 105);
            this.btNewRun.TabIndex = 0;
            this.btNewRun.Text = "New run";
            this.btNewRun.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(800, 105);
            this.button2.TabIndex = 1;
            this.button2.Text = "Shop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(800, 105);
            this.button3.TabIndex = 2;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuit.ForeColor = System.Drawing.Color.White;
            this.btQuit.Location = new System.Drawing.Point(0, 315);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(800, 105);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = false;
            // 
            // IntroMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btNewRun);
            this.Name = "IntroMenu";
            this.Text = "IntroMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewRun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btQuit;
    }
}