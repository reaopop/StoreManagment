
namespace StoreManagement.View
{
    partial class frm_AccessUsers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_UserName = new System.Windows.Forms.ToolStripTextBox();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_AddProducts = new System.Windows.Forms.CheckBox();
            this.chk_deleteProducts = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk_SellProducts = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.txt_UserName,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(65, 31);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(300, 31);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(58, 31);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // chk_AddProducts
            // 
            this.chk_AddProducts.AutoSize = true;
            this.chk_AddProducts.Location = new System.Drawing.Point(65, 64);
            this.chk_AddProducts.Name = "chk_AddProducts";
            this.chk_AddProducts.Size = new System.Drawing.Size(131, 24);
            this.chk_AddProducts.TabIndex = 2;
            this.chk_AddProducts.Text = "Add Products";
            this.chk_AddProducts.UseVisualStyleBackColor = true;
            // 
            // chk_deleteProducts
            // 
            this.chk_deleteProducts.AutoSize = true;
            this.chk_deleteProducts.Location = new System.Drawing.Point(65, 129);
            this.chk_deleteProducts.Name = "chk_deleteProducts";
            this.chk_deleteProducts.Size = new System.Drawing.Size(149, 24);
            this.chk_deleteProducts.TabIndex = 3;
            this.chk_deleteProducts.Text = "Delete Products";
            this.chk_deleteProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(524, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(390, 544);
            this.dataGridView1.TabIndex = 4;
            // 
            // chk_SellProducts
            // 
            this.chk_SellProducts.AutoSize = true;
            this.chk_SellProducts.Location = new System.Drawing.Point(65, 185);
            this.chk_SellProducts.Name = "chk_SellProducts";
            this.chk_SellProducts.Size = new System.Drawing.Size(128, 24);
            this.chk_SellProducts.TabIndex = 5;
            this.chk_SellProducts.TabStop = false;
            this.chk_SellProducts.Text = "Sell Products";
            this.chk_SellProducts.UseVisualStyleBackColor = true;
            // 
            // frm_AccessUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 592);
            this.Controls.Add(this.chk_SellProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk_deleteProducts);
            this.Controls.Add(this.chk_AddProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_AccessUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AccessUsers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_AddProducts;
        private System.Windows.Forms.CheckBox chk_deleteProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripTextBox txt_UserName;
        private System.Windows.Forms.CheckBox chk_SellProducts;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}