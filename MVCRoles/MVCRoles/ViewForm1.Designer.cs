namespace MVCRoles
{
    partial class ViewForm1
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
            this.components = new System.ComponentModel.Container();
            this.lstboxShowArea = new System.Windows.Forms.ListBox();
            this.radiobtnCustomer = new System.Windows.Forms.RadioButton();
            this.radioBtnWaiter = new System.Windows.Forms.RadioButton();
            this.radioBtnChef = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.cboWaiter = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniqueBehaviourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serveFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxShowArea
            // 
            this.lstboxShowArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxShowArea.FormattingEnabled = true;
            this.lstboxShowArea.ItemHeight = 16;
            this.lstboxShowArea.Location = new System.Drawing.Point(12, 12);
            this.lstboxShowArea.Name = "lstboxShowArea";
            this.lstboxShowArea.Size = new System.Drawing.Size(437, 356);
            this.lstboxShowArea.TabIndex = 0;

            this.lstboxShowArea.SelectedIndexChanged += new System.EventHandler(this.lstboxShowArea_SelectedIndexChanged);
            // 
            // radiobtnCustomer
            // 
            this.radiobtnCustomer.AutoSize = true;
            this.radiobtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnCustomer.Location = new System.Drawing.Point(12, 379);
            this.radiobtnCustomer.Name = "radiobtnCustomer";
            this.radiobtnCustomer.Size = new System.Drawing.Size(83, 20);
            this.radiobtnCustomer.TabIndex = 1;
            this.radiobtnCustomer.TabStop = true;
            this.radiobtnCustomer.Text = "Customer";
            this.radiobtnCustomer.UseVisualStyleBackColor = true;
            this.radiobtnCustomer.Click += new System.EventHandler(this.radiobtnCustomer_Click);
            // 
            // radioBtnWaiter
            // 
            this.radioBtnWaiter.AutoSize = true;
            this.radioBtnWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnWaiter.Location = new System.Drawing.Point(12, 410);
            this.radioBtnWaiter.Name = "radioBtnWaiter";
            this.radioBtnWaiter.Size = new System.Drawing.Size(65, 20);
            this.radioBtnWaiter.TabIndex = 2;
            this.radioBtnWaiter.TabStop = true;
            this.radioBtnWaiter.Text = "Waiter";
            this.radioBtnWaiter.UseVisualStyleBackColor = true;
            this.radioBtnWaiter.Click += new System.EventHandler(this.radioBtnWaiter_Click);
            // 
            // radioBtnChef
            // 
            this.radioBtnChef.AutoSize = true;
            this.radioBtnChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnChef.Location = new System.Drawing.Point(12, 442);
            this.radioBtnChef.Name = "radioBtnChef";
            this.radioBtnChef.Size = new System.Drawing.Size(53, 20);
            this.radioBtnChef.TabIndex = 3;
            this.radioBtnChef.TabStop = true;
            this.radioBtnChef.Text = "Chef";
            this.radioBtnChef.UseVisualStyleBackColor = true;
            this.radioBtnChef.Click += new System.EventHandler(this.radioBtnChef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position:";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(239, 406);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(60, 22);
            this.txtX.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "X:";
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(239, 436);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(60, 22);
            this.txtY.TabIndex = 8;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(101, 379);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(75, 21);
            this.cboCustomer.TabIndex = 9;
            // 
            // cboChef
            // 
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(101, 440);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(75, 21);
            this.cboChef.TabIndex = 10;
            // 
            // cboWaiter
            // 
            this.cboWaiter.FormattingEnabled = true;
            this.cboWaiter.Location = new System.Drawing.Point(101, 408);
            this.cboWaiter.Name = "cboWaiter";
            this.cboWaiter.Size = new System.Drawing.Size(75, 21);
            this.cboWaiter.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(330, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Role";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(330, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Role";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.uniqueBehaviourToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteItemToolStripMenuItem.Text = "DeleteItem";
            // 
            // uniqueBehaviourToolStripMenuItem
            // 
            this.uniqueBehaviourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderFoodToolStripMenuItem,
            this.cookFoodToolStripMenuItem,
            this.serveFoodToolStripMenuItem});
            this.uniqueBehaviourToolStripMenuItem.Name = "uniqueBehaviourToolStripMenuItem";
            this.uniqueBehaviourToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uniqueBehaviourToolStripMenuItem.Text = "UniqueBehaviour";
            // 
            // orderFoodToolStripMenuItem
            // 
            this.orderFoodToolStripMenuItem.Name = "orderFoodToolStripMenuItem";
            this.orderFoodToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.orderFoodToolStripMenuItem.Text = "OrderFood";
            // 
            // cookFoodToolStripMenuItem
            // 
            this.cookFoodToolStripMenuItem.Name = "cookFoodToolStripMenuItem";
            this.cookFoodToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cookFoodToolStripMenuItem.Text = "CookFood";
            // 
            // serveFoodToolStripMenuItem
            // 
            this.serveFoodToolStripMenuItem.Name = "serveFoodToolStripMenuItem";
            this.serveFoodToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.serveFoodToolStripMenuItem.Text = "ServeFood";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(330, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Role";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 480);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboWaiter);
            this.Controls.Add(this.cboChef);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnChef);
            this.Controls.Add(this.radioBtnWaiter);
            this.Controls.Add(this.radiobtnCustomer);
            this.Controls.Add(this.lstboxShowArea);
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxShowArea;
        private System.Windows.Forms.RadioButton radiobtnCustomer;
        private System.Windows.Forms.RadioButton radioBtnWaiter;
        private System.Windows.Forms.RadioButton radioBtnChef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.ComboBox cboWaiter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniqueBehaviourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serveFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
    }
}