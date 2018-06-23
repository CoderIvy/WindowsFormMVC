namespace MVCRoles
{
    partial class ViewForm3
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
            this.pnlShowArea = new System.Windows.Forms.Panel();
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlShowArea
            // 
            this.pnlShowArea.BackColor = System.Drawing.SystemColors.Window;
            this.pnlShowArea.Enabled = false;
            this.pnlShowArea.Location = new System.Drawing.Point(12, 45);
            this.pnlShowArea.Name = "pnlShowArea";
            this.pnlShowArea.Size = new System.Drawing.Size(425, 425);
            this.pnlShowArea.TabIndex = 1;
            // 
            // cboSelector
            // 
            this.cboSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Location = new System.Drawing.Point(12, 12);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(209, 24);
            this.cboSelector.TabIndex = 10;
            this.cboSelector.Text = "---------Select Display Item-----------";
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            // 
            // ViewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 481);
            this.Controls.Add(this.cboSelector);
            this.Controls.Add(this.pnlShowArea);
            this.Name = "ViewForm3";
            this.Text = "ViewForm3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowArea;
        private System.Windows.Forms.ComboBox cboSelector;
    }
}