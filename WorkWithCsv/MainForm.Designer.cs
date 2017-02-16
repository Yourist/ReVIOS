namespace ReVIOS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridOfMax = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.progressBarDL = new System.Windows.Forms.ProgressBar();
            this.customWaveViewer1 = new ReVIOS.CustomWaveViewer();
            this.customWaveViewer2 = new ReVIOS.CustomWaveViewer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfMax)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView.DataSource = this.fieldsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(3, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(283, 544);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // descBox
            // 
            this.descBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fieldsBindingSource, "Description", true));
            this.descBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descBox.Location = new System.Drawing.Point(3, 599);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(283, 190);
            this.descBox.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.descBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 794);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(293, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(919, 794);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.customWaveViewer1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(916, 573);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.customWaveViewer2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 582);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(916, 207);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.dataGridOfMax);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1218, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(258, 692);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // dataGridOfMax
            // 
            this.dataGridOfMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOfMax.Location = new System.Drawing.Point(3, 3);
            this.dataGridOfMax.Name = "dataGridOfMax";
            this.dataGridOfMax.RowTemplate.Height = 24;
            this.dataGridOfMax.Size = new System.Drawing.Size(255, 689);
            this.dataGridOfMax.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.progressBarDL);
            this.flowLayoutPanel6.Controls.Add(this.btnCreateReport);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(1218, 701);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(258, 81);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(3, 32);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(121, 47);
            this.btnCreateReport.TabIndex = 0;
            this.btnCreateReport.Text = "CreateReport";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // progressBarDL
            // 
            this.progressBarDL.Location = new System.Drawing.Point(3, 3);
            this.progressBarDL.Name = "progressBarDL";
            this.progressBarDL.Size = new System.Drawing.Size(255, 23);
            this.progressBarDL.TabIndex = 1;
            // 
            // customWaveViewer1
            // 
            this.customWaveViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customWaveViewer1.Location = new System.Drawing.Point(3, 3);
            this.customWaveViewer1.Name = "customWaveViewer1";
            this.customWaveViewer1.PenColor = System.Drawing.Color.DodgerBlue;
            this.customWaveViewer1.PenWidth = 1F;
            this.customWaveViewer1.SamplesPerPixel = 128;
            this.customWaveViewer1.Size = new System.Drawing.Size(890, 570);
            this.customWaveViewer1.StartPosition = ((long)(0));
            this.customWaveViewer1.TabIndex = 0;
            this.customWaveViewer1.WaveStream = null;
            // 
            // customWaveViewer2
            // 
            this.customWaveViewer2.Location = new System.Drawing.Point(3, 3);
            this.customWaveViewer2.Name = "customWaveViewer2";
            this.customWaveViewer2.PenColor = System.Drawing.Color.CadetBlue;
            this.customWaveViewer2.PenWidth = 1F;
            this.customWaveViewer2.SamplesPerPixel = 128;
            this.customWaveViewer2.Size = new System.Drawing.Size(913, 204);
            this.customWaveViewer2.StartPosition = ((long)(0));
            this.customWaveViewer2.TabIndex = 0;
            this.customWaveViewer2.WaveStream = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fieldsBindingSource
            // 
            this.fieldsBindingSource.DataSource = typeof(ReVIOS.Fields);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1476, 794);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReVIOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfMax)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.BindingSource fieldsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private CustomWaveViewer customWaveViewer1;
        private CustomWaveViewer customWaveViewer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridOfMax;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.ProgressBar progressBarDL;
    }
}

