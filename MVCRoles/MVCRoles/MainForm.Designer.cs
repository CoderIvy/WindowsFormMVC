namespace MVCRoles
{
    partial class MainForm
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
            this.btnMakeController = new System.Windows.Forms.Button();
            this.btnMakeModel = new System.Windows.Forms.Button();
            this.btnMakeViews = new System.Windows.Forms.Button();
            this.btnShowViews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeController
            // 
            this.btnMakeController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeController.Location = new System.Drawing.Point(35, 25);
            this.btnMakeController.Name = "btnMakeController";
            this.btnMakeController.Size = new System.Drawing.Size(139, 32);
            this.btnMakeController.TabIndex = 0;
            this.btnMakeController.Text = "Make Controller";
            this.btnMakeController.UseVisualStyleBackColor = true;
            this.btnMakeController.Click += new System.EventHandler(this.btnMakeController_Click);
            // 
            // btnMakeModel
            // 
            this.btnMakeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeModel.Location = new System.Drawing.Point(35, 86);
            this.btnMakeModel.Name = "btnMakeModel";
            this.btnMakeModel.Size = new System.Drawing.Size(139, 32);
            this.btnMakeModel.TabIndex = 1;
            this.btnMakeModel.Text = "Make Model";
            this.btnMakeModel.UseVisualStyleBackColor = true;
            this.btnMakeModel.Click += new System.EventHandler(this.btnMakeModel_Click);
            // 
            // btnMakeViews
            // 
            this.btnMakeViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeViews.Location = new System.Drawing.Point(35, 146);
            this.btnMakeViews.Name = "btnMakeViews";
            this.btnMakeViews.Size = new System.Drawing.Size(139, 32);
            this.btnMakeViews.TabIndex = 2;
            this.btnMakeViews.Text = "Make ViewsS";
            this.btnMakeViews.UseVisualStyleBackColor = true;
            this.btnMakeViews.Click += new System.EventHandler(this.btnMakeViews_Click);
            // 
            // btnShowViews
            // 
            this.btnShowViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowViews.Location = new System.Drawing.Point(35, 213);
            this.btnShowViews.Name = "btnShowViews";
            this.btnShowViews.Size = new System.Drawing.Size(139, 32);
            this.btnShowViews.TabIndex = 3;
            this.btnShowViews.Text = "Show Views";
            this.btnShowViews.UseVisualStyleBackColor = true;
            this.btnShowViews.Click += new System.EventHandler(this.btnShowViews_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 276);
            this.Controls.Add(this.btnShowViews);
            this.Controls.Add(this.btnMakeViews);
            this.Controls.Add(this.btnMakeModel);
            this.Controls.Add(this.btnMakeController);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeController;
        private System.Windows.Forms.Button btnMakeModel;
        private System.Windows.Forms.Button btnMakeViews;
        private System.Windows.Forms.Button btnShowViews;
    }
}

