namespace CityFix.Forms
{
    partial class RequestForm
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
            this.grpResident = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.treeCategories = new System.Windows.Forms.TreeView();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.lblSla = new System.Windows.Forms.Label();
            this.grpPhoto = new System.Windows.Forms.GroupBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblPhotoHint = new System.Windows.Forms.Label();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.lblCreated = new System.Windows.Forms.Label();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.grpResident.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResident
            // 
            this.grpResident.Controls.Add(this.lblName);
            this.grpResident.Controls.Add(this.txtName);
            this.grpResident.Controls.Add(this.lblPhone);
            this.grpResident.Controls.Add(this.txtPhone);
            this.grpResident.Controls.Add(this.lblDistrict);
            this.grpResident.Controls.Add(this.cmbDistrict);
            this.grpResident.Controls.Add(this.lblAddress);
            this.grpResident.Controls.Add(this.txtAddress);
            this.grpResident.Controls.Add(this.lblDescription);
            this.grpResident.Controls.Add(this.txtDescription);
            this.grpResident.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResident.Location = new System.Drawing.Point(20, 20);
            this.grpResident.Size = new System.Drawing.Size(330, 480);
            this.grpResident.Text = "Дані заявника та адреса";
            this.grpResident.Name = "grpResident";
            this.grpResident.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Text = "Ваше ім'я та прізвище:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 55);
            this.txtName.Size = new System.Drawing.Size(300, 25);
            this.txtName.Name = "txtName";
            this.txtName.TabIndex = 1;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 90);
            this.lblPhone.Text = "Телефон (необов'язково):";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 115);
            this.txtPhone.Size = new System.Drawing.Size(300, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(15, 150);
            this.lblDistrict.Text = "Район міста:";
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.TabIndex = 4;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(15, 175);
            this.cmbDistrict.Size = new System.Drawing.Size(300, 25);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.TabIndex = 5;
            this.cmbDistrict.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 210);
            this.lblAddress.Text = "Адреса проблеми:";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 235);
            this.txtAddress.Size = new System.Drawing.Size(300, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 270);
            this.lblDescription.Text = "Опис проблеми:";
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 295);
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(300, 165);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.treeCategories);
            this.grpCategory.Controls.Add(this.lblSelectedCategory);
            this.grpCategory.Controls.Add(this.lblSla);
            this.grpCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCategory.Location = new System.Drawing.Point(365, 20);
            this.grpCategory.Size = new System.Drawing.Size(300, 480);
            this.grpCategory.Text = "Категорія проблеми";
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.TabIndex = 1;
            // 
            // treeCategories
            // 
            this.treeCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeCategories.HideSelection = false;
            this.treeCategories.Location = new System.Drawing.Point(15, 30);
            this.treeCategories.PathSeparator = " → ";
            this.treeCategories.Size = new System.Drawing.Size(270, 340);
            this.treeCategories.Name = "treeCategories";
            this.treeCategories.TabIndex = 0;
            this.treeCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCategories_AfterSelect);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.Location = new System.Drawing.Point(15, 380);
            this.lblSelectedCategory.Size = new System.Drawing.Size(270, 45);
            this.lblSelectedCategory.Text = "Категорію не обрано";
            this.lblSelectedCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.TabIndex = 1;
            // 
            // lblSla
            // 
            this.lblSla.Location = new System.Drawing.Point(15, 430);
            this.lblSla.Size = new System.Drawing.Size(270, 40);
            this.lblSla.Text = "Норматив виконання: —";
            this.lblSla.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSla.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblSla.Name = "lblSla";
            this.lblSla.TabIndex = 2;
            // 
            // grpPhoto
            // 
            this.grpPhoto.Controls.Add(this.picPhoto);
            this.grpPhoto.Controls.Add(this.lblPhotoHint);
            this.grpPhoto.Controls.Add(this.btnChoosePhoto);
            this.grpPhoto.Controls.Add(this.btnClearPhoto);
            this.grpPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhoto.Location = new System.Drawing.Point(680, 20);
            this.grpPhoto.Size = new System.Drawing.Size(260, 480);
            this.grpPhoto.Text = "Фото проблеми";
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.TabIndex = 2;
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.Color.White;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto.Location = new System.Drawing.Point(15, 30);
            this.picPhoto.Size = new System.Drawing.Size(230, 230);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabStop = false;
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.TabIndex = 0;
            this.picPhoto.DoubleClick += new System.EventHandler(this.picPhoto_DoubleClick);
            // 
            // lblPhotoHint
            // 
            this.lblPhotoHint.AutoSize = true;
            this.lblPhotoHint.Location = new System.Drawing.Point(15, 265);
            this.lblPhotoHint.Text = "Подвійний клік — збільшити фото";
            this.lblPhotoHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhotoHint.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblPhotoHint.Name = "lblPhotoHint";
            this.lblPhotoHint.TabIndex = 1;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePhoto.FlatAppearance.BorderSize = 0;
            this.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChoosePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChoosePhoto.Location = new System.Drawing.Point(15, 295);
            this.btnChoosePhoto.Size = new System.Drawing.Size(230, 40);
            this.btnChoosePhoto.Text = "Вибрати фото...";
            this.btnChoosePhoto.UseVisualStyleBackColor = false;
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.TabIndex = 2;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnClearPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPhoto.FlatAppearance.BorderSize = 0;
            this.btnClearPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearPhoto.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnClearPhoto.Location = new System.Drawing.Point(15, 345);
            this.btnClearPhoto.Size = new System.Drawing.Size(230, 40);
            this.btnClearPhoto.Text = "Видалити фото";
            this.btnClearPhoto.UseVisualStyleBackColor = false;
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.TabIndex = 3;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(20, 522);
            this.lblCreated.Text = "Дата створення:";
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.TabIndex = 3;
            // 
            // dtpCreated
            // 
            this.dtpCreated.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpCreated.Enabled = false;
            this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreated.Location = new System.Drawing.Point(150, 518);
            this.dtpCreated.Size = new System.Drawing.Size(200, 25);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.TabIndex = 4;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(370, 522);
            this.lblDeadline.Text = "Кінцевий термін: —";
            this.lblDeadline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(600, 575);
            this.btnCreate.Size = new System.Drawing.Size(200, 45);
            this.btnCreate.Text = "Створити заявку";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnClose.Location = new System.Drawing.Point(815, 575);
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabIndex = 7;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.Filter = "Зображення|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialogPhoto.Title = "Оберіть фотографію проблеми";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.grpResident);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFix — Нова заявка мешканця";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.grpResident.ResumeLayout(false);
            this.grpResident.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpPhoto.ResumeLayout(false);
            this.grpPhoto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpResident;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TreeView treeCategories;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.Label lblSla;
        private System.Windows.Forms.GroupBox grpPhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblPhotoHint;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}
