namespace TheLine
{
    partial class ElemCounter
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
            this.pbElemCount = new System.Windows.Forms.PictureBox();
            this.lbNumberElem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbElemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbElemCount
            // 
            this.pbElemCount.BackColor = System.Drawing.Color.IndianRed;
            this.pbElemCount.BackgroundImage = global::TheLine.Properties.Resources.ElementCount;
            this.pbElemCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbElemCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbElemCount.Location = new System.Drawing.Point(0, 0);
            this.pbElemCount.Name = "pbElemCount";
            this.pbElemCount.Size = new System.Drawing.Size(40, 40);
            this.pbElemCount.TabIndex = 0;
            this.pbElemCount.TabStop = false;
            // 
            // lbNumberElem
            // 
            this.lbNumberElem.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberElem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumberElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberElem.ForeColor = System.Drawing.Color.Black;
            this.lbNumberElem.Location = new System.Drawing.Point(0, 0);
            this.lbNumberElem.Name = "lbNumberElem";
            this.lbNumberElem.Size = new System.Drawing.Size(40, 40);
            this.lbNumberElem.TabIndex = 2;
            this.lbNumberElem.Text = "100";
            this.lbNumberElem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElemCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNumberElem);
            this.Controls.Add(this.pbElemCount);
            this.Name = "ElemCounter";
            this.Size = new System.Drawing.Size(40, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pbElemCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbElemCount;
        private System.Windows.Forms.Label lbNumberElem;
    }
}
