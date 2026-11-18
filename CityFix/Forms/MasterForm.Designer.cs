namespace CityFix.Forms
{
    partial class MasterForm
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
            this.lblBrigadeInfo = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMyRequests = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.progressWork = new System.Windows.Forms.ProgressBar();
            this.lblStageText = new System.Windows.Forms.Label();
            this.grpPhotos = new System.Windows.Forms.GroupBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.lblAfter = new System.Windows.Forms.Label();
            this.picAfter = new System.Windows.Forms.PictureBox();
            this.lblZoomHint = new System.Windows.Forms.Label();
            this.btnAddAfterPhoto = new System.Windows.Forms.Button();
            this.grpMaterials = new System.Windows.Forms.GroupBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.dgvUsedMaterials = new System.Windows.Forms.DataGridView();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.grpInfo.SuspendLayout();
            this.grpPhotos.SuspendLayout();
            this.grpMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrigadeInfo
            // 
            this.lblBrigadeInfo.AutoSize = true;
            this.lblBrigadeInfo.Location = new System.Drawing.Point(15, 12);
            this.lblBrigadeInfo.Text = "Бригада:";
            this.lblBrigadeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrigadeInfo.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblBrigadeInfo.Name = "lblBrigadeInfo";
            this.lblBrigadeInfo.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnRefresh.Location = new System.Drawing.Point(1065, 8);
            this.btnRefresh.Size = new System.Drawing.Size(120, 32);
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMyRequests
            // 
            this.dgvMyRequests.AllowUserToAddRows = false;
            this.dgvMyRequests.AllowUserToDeleteRows = false;
            this.dgvMyRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRequests.Location = new System.Drawing.Point(15, 50);
            this.dgvMyRequests.MultiSelect = false;
            this.dgvMyRequests.ReadOnly = true;
            this.dgvMyRequests.RowHeadersVisible = false;
            this.dgvMyRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyRequests.Size = new System.Drawing.Size(560, 300);
            this.dgvMyRequests.Name = "dgvMyRequests";
            this.dgvMyRequests.TabIndex = 2;
            this.dgvMyRequests.SelectionChanged += new System.EventHandler(this.dgvMyRequests_SelectionChanged);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(15, 360);
            this.grpInfo.Size = new System.Drawing.Size(560, 200);
            this.grpInfo.Text = "Інформація про заявку";
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 25);
            this.lblInfo.Size = new System.Drawing.Size(535, 165);
            this.lblInfo.Text = "Оберіть заявку в таблиці";
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.TabIndex = 0;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(15, 570);
            this.lblStage.Text = "Етап виконання:";
            this.lblStage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStage.Name = "lblStage";
            this.lblStage.TabIndex = 4;
            // 
            // progressWork
            // 
            this.progressWork.Location = new System.Drawing.Point(15, 595);
            this.progressWork.Size = new System.Drawing.Size(560, 25);
            this.progressWork.Name = "progressWork";
            this.progressWork.TabIndex = 5;
            // 
            // lblStageText
            // 
            this.lblStageText.AutoSize = true;
            this.lblStageText.Location = new System.Drawing.Point(15, 628);
            this.lblStageText.Text = "—";
            this.lblStageText.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblStageText.Name = "lblStageText";
            this.lblStageText.TabIndex = 6;
            // 
            // grpPhotos
            // 
            this.grpPhotos.Controls.Add(this.lblBefore);
            this.grpPhotos.Controls.Add(this.picBefore);
            this.grpPhotos.Controls.Add(this.lblAfter);
            this.grpPhotos.Controls.Add(this.picAfter);
            this.grpPhotos.Controls.Add(this.lblZoomHint);
            this.grpPhotos.Controls.Add(this.btnAddAfterPhoto);
            this.grpPhotos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhotos.Location = new System.Drawing.Point(590, 45);
            this.grpPhotos.Size = new System.Drawing.Size(595, 260);
            this.grpPhotos.Text = "Фотографії";
            this.grpPhotos.Name = "grpPhotos";
            this.grpPhotos.TabIndex = 7;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(12, 25);
            this.lblBefore.Text = "Фото «До» (від мешканця):";
            this.lblBefore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.TabIndex = 0;
            // 
            // picBefore
            // 
            this.picBefore.BackColor = System.Drawing.Color.White;
            this.picBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBefore.Location = new System.Drawing.Point(12, 48);
            this.picBefore.Size = new System.Drawing.Size(280, 160);
            this.picBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBefore.TabStop = false;
            this.picBefore.Name = "picBefore";
            this.picBefore.TabIndex = 1;
            this.picBefore.DoubleClick += new System.EventHandler(this.picBefore_DoubleClick);
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(305, 25);
            this.lblAfter.Text = "Фото «Після» (результат):";
            this.lblAfter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.TabIndex = 2;
            // 
            // picAfter
            // 
            this.picAfter.BackColor = System.Drawing.Color.White;
            this.picAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAfter.Location = new System.Drawing.Point(305, 48);
            this.picAfter.Size = new System.Drawing.Size(280, 160);
            this.picAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAfter.TabStop = false;
            this.picAfter.Name = "picAfter";
            this.picAfter.TabIndex = 3;
            this.picAfter.DoubleClick += new System.EventHandler(this.picAfter_DoubleClick);
            // 
            // lblZoomHint
            // 
            this.lblZoomHint.AutoSize = true;
            this.lblZoomHint.Location = new System.Drawing.Point(12, 222);
            this.lblZoomHint.Text = "Подвійний клік — збільшити";
            this.lblZoomHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblZoomHint.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblZoomHint.Name = "lblZoomHint";
            this.lblZoomHint.TabIndex = 4;
            // 
            // btnAddAfterPhoto
            // 
            this.btnAddAfterPhoto.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAddAfterPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAfterPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddAfterPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAfterPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAfterPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddAfterPhoto.Location = new System.Drawing.Point(305, 215);
            this.btnAddAfterPhoto.Size = new System.Drawing.Size(280, 35);
            this.btnAddAfterPhoto.Text = "Додати фото «Після»...";
            this.btnAddAfterPhoto.UseVisualStyleBackColor = false;
            this.btnAddAfterPhoto.Name = "btnAddAfterPhoto";
            this.btnAddAfterPhoto.TabIndex = 5;
            this.btnAddAfterPhoto.Click += new System.EventHandler(this.btnAddAfterPhoto_Click);
            // 
            // grpMaterials
            // 
            this.grpMaterials.Controls.Add(this.lblMaterial);
            this.grpMaterials.Controls.Add(this.cmbMaterials);
            this.grpMaterials.Controls.Add(this.lblQty);
            this.grpMaterials.Controls.Add(this.nudQty);
            this.grpMaterials.Controls.Add(this.lblUnit);
            this.grpMaterials.Controls.Add(this.btnAddMaterial);
            this.grpMaterials.Controls.Add(this.btnRemoveMaterial);
            this.grpMaterials.Controls.Add(this.dgvUsedMaterials);
            this.grpMaterials.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMaterials.Location = new System.Drawing.Point(590, 315);
            this.grpMaterials.Size = new System.Drawing.Size(595, 300);
            this.grpMaterials.Text = "Використані матеріали";
            this.grpMaterials.Name = "grpMaterials";
            this.grpMaterials.TabIndex = 8;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(12, 28);
            this.lblMaterial.Text = "Матеріал:";
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.TabIndex = 0;
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(12, 50);
            this.cmbMaterials.Size = new System.Drawing.Size(300, 25);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.TabIndex = 1;
            this.cmbMaterials.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaterials.SelectedIndexChanged += new System.EventHandler(this.cmbMaterials_SelectedIndexChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(325, 28);
            this.lblQty.Text = "Кількість:";
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQty.Name = "lblQty";
            this.lblQty.TabIndex = 2;
            // 
            // nudQty
            // 
            this.nudQty.DecimalPlaces = 2;
            this.nudQty.Location = new System.Drawing.Point(325, 50);
            this.nudQty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudQty.Size = new System.Drawing.Size(110, 25);
            this.nudQty.Name = "nudQty";
            this.nudQty.TabIndex = 3;
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(442, 53);
            this.lblUnit.Text = "—";
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.TabIndex = 4;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMaterial.FlatAppearance.BorderSize = 0;
            this.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 88);
            this.btnAddMaterial.Size = new System.Drawing.Size(200, 34);
            this.btnAddMaterial.Text = "Додати до списку";
            this.btnAddMaterial.UseVisualStyleBackColor = false;
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.TabIndex = 5;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnRemoveMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMaterial.FlatAppearance.BorderSize = 0;
            this.btnRemoveMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveMaterial.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnRemoveMaterial.Location = new System.Drawing.Point(222, 88);
            this.btnRemoveMaterial.Size = new System.Drawing.Size(200, 34);
            this.btnRemoveMaterial.Text = "Видалити рядок";
            this.btnRemoveMaterial.UseVisualStyleBackColor = false;
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.TabIndex = 6;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // dgvUsedMaterials
            // 
            this.dgvUsedMaterials.AllowUserToAddRows = false;
            this.dgvUsedMaterials.AllowUserToDeleteRows = false;
            this.dgvUsedMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsedMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsedMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsedMaterials.Location = new System.Drawing.Point(12, 130);
            this.dgvUsedMaterials.MultiSelect = false;
            this.dgvUsedMaterials.ReadOnly = true;
            this.dgvUsedMaterials.RowHeadersVisible = false;
            this.dgvUsedMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsedMaterials.Size = new System.Drawing.Size(570, 160);
            this.dgvUsedMaterials.Name = "dgvUsedMaterials";
            this.dgvUsedMaterials.TabIndex = 7;
            this.dgvUsedMaterials.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnStartWork
            // 
            this.btnStartWork.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnStartWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartWork.FlatAppearance.BorderSize = 0;
            this.btnStartWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartWork.ForeColor = System.Drawing.Color.White;
            this.btnStartWork.Location = new System.Drawing.Point(590, 630);
            this.btnStartWork.Size = new System.Drawing.Size(290, 45);
            this.btnStartWork.Text = "Почати роботу";
            this.btnStartWork.UseVisualStyleBackColor = false;
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.TabIndex = 9;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(895, 630);
            this.btnComplete.Size = new System.Drawing.Size(290, 45);
            this.btnComplete.Text = "Завершити заявку";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.Filter = "Зображення|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialogPhoto.Title = "Оберіть фото результату ремонту";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lblBrigadeInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvMyRequests);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.progressWork);
            this.Controls.Add(this.lblStageText);
            this.Controls.Add(this.grpPhotos);
            this.Controls.Add(this.grpMaterials);
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.btnComplete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFix — Робоче місце майстра";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedMaterials)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpPhotos.ResumeLayout(false);
            this.grpPhotos.PerformLayout();
            this.grpMaterials.ResumeLayout(false);
            this.grpMaterials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBrigadeInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMyRequests;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.ProgressBar progressWork;
        private System.Windows.Forms.Label lblStageText;
        private System.Windows.Forms.GroupBox grpPhotos;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.PictureBox picBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.PictureBox picAfter;
        private System.Windows.Forms.Label lblZoomHint;
        private System.Windows.Forms.Button btnAddAfterPhoto;
        private System.Windows.Forms.GroupBox grpMaterials;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.DataGridView dgvUsedMaterials;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}
