namespace TheLine
{
    partial class CharacterDescription
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.pbCharImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.57005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.42995F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(175, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 90);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescription.Location = new System.Drawing.Point(175, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(636, 43);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "Do this";
            // 
            // pbCharImg
            // 
            this.pbCharImg.BackgroundImage = global::TheLine.Properties.Resources.Perso1;
            this.pbCharImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCharImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCharImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCharImg.Location = new System.Drawing.Point(0, 0);
            this.pbCharImg.Name = "pbCharImg";
            this.pbCharImg.Size = new System.Drawing.Size(175, 133);
            this.pbCharImg.TabIndex = 0;
            this.pbCharImg.TabStop = false;
            // 
            // CharacterDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.pbCharImg);
            this.Name = "CharacterDescription";
            this.Size = new System.Drawing.Size(811, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDescription;
    }
}
