namespace CityFix.Forms
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpRole = new System.Windows.Forms.GroupBox();
            this.btnResident = new System.Windows.Forms.Button();
            this.btnDispatcher = new System.Windows.Forms.Button();
            this.lblBrigade = new System.Windows.Forms.Label();
            this.cmbBrigade = new System.Windows.Forms.ComboBox();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.lblDbStatus = new System.Windows.Forms.Label();
            this.grpRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "CityFix — Розумне місто";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(33, 68);
            this.lblSubtitle.Text = "Система обробки міських заявок та благоустрою";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 1;
            // 
            // grpRole
            // 
            this.grpRole.Controls.Add(this.btnResident);
            this.grpRole.Controls.Add(this.btnDispatcher);
            this.grpRole.Controls.Add(this.lblBrigade);
            this.grpRole.Controls.Add(this.cmbBrigade);
            this.grpRole.Controls.Add(this.btnMaster);
            this.grpRole.Controls.Add(this.btnAnalytics);
            this.grpRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRole.Location = new System.Drawing.Point(30, 105);
            this.grpRole.Size = new System.Drawing.Size(460, 335);
            this.grpRole.Text = "Оберіть роль користувача";
            this.grpRole.Name = "grpRole";
            this.grpRole.TabIndex = 2;
            // 
            // btnResident
            // 
            this.btnResident.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnResident.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResident.FlatAppearance.BorderSize = 0;
            this.btnResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResident.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResident.ForeColor = System.Drawing.Color.White;
            this.btnResident.Location = new System.Drawing.Point(20, 35);
            this.btnResident.Size = new System.Drawing.Size(420, 45);
            this.btnResident.Text = "Мешканець — створити заявку";
            this.btnResident.UseVisualStyleBackColor = false;
            this.btnResident.Name = "btnResident";
            this.btnResident.TabIndex = 0;
            this.btnResident.Click += new System.EventHandler(this.btnResident_Click);
            // 
            // btnDispatcher
            // 
            this.btnDispatcher.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnDispatcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispatcher.FlatAppearance.BorderSize = 0;
            this.btnDispatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatcher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDispatcher.ForeColor = System.Drawing.Color.White;
            this.btnDispatcher.Location = new System.Drawing.Point(20, 90);
            this.btnDispatcher.Size = new System.Drawing.Size(420, 45);
            this.btnDispatcher.Text = "Диспетчер — обробка заявок";
            this.btnDispatcher.UseVisualStyleBackColor = false;
            this.btnDispatcher.Name = "btnDispatcher";
            this.btnDispatcher.TabIndex = 1;
            this.btnDispatcher.Click += new System.EventHandler(this.btnDispatcher_Click);
            // 
            // lblBrigade
            // 
            this.lblBrigade.AutoSize = true;
            this.lblBrigade.Location = new System.Drawing.Point(20, 150);
            this.lblBrigade.Text = "Бригада майстра:";
            this.lblBrigade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBrigade.Name = "lblBrigade";
            this.lblBrigade.TabIndex = 2;
            // 
            // cmbBrigade
            // 
            this.cmbBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigade.FormattingEnabled = true;
            this.cmbBrigade.Location = new System.Drawing.Point(20, 175);
            this.cmbBrigade.Size = new System.Drawing.Size(420, 25);
            this.cmbBrigade.Name = "cmbBrigade";
            this.cmbBrigade.TabIndex = 3;
            this.cmbBrigade.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnMaster
            // 
            this.btnMaster.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaster.ForeColor = System.Drawing.Color.White;
            this.btnMaster.Location = new System.Drawing.Point(20, 215);
            this.btnMaster.Size = new System.Drawing.Size(420, 45);
            this.btnMaster.Text = "Майстер — виконання робіт";
            this.btnMaster.UseVisualStyleBackColor = false;
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.TabIndex = 4;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAnalytics.Location = new System.Drawing.Point(20, 270);
            this.btnAnalytics.Size = new System.Drawing.Size(420, 45);
            this.btnAnalytics.Text = "Аналітика та звіти";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.TabIndex = 5;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.AutoSize = true;
            this.lblDbStatus.Location = new System.Drawing.Point(30, 455);
            this.lblDbStatus.Text = "Перевірка підключення до бази даних...";
            this.lblDbStatus.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpRole);
            this.Controls.Add(this.lblDbStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFix — Розумне місто";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpRole.ResumeLayout(false);
            this.grpRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpRole;
        private System.Windows.Forms.Button btnResident;
        private System.Windows.Forms.Button btnDispatcher;
        private System.Windows.Forms.Label lblBrigade;
        private System.Windows.Forms.ComboBox cmbBrigade;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Label lblDbStatus;
    }
}
