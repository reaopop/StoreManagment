
namespace StoreManagement.View
{
    partial class frm_AddProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_BuyPrice = new System.Windows.Forms.TextBox();
            this.txt_SellPrice = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.cmb_Unite = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sell Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buy Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(142, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(125, 35);
            this.txt_ID.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(142, 136);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(125, 35);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_BuyPrice
            // 
            this.txt_BuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuyPrice.Location = new System.Drawing.Point(142, 189);
            this.txt_BuyPrice.Name = "txt_BuyPrice";
            this.txt_BuyPrice.Size = new System.Drawing.Size(125, 35);
            this.txt_BuyPrice.TabIndex = 9;
            // 
            // txt_SellPrice
            // 
            this.txt_SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SellPrice.Location = new System.Drawing.Point(142, 237);
            this.txt_SellPrice.Name = "txt_SellPrice";
            this.txt_SellPrice.Size = new System.Drawing.Size(125, 35);
            this.txt_SellPrice.TabIndex = 10;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(142, 288);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(125, 35);
            this.txt_Quantity.TabIndex = 11;
            // 
            // cmb_Unite
            // 
            this.cmb_Unite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unite.FormattingEnabled = true;
            this.cmb_Unite.Location = new System.Drawing.Point(142, 334);
            this.cmb_Unite.Name = "cmb_Unite";
            this.cmb_Unite.Size = new System.Drawing.Size(125, 37);
            this.cmb_Unite.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(889, 286);
            this.dataGridView1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 33);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.newToolStripMenuItem.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // frm_AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 472);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_Unite);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_SellPrice);
            this.Controls.Add(this.txt_BuyPrice);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AddProducts";
            this.Load += new System.EventHandler(this.frm_AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_BuyPrice;
        private System.Windows.Forms.TextBox txt_SellPrice;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.ComboBox cmb_Unite;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}