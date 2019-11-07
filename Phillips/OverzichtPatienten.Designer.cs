namespace Phillips
{
    partial class OverzichtPatienten
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patientid,
            this.Naam,
            this.Doctor,
            this.email,
            this.phonenumber});
            this.dataGridView1.Location = new System.Drawing.Point(57, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Patientid
            // 
            this.Patientid.HeaderText = "PatientID";
            this.Patientid.MinimumWidth = 8;
            this.Patientid.Name = "Patientid";
            this.Patientid.Width = 150;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 8;
            this.Naam.Name = "Naam";
            this.Naam.Width = 150;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Dokter";
            this.Doctor.MinimumWidth = 8;
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Tel. nr.";
            this.phonenumber.MinimumWidth = 8;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Width = 150;
            // 
            // OverzichtPatienten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "OverzichtPatienten";
            this.Size = new System.Drawing.Size(905, 280);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
    }
}
