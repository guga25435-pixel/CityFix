namespace CityFix.Forms
{
    partial class DispatcherForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabRequests = new System.Windows.Forms.TabPage();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblOverdueHint = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblRequestInfo = new System.Windows.Forms.Label();
            this.lblPhotoBefore = new System.Windows.Forms.Label();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.lblPhotoAfter = new System.Windows.Forms.Label();
            this.picAfter = new System.Windows.Forms.PictureBox();
            this.lblDeadlineTitle = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblBrigadeAssign = new System.Windows.Forms.Label();
            this.cmbBrigades = new System.Windows.Forms.ComboBox();
            this.btnAssignBrigade = new System.Windows.Forms.Button();
            this.lblZoomHint = new System.Windows.Forms.Label();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.grpNewMaterial = new System.Windows.Forms.GroupBox();
            this.lblMatName = new System.Windows.Forms.Label();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.lblMatUnit = new System.Windows.Forms.Label();
            this.txtMatUnit = new System.Windows.Forms.TextBox();
            this.lblMatPrice = new System.Windows.Forms.Label();
            this.nudMatPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMatQty = new System.Windows.Forms.Label();
            this.nudMatQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.lblStockHint = new System.Windows.Forms.Label();
            this.nudStockQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabRequests.SuspendLayout();
            this.tabMaterials.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpNewMaterial.SuspendLayout();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabRequests);
            this.tabMain.Controls.Add(this.tabMaterials);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1200, 720);
            this.tabMain.Name = "tabMain";
            this.tabMain.TabIndex = 0;
            // 
            // tabRequests
            // 
            this.tabRequests.Controls.Add(this.lblFilter);
            this.tabRequests.Controls.Add(this.cmbStatusFilter);
            this.tabRequests.Controls.Add(this.btnRefresh);
            this.tabRequests.Controls.Add(this.lblCount);
            this.tabRequests.Controls.Add(this.lblOverdueHint);
            this.tabRequests.Controls.Add(this.dgvRequests);
            this.tabRequests.Controls.Add(this.grpDetails);
            this.tabRequests.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.tabRequests.Location = new System.Drawing.Point(4, 29);
            this.tabRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequests.Size = new System.Drawing.Size(1192, 687);
            this.tabRequests.Text = "Заявки";
            this.tabRequests.Name = "tabRequests";
            this.tabRequests.TabIndex = 0;
            // 
            // tabMaterials
            // 
            this.tabMaterials.Controls.Add(this.dgvMaterials);
            this.tabMaterials.Controls.Add(this.grpNewMaterial);
            this.tabMaterials.Controls.Add(this.grpStock);
            this.tabMaterials.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.tabMaterials.Location = new System.Drawing.Point(4, 29);
            this.tabMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterials.Size = new System.Drawing.Size(1192, 687);
            this.tabMaterials.Text = "Склад матеріалів";
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 15);
            this.lblFilter.Text = "Фільтр за статусом:";
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.TabIndex = 0;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Items.AddRange(new object[] { "Усі", "Нова", "На перевірці", "Призначена бригада", "У роботі", "Виконана", "Відхилена", "Прострочені" });
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(165, 12);
            this.cmbStatusFilter.Size = new System.Drawing.Size(200, 25);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.TabIndex = 1;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnRefresh.Location = new System.Drawing.Point(380, 9);
            this.btnRefresh.Size = new System.Drawing.Size(120, 32);
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(520, 15);
            this.lblCount.Text = "Заявок: 0";
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.Name = "lblCount";
            this.lblCount.TabIndex = 3;
            // 
            // lblOverdueHint
            // 
            this.lblOverdueHint.AutoSize = true;
            this.lblOverdueHint.Location = new System.Drawing.Point(650, 15);
            this.lblOverdueHint.Text = "Червоним позначено прострочені заявки";
            this.lblOverdueHint.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblOverdueHint.Name = "lblOverdueHint";
            this.lblOverdueHint.TabIndex = 4;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(15, 50);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(760, 620);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.TabIndex = 5;
            this.dgvRequests.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRequests_DataBindingComplete);
            this.dgvRequests.SelectionChanged += new System.EventHandler(this.dgvRequests_SelectionChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblRequestInfo);
            this.grpDetails.Controls.Add(this.lblPhotoBefore);
            this.grpDetails.Controls.Add(this.picBefore);
            this.grpDetails.Controls.Add(this.lblPhotoAfter);
            this.grpDetails.Controls.Add(this.picAfter);
            this.grpDetails.Controls.Add(this.lblDeadlineTitle);
            this.grpDetails.Controls.Add(this.dtpDeadline);
            this.grpDetails.Controls.Add(this.lblTimeLeft);
            this.grpDetails.Controls.Add(this.lblNewStatus);
            this.grpDetails.Controls.Add(this.cmbNewStatus);
            this.grpDetails.Controls.Add(this.btnChangeStatus);
            this.grpDetails.Controls.Add(this.lblBrigadeAssign);
            this.grpDetails.Controls.Add(this.cmbBrigades);
            this.grpDetails.Controls.Add(this.btnAssignBrigade);
            this.grpDetails.Controls.Add(this.lblZoomHint);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(790, 45);
            this.grpDetails.Size = new System.Drawing.Size(390, 630);
            this.grpDetails.Text = "Обрана заявка";
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.TabIndex = 6;
            // 
            // lblRequestInfo
            // 
            this.lblRequestInfo.Location = new System.Drawing.Point(12, 25);
            this.lblRequestInfo.Size = new System.Drawing.Size(365, 150);
            this.lblRequestInfo.Text = "Оберіть заявку в таблиці";
            this.lblRequestInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRequestInfo.Name = "lblRequestInfo";
            this.lblRequestInfo.TabIndex = 0;
            // 
            // lblPhotoBefore
            // 
            this.lblPhotoBefore.AutoSize = true;
            this.lblPhotoBefore.Location = new System.Drawing.Point(12, 180);
            this.lblPhotoBefore.Text = "Фото «До»:";
            this.lblPhotoBefore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhotoBefore.Name = "lblPhotoBefore";
            this.lblPhotoBefore.TabIndex = 1;
            // 
            // picBefore
            // 
            this.picBefore.BackColor = System.Drawing.Color.White;
            this.picBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBefore.Location = new System.Drawing.Point(12, 200);
            this.picBefore.Size = new System.Drawing.Size(175, 130);
            this.picBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBefore.TabStop = false;
            this.picBefore.Name = "picBefore";
            this.picBefore.TabIndex = 2;
            this.picBefore.DoubleClick += new System.EventHandler(this.picBefore_DoubleClick);
            // 
            // lblPhotoAfter
            // 
            this.lblPhotoAfter.AutoSize = true;
            this.lblPhotoAfter.Location = new System.Drawing.Point(200, 180);
            this.lblPhotoAfter.Text = "Фото «Після»:";
            this.lblPhotoAfter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhotoAfter.Name = "lblPhotoAfter";
            this.lblPhotoAfter.TabIndex = 3;
            // 
            // picAfter
            // 
            this.picAfter.BackColor = System.Drawing.Color.White;
            this.picAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAfter.Location = new System.Drawing.Point(200, 200);
            this.picAfter.Size = new System.Drawing.Size(175, 130);
            this.picAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAfter.TabStop = false;
            this.picAfter.Name = "picAfter";
            this.picAfter.TabIndex = 4;
            this.picAfter.DoubleClick += new System.EventHandler(this.picAfter_DoubleClick);
            // 
            // lblDeadlineTitle
            // 
            this.lblDeadlineTitle.AutoSize = true;
            this.lblDeadlineTitle.Location = new System.Drawing.Point(12, 341);
            this.lblDeadlineTitle.Text = "Кінцевий термін:";
            this.lblDeadlineTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeadlineTitle.Name = "lblDeadlineTitle";
            this.lblDeadlineTitle.TabIndex = 5;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDeadline.Enabled = false;
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(140, 337);
            this.dtpDeadline.Size = new System.Drawing.Size(235, 25);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.TabIndex = 6;
            this.dtpDeadline.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Location = new System.Drawing.Point(12, 370);
            this.lblTimeLeft.Size = new System.Drawing.Size(365, 25);
            this.lblTimeLeft.Text = "—";
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.TabIndex = 7;
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(12, 405);
            this.lblNewStatus.Text = "Новий статус:";
            this.lblNewStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.TabIndex = 8;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.Items.AddRange(new object[] { "Нова", "На перевірці", "Призначена бригада", "У роботі", "Виконана", "Відхилена" });
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Location = new System.Drawing.Point(12, 430);
            this.cmbNewStatus.Size = new System.Drawing.Size(230, 25);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.TabIndex = 9;
            this.cmbNewStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(250, 427);
            this.btnChangeStatus.Size = new System.Drawing.Size(125, 32);
            this.btnChangeStatus.Text = "Змінити";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.TabIndex = 10;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // lblBrigadeAssign
            // 
            this.lblBrigadeAssign.AutoSize = true;
            this.lblBrigadeAssign.Location = new System.Drawing.Point(12, 475);
            this.lblBrigadeAssign.Text = "Бригада для виконання:";
            this.lblBrigadeAssign.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBrigadeAssign.Name = "lblBrigadeAssign";
            this.lblBrigadeAssign.TabIndex = 11;
            // 
            // cmbBrigades
            // 
            this.cmbBrigades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigades.FormattingEnabled = true;
            this.cmbBrigades.Location = new System.Drawing.Point(12, 500);
            this.cmbBrigades.Size = new System.Drawing.Size(365, 25);
            this.cmbBrigades.Name = "cmbBrigades";
            this.cmbBrigades.TabIndex = 12;
            this.cmbBrigades.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnAssignBrigade
            // 
            this.btnAssignBrigade.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAssignBrigade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignBrigade.FlatAppearance.BorderSize = 0;
            this.btnAssignBrigade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignBrigade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignBrigade.ForeColor = System.Drawing.Color.White;
            this.btnAssignBrigade.Location = new System.Drawing.Point(12, 540);
            this.btnAssignBrigade.Size = new System.Drawing.Size(365, 40);
            this.btnAssignBrigade.Text = "Призначити бригаду";
            this.btnAssignBrigade.UseVisualStyleBackColor = false;
            this.btnAssignBrigade.Name = "btnAssignBrigade";
            this.btnAssignBrigade.TabIndex = 13;
            this.btnAssignBrigade.Click += new System.EventHandler(this.btnAssignBrigade_Click);
            // 
            // lblZoomHint
            // 
            this.lblZoomHint.AutoSize = true;
            this.lblZoomHint.Location = new System.Drawing.Point(12, 595);
            this.lblZoomHint.Text = "Подвійний клік по фото — збільшити";
            this.lblZoomHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblZoomHint.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblZoomHint.Name = "lblZoomHint";
            this.lblZoomHint.TabIndex = 14;
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(15, 15);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.RowHeadersVisible = false;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(760, 640);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.TabIndex = 0;
            // 
            // grpNewMaterial
            // 
            this.grpNewMaterial.Controls.Add(this.lblMatName);
            this.grpNewMaterial.Controls.Add(this.txtMatName);
            this.grpNewMaterial.Controls.Add(this.lblMatUnit);
            this.grpNewMaterial.Controls.Add(this.txtMatUnit);
            this.grpNewMaterial.Controls.Add(this.lblMatPrice);
            this.grpNewMaterial.Controls.Add(this.nudMatPrice);
            this.grpNewMaterial.Controls.Add(this.lblMatQty);
            this.grpNewMaterial.Controls.Add(this.nudMatQty);
            this.grpNewMaterial.Controls.Add(this.btnAddMaterial);
            this.grpNewMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNewMaterial.Location = new System.Drawing.Point(790, 15);
            this.grpNewMaterial.Size = new System.Drawing.Size(390, 290);
            this.grpNewMaterial.Text = "Новий матеріал";
            this.grpNewMaterial.Name = "grpNewMaterial";
            this.grpNewMaterial.TabIndex = 1;
            // 
            // lblMatName
            // 
            this.lblMatName.AutoSize = true;
            this.lblMatName.Location = new System.Drawing.Point(12, 30);
            this.lblMatName.Text = "Назва:";
            this.lblMatName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatName.Name = "lblMatName";
            this.lblMatName.TabIndex = 0;
            // 
            // txtMatName
            // 
            this.txtMatName.Location = new System.Drawing.Point(12, 55);
            this.txtMatName.Size = new System.Drawing.Size(365, 25);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.TabIndex = 1;
            this.txtMatName.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblMatUnit
            // 
            this.lblMatUnit.AutoSize = true;
            this.lblMatUnit.Location = new System.Drawing.Point(12, 90);
            this.lblMatUnit.Text = "Одиниця виміру:";
            this.lblMatUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatUnit.Name = "lblMatUnit";
            this.lblMatUnit.TabIndex = 2;
            // 
            // txtMatUnit
            // 
            this.txtMatUnit.Location = new System.Drawing.Point(12, 115);
            this.txtMatUnit.Size = new System.Drawing.Size(170, 25);
            this.txtMatUnit.Name = "txtMatUnit";
            this.txtMatUnit.TabIndex = 3;
            this.txtMatUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblMatPrice
            // 
            this.lblMatPrice.AutoSize = true;
            this.lblMatPrice.Location = new System.Drawing.Point(200, 90);
            this.lblMatPrice.Text = "Ціна за од., грн:";
            this.lblMatPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatPrice.Name = "lblMatPrice";
            this.lblMatPrice.TabIndex = 4;
            // 
            // nudMatPrice
            // 
            this.nudMatPrice.DecimalPlaces = 2;
            this.nudMatPrice.Location = new System.Drawing.Point(200, 115);
            this.nudMatPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudMatPrice.Size = new System.Drawing.Size(177, 25);
            this.nudMatPrice.Name = "nudMatPrice";
            this.nudMatPrice.TabIndex = 5;
            this.nudMatPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblMatQty
            // 
            this.lblMatQty.AutoSize = true;
            this.lblMatQty.Location = new System.Drawing.Point(12, 150);
            this.lblMatQty.Text = "Початкова кількість:";
            this.lblMatQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMatQty.Name = "lblMatQty";
            this.lblMatQty.TabIndex = 6;
            // 
            // nudMatQty
            // 
            this.nudMatQty.DecimalPlaces = 2;
            this.nudMatQty.Location = new System.Drawing.Point(12, 175);
            this.nudMatQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudMatQty.Size = new System.Drawing.Size(170, 25);
            this.nudMatQty.Name = "nudMatQty";
            this.nudMatQty.TabIndex = 7;
            this.nudMatQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMaterial.FlatAppearance.BorderSize = 0;
            this.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 225);
            this.btnAddMaterial.Size = new System.Drawing.Size(365, 40);
            this.btnAddMaterial.Text = "Додати матеріал";
            this.btnAddMaterial.UseVisualStyleBackColor = false;
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.TabIndex = 8;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.lblStockHint);
            this.grpStock.Controls.Add(this.nudStockQty);
            this.grpStock.Controls.Add(this.btnAddStock);
            this.grpStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStock.Location = new System.Drawing.Point(790, 320);
            this.grpStock.Size = new System.Drawing.Size(390, 165);
            this.grpStock.Text = "Поповнення складу";
            this.grpStock.Name = "grpStock";
            this.grpStock.TabIndex = 2;
            // 
            // lblStockHint
            // 
            this.lblStockHint.Location = new System.Drawing.Point(12, 28);
            this.lblStockHint.Size = new System.Drawing.Size(365, 42);
            this.lblStockHint.Text = "Оберіть матеріал у таблиці та вкажіть, скільки додати:";
            this.lblStockHint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStockHint.Name = "lblStockHint";
            this.lblStockHint.TabIndex = 0;
            // 
            // nudStockQty
            // 
            this.nudStockQty.DecimalPlaces = 2;
            this.nudStockQty.Location = new System.Drawing.Point(12, 75);
            this.nudStockQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudStockQty.Size = new System.Drawing.Size(170, 25);
            this.nudStockQty.Name = "nudStockQty";
            this.nudStockQty.TabIndex = 1;
            this.nudStockQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(12, 112);
            this.btnAddStock.Size = new System.Drawing.Size(365, 38);
            this.btnAddStock.Text = "Поповнити залишок";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.TabIndex = 2;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DispatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFix — Робоче місце диспетчера";
            this.Load += new System.EventHandler(this.DispatcherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabRequests.ResumeLayout(false);
            this.tabRequests.PerformLayout();
            this.tabMaterials.ResumeLayout(false);
            this.tabMaterials.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpNewMaterial.ResumeLayout(false);
            this.grpNewMaterial.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabRequests;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblOverdueHint;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblRequestInfo;
        private System.Windows.Forms.Label lblPhotoBefore;
        private System.Windows.Forms.PictureBox picBefore;
        private System.Windows.Forms.Label lblPhotoAfter;
        private System.Windows.Forms.PictureBox picAfter;
        private System.Windows.Forms.Label lblDeadlineTitle;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label lblBrigadeAssign;
        private System.Windows.Forms.ComboBox cmbBrigades;
        private System.Windows.Forms.Button btnAssignBrigade;
        private System.Windows.Forms.Label lblZoomHint;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.GroupBox grpNewMaterial;
        private System.Windows.Forms.Label lblMatName;
        private System.Windows.Forms.TextBox txtMatName;
        private System.Windows.Forms.Label lblMatUnit;
        private System.Windows.Forms.TextBox txtMatUnit;
        private System.Windows.Forms.Label lblMatPrice;
        private System.Windows.Forms.NumericUpDown nudMatPrice;
        private System.Windows.Forms.Label lblMatQty;
        private System.Windows.Forms.NumericUpDown nudMatQty;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Label lblStockHint;
        private System.Windows.Forms.NumericUpDown nudStockQty;
        private System.Windows.Forms.Button btnAddStock;
    }
}
