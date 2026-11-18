namespace CityFix.Forms
{
    partial class PhotoViewForm
    {
        /// <summary>
        /// Обов'язкова змінна дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнення ресурсів форми.
        /// </summary>
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
        /// Метод створення елементів форми (його редагує Designer Visual Studio).
        /// </summary>
        private void InitializeComponent()
        {
            this.picLarge = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // picLarge
            // 
            this.picLarge.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.picLarge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLarge.Location = new System.Drawing.Point(0, 0);
            this.picLarge.Size = new System.Drawing.Size(900, 605);
            this.picLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLarge.TabStop = false;
            this.picLarge.Name = "picLarge";
            this.picLarge.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 605);
            this.btnClose.Size = new System.Drawing.Size(900, 45);
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PhotoViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.picLarge);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "PhotoViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд фотографії";
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLarge;
        private System.Windows.Forms.Button btnClose;
    }
}
