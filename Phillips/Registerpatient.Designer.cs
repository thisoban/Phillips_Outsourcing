namespace Phillips
{
    partial class Registerpatient
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
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Location = new System.Drawing.Point(48, 49);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(677, 342);
            this.RegisterPanel.TabIndex = 0;
            // 
            // Registerpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterPanel);
            this.Name = "Registerpatient";
            this.Text = "Registerpatient";
            this.Load += new System.EventHandler(this.Registerpatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
    }
}