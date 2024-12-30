namespace TheLine
{
    partial class PlayerBoard
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
            this.selectedCharacter = new System.Windows.Forms.PictureBox();
            this.panelBoard = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedCharacter
            // 
            this.selectedCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedCharacter.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedCharacter.Location = new System.Drawing.Point(0, 0);
            this.selectedCharacter.Name = "selectedCharacter";
            this.selectedCharacter.Size = new System.Drawing.Size(148, 150);
            this.selectedCharacter.TabIndex = 1;
            this.selectedCharacter.TabStop = false;
            // 
            // panelBoard
            // 
            this.panelBoard.ColumnCount = 1;
            this.panelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(148, 0);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.RowCount = 1;
            this.panelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBoard.Size = new System.Drawing.Size(719, 150);
            this.panelBoard.TabIndex = 2;
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.selectedCharacter);
            this.Name = "PlayerBoard";
            this.Size = new System.Drawing.Size(867, 150);
            ((System.ComponentModel.ISupportInitialize)(this.selectedCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox selectedCharacter;
        private System.Windows.Forms.TableLayoutPanel panelBoard;
    }
}
