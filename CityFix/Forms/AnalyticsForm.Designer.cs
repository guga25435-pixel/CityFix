namespace CityFix.Forms
{
    partial class AnalyticsForm
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
            this.tabAnalytics = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.tabDistricts = new System.Windows.Forms.TabPage();
            this.tabMaterialCosts = new System.Windows.Forms.TabPage();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCompletedTitle = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblInWorkTitle = new System.Windows.Forms.Label();
            this.lblInWork = new System.Windows.Forms.Label();
            this.lblOverdueTitle = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.progressCompleted = new System.Windows.Forms.ProgressBar();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.dgvDistricts = new System.Windows.Forms.DataGridView();
            this.dgvMaterialCosts = new System.Windows.Forms.DataGridView();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            this.tabAnalytics.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabDistricts.SuspendLayout();
            this.tabMaterialCosts.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Text = "Аналітика міських заявок";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.tabSummary);
            this.tabAnalytics.Controls.Add(this.tabDistricts);
            this.tabAnalytics.Controls.Add(this.tabMaterialCosts);
            this.tabAnalytics.Location = new System.Drawing.Point(15, 50);
            this.tabAnalytics.SelectedIndex = 0;
            this.tabAnalytics.Size = new System.Drawing.Size(970, 520);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.TabIndex = 1;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.grpSummary);
            this.tabSummary.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.tabSummary.Location = new System.Drawing.Point(4, 29);
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(962, 487);
            this.tabSummary.Text = "Загальна статистика";
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.TabIndex = 0;
            // 
            // tabDistricts
            // 
            this.tabDistricts.Controls.Add(this.dgvDistricts);
            this.tabDistricts.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.tabDistricts.Location = new System.Drawing.Point(4, 29);
            this.tabDistricts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistricts.Size = new System.Drawing.Size(962, 487);
            this.tabDistricts.Text = "Заявки за районами";
            this.tabDistricts.Name = "tabDistricts";
            this.tabDistricts.TabIndex = 1;
            // 
            // tabMaterialCosts
            // 
            this.tabMaterialCosts.Controls.Add(this.dgvMaterialCosts);
            this.tabMaterialCosts.Controls.Add(this.lblTotalCost);
            this.tabMaterialCosts.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.tabMaterialCosts.Location = new System.Drawing.Point(4, 29);
            this.tabMaterialCosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterialCosts.Size = new System.Drawing.Size(962, 487);
            this.tabMaterialCosts.Text = "Витрати матеріалів";
            this.tabMaterialCosts.Name = "tabMaterialCosts";
            this.tabMaterialCosts.TabIndex = 2;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblTotalTitle);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblCompletedTitle);
            this.grpSummary.Controls.Add(this.lblCompleted);
            this.grpSummary.Controls.Add(this.lblInWorkTitle);
            this.grpSummary.Controls.Add(this.lblInWork);
            this.grpSummary.Controls.Add(this.lblOverdueTitle);
            this.grpSummary.Controls.Add(this.lblOverdue);
            this.grpSummary.Controls.Add(this.lblProgressTitle);
            this.grpSummary.Controls.Add(this.progressCompleted);
            this.grpSummary.Controls.Add(this.lblProgressPercent);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSummary.Location = new System.Drawing.Point(20, 20);
            this.grpSummary.Size = new System.Drawing.Size(920, 310);
            this.grpSummary.Text = "Основні показники";
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Location = new System.Drawing.Point(25, 40);
            this.lblTotalTitle.Text = "Усього заявок:";
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(300, 40);
            this.lblTotal.Text = "0";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 1;
            // 
            // lblCompletedTitle
            // 
            this.lblCompletedTitle.AutoSize = true;
            this.lblCompletedTitle.Location = new System.Drawing.Point(25, 80);
            this.lblCompletedTitle.Text = "Виконано:";
            this.lblCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCompletedTitle.Name = "lblCompletedTitle";
            this.lblCompletedTitle.TabIndex = 2;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(300, 80);
            this.lblCompleted.Text = "0";
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.TabIndex = 3;
            // 
            // lblInWorkTitle
            // 
            this.lblInWorkTitle.AutoSize = true;
            this.lblInWorkTitle.Location = new System.Drawing.Point(25, 120);
            this.lblInWorkTitle.Text = "У роботі:";
            this.lblInWorkTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInWorkTitle.Name = "lblInWorkTitle";
            this.lblInWorkTitle.TabIndex = 4;
            // 
            // lblInWork
            // 
            this.lblInWork.AutoSize = true;
            this.lblInWork.Location = new System.Drawing.Point(300, 120);
            this.lblInWork.Text = "0";
            this.lblInWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInWork.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblInWork.Name = "lblInWork";
            this.lblInWork.TabIndex = 5;
            // 
            // lblOverdueTitle
            // 
            this.lblOverdueTitle.AutoSize = true;
            this.lblOverdueTitle.Location = new System.Drawing.Point(25, 160);
            this.lblOverdueTitle.Text = "Прострочено:";
            this.lblOverdueTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOverdueTitle.Name = "lblOverdueTitle";
            this.lblOverdueTitle.TabIndex = 6;
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Location = new System.Drawing.Point(300, 160);
            this.lblOverdue.Text = "0";
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOverdue.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.TabIndex = 7;
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Location = new System.Drawing.Point(25, 210);
            this.lblProgressTitle.Text = "Частка виконаних заявок:";
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.TabIndex = 8;
            // 
            // progressCompleted
            // 
            this.progressCompleted.Location = new System.Drawing.Point(25, 245);
            this.progressCompleted.Size = new System.Drawing.Size(600, 28);
            this.progressCompleted.Name = "progressCompleted";
            this.progressCompleted.TabIndex = 9;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Location = new System.Drawing.Point(640, 248);
            this.lblProgressPercent.Text = "0%";
            this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.TabIndex = 10;
            // 
            // dgvDistricts
            // 
            this.dgvDistricts.AllowUserToAddRows = false;
            this.dgvDistricts.AllowUserToDeleteRows = false;
            this.dgvDistricts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistricts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDistricts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistricts.Location = new System.Drawing.Point(15, 15);
            this.dgvDistricts.MultiSelect = false;
            this.dgvDistricts.ReadOnly = true;
            this.dgvDistricts.RowHeadersVisible = false;
            this.dgvDistricts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistricts.Size = new System.Drawing.Size(930, 455);
            this.dgvDistricts.Name = "dgvDistricts";
            this.dgvDistricts.TabIndex = 0;
            // 
            // dgvMaterialCosts
            // 
            this.dgvMaterialCosts.AllowUserToAddRows = false;
            this.dgvMaterialCosts.AllowUserToDeleteRows = false;
            this.dgvMaterialCosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialCosts.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterialCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialCosts.Location = new System.Drawing.Point(15, 15);
            this.dgvMaterialCosts.MultiSelect = false;
            this.dgvMaterialCosts.ReadOnly = true;
            this.dgvMaterialCosts.RowHeadersVisible = false;
            this.dgvMaterialCosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialCosts.Size = new System.Drawing.Size(930, 420);
            this.dgvMaterialCosts.Name = "dgvMaterialCosts";
            this.dgvMaterialCosts.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(15, 448);
            this.lblTotalCost.Text = "Загальна вартість матеріалів: 0 грн";
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(220, 232, 248);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnRefresh.Location = new System.Drawing.Point(15, 585);
            this.btnRefresh.Size = new System.Drawing.Size(180, 42);
            this.btnRefresh.Text = "Оновити дані";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(765, 585);
            this.btnExport.Size = new System.Drawing.Size(220, 42);
            this.btnExport.Text = "Експортувати в Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Name = "btnExport";
            this.btnExport.TabIndex = 3;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialogExcel
            // 
            this.saveFileDialogExcel.Filter = "Файли Excel|*.xlsx";
            this.saveFileDialogExcel.Title = "Збереження звіту";
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 251);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabAnalytics);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityFix — Аналітика";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialCosts)).EndInit();
            this.tabAnalytics.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.tabDistricts.ResumeLayout(false);
            this.tabDistricts.PerformLayout();
            this.tabMaterialCosts.ResumeLayout(false);
            this.tabMaterialCosts.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabAnalytics;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabDistricts;
        private System.Windows.Forms.TabPage tabMaterialCosts;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblInWorkTitle;
        private System.Windows.Forms.Label lblInWork;
        private System.Windows.Forms.Label lblOverdueTitle;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.ProgressBar progressCompleted;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.DataGridView dgvDistricts;
        private System.Windows.Forms.DataGridView dgvMaterialCosts;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}
