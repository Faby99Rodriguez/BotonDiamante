namespace BotonDiamante
{
    partial class UCDiamantee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDiamantee));
            this.btnDiamant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiamant
            // 
            this.btnDiamant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiamant.BackgroundImage")));
            this.btnDiamant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiamant.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiamant.ForeColor = System.Drawing.Color.Crimson;
            this.btnDiamant.Location = new System.Drawing.Point(0, 0);
            this.btnDiamant.Name = "btnDiamant";
            this.btnDiamant.Size = new System.Drawing.Size(300, 250);
            this.btnDiamant.TabIndex = 0;
            this.btnDiamant.Text = "DIAMANTE";
            this.btnDiamant.UseVisualStyleBackColor = true;
            this.btnDiamant.Click += new System.EventHandler(this.btnDiamant_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDiamant);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(300, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiamant;
    }
}
