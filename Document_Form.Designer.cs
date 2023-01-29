namespace BMIS_Test_WinForms_dotnet4._8
{
    partial class Document_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_BarangayName = new System.Windows.Forms.Label();
            this.btn_Documents = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btn_Documents);
            this.panel1.Controls.Add(this.label_BarangayName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 60);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_BarangayName
            // 
            this.label_BarangayName.AutoSize = true;
            this.label_BarangayName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BarangayName.Location = new System.Drawing.Point(12, 9);
            this.label_BarangayName.Name = "label_BarangayName";
            this.label_BarangayName.Size = new System.Drawing.Size(293, 43);
            this.label_BarangayName.TabIndex = 2;
            this.label_BarangayName.Text = "Barangay Caguisan";
            // 
            // btn_Documents
            // 
            this.btn_Documents.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Documents.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Documents.FlatAppearance.BorderSize = 0;
            this.btn_Documents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Documents.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Documents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Documents.Location = new System.Drawing.Point(1053, 0);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(343, 60);
            this.btn_Documents.TabIndex = 15;
            this.btn_Documents.Text = "Documents";
            this.btn_Documents.UseVisualStyleBackColor = false;
            // 
            // Document_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 901);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Document_Form";
            this.Text = "Document_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_BarangayName;
        private System.Windows.Forms.Button btn_Documents;
    }
}