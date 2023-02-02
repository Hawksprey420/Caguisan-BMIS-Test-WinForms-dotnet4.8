namespace BMIS_Test_WinForms_dotnet4._8
{
    partial class Maintenance_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroTabPage metroTab_OfficialsStaff;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Residency = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Indigency = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BrgyBusinessPermit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrgyFranchise = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_BrgyDocuments = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Purok = new System.Windows.Forms.TabPage();
            this.bttn_AddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttn_Delete1 = new System.Windows.Forms.DataGridViewImageColumn();
            metroTab_OfficialsStaff = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            metroTab_OfficialsStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.bttn_AddNew);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1066, 50);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(881, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage your barangay hall users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metroPanel2.Controls.Add(this.dataGridView1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1058, 594);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // btn_Residency
            // 
            this.btn_Residency.Location = new System.Drawing.Point(0, 0);
            this.btn_Residency.Name = "btn_Residency";
            this.btn_Residency.Size = new System.Drawing.Size(75, 23);
            this.btn_Residency.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // btn_Indigency
            // 
            this.btn_Indigency.Location = new System.Drawing.Point(0, 0);
            this.btn_Indigency.Name = "btn_Indigency";
            this.btn_Indigency.Size = new System.Drawing.Size(75, 23);
            this.btn_Indigency.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // btn_BrgyBusinessPermit
            // 
            this.btn_BrgyBusinessPermit.Location = new System.Drawing.Point(0, 0);
            this.btn_BrgyBusinessPermit.Name = "btn_BrgyBusinessPermit";
            this.btn_BrgyBusinessPermit.Size = new System.Drawing.Size(75, 23);
            this.btn_BrgyBusinessPermit.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // btn_BrgyFranchise
            // 
            this.btn_BrgyFranchise.Location = new System.Drawing.Point(0, 0);
            this.btn_BrgyFranchise.Name = "btn_BrgyFranchise";
            this.btn_BrgyFranchise.Size = new System.Drawing.Size(75, 23);
            this.btn_BrgyFranchise.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // btn_BrgyDocuments
            // 
            this.btn_BrgyDocuments.Location = new System.Drawing.Point(0, 0);
            this.btn_BrgyDocuments.Name = "btn_BrgyDocuments";
            this.btn_BrgyDocuments.Size = new System.Drawing.Size(75, 23);
            this.btn_BrgyDocuments.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(metroTab_OfficialsStaff);
            this.metroTabControl1.Controls.Add(this.tabPage_Purok);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 50);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1066, 639);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTab_OfficialsStaff
            // 
            metroTab_OfficialsStaff.Controls.Add(this.metroPanel2);
            metroTab_OfficialsStaff.HorizontalScrollbarBarColor = true;
            metroTab_OfficialsStaff.HorizontalScrollbarHighlightOnWheel = false;
            metroTab_OfficialsStaff.HorizontalScrollbarSize = 10;
            metroTab_OfficialsStaff.Location = new System.Drawing.Point(4, 41);
            metroTab_OfficialsStaff.Name = "metroTab_OfficialsStaff";
            metroTab_OfficialsStaff.Size = new System.Drawing.Size(1058, 594);
            metroTab_OfficialsStaff.TabIndex = 0;
            metroTab_OfficialsStaff.Text = "Barangay Staff and Officials";
            metroTab_OfficialsStaff.VerticalScrollbarBarColor = true;
            metroTab_OfficialsStaff.VerticalScrollbarHighlightOnWheel = false;
            metroTab_OfficialsStaff.VerticalScrollbarSize = 10;
            // 
            // tabPage_Purok
            // 
            this.tabPage_Purok.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage_Purok.Location = new System.Drawing.Point(4, 41);
            this.tabPage_Purok.Name = "tabPage_Purok";
            this.tabPage_Purok.Size = new System.Drawing.Size(1058, 594);
            this.tabPage_Purok.TabIndex = 1;
            this.tabPage_Purok.Text = "Purok";
            this.tabPage_Purok.Click += new System.EventHandler(this.tabPage_Purok_Click);
            // 
            // bttn_AddNew
            // 
            this.bttn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_AddNew.BackColor = System.Drawing.Color.Aqua;
            this.bttn_AddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttn_AddNew.FlatAppearance.BorderSize = 0;
            this.bttn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_AddNew.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_AddNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttn_AddNew.Location = new System.Drawing.Point(756, 5);
            this.bttn_AddNew.Name = "bttn_AddNew";
            this.bttn_AddNew.Size = new System.Drawing.Size(119, 39);
            this.bttn_AddNew.TabIndex = 23;
            this.bttn_AddNew.Text = "Add New ";
            this.bttn_AddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttn_AddNew.UseVisualStyleBackColor = false;
            this.bttn_AddNew.Click += new System.EventHandler(this.bttn_AddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.btn_Edit1,
            this.bttn_Delete1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 594);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "CHAIRMANSHIP";
            this.Column3.Name = "Column3";
            this.Column3.Width = 177;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "POSITION";
            this.Column4.Name = "Column4";
            this.Column4.Width = 122;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "TERM START";
            this.Column5.Name = "Column5";
            this.Column5.Width = 144;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "TERM END";
            this.Column6.Name = "Column6";
            this.Column6.Width = 129;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "STATUS";
            this.Column7.Name = "Column7";
            this.Column7.Width = 101;
            // 
            // btn_Edit1
            // 
            this.btn_Edit1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_Edit1.HeaderText = "";
            this.btn_Edit1.Name = "btn_Edit1";
            this.btn_Edit1.Width = 5;
            // 
            // bttn_Delete1
            // 
            this.bttn_Delete1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bttn_Delete1.HeaderText = "";
            this.bttn_Delete1.Name = "bttn_Delete1";
            this.bttn_Delete1.Width = 5;
            // 
            // Maintenance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 689);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance_Form";
            this.Text = "Form2";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            metroTab_OfficialsStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Residency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Indigency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BrgyBusinessPermit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BrgyFranchise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_BrgyDocuments;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage_Purok;
        private System.Windows.Forms.Button bttn_AddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn btn_Edit1;
        private System.Windows.Forms.DataGridViewImageColumn bttn_Delete1;
    }
}