
namespace StoreManagement.View
{
    partial class frm_Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Invoices));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_InvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nat = new System.Windows.Forms.TextBox();
            this.cmb_Items = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.btn_EditRowFromGrid = new System.Windows.Forms.Button();
            this.btn_DeleteFromGrid = new System.Windows.Forms.Button();
            this.btn_AddToGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_InvoiceID
            // 
            this.txt_InvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceID.Location = new System.Drawing.Point(149, 52);
            this.txt_InvoiceID.Name = "txt_InvoiceID";
            this.txt_InvoiceID.Size = new System.Drawing.Size(127, 35);
            this.txt_InvoiceID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(375, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // dt_Qty
            // 
            this.dt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Qty.Location = new System.Drawing.Point(468, 249);
            this.dt_Qty.Name = "dt_Qty";
            this.dt_Qty.Size = new System.Drawing.Size(127, 35);
            this.dt_Qty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(609, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // dt_Price
            // 
            this.dt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Price.Location = new System.Drawing.Point(671, 248);
            this.dt_Price.Name = "dt_Price";
            this.dt_Price.Size = new System.Drawing.Size(127, 35);
            this.dt_Price.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(813, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // dt_Total
            // 
            this.dt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Total.Location = new System.Drawing.Point(879, 248);
            this.dt_Total.Name = "dt_Total";
            this.dt_Total.Size = new System.Drawing.Size(127, 35);
            this.dt_Total.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(300, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Discount";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(406, 52);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(127, 35);
            this.txt_Discount.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(1019, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(982, 61);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(127, 35);
            this.txt_Total.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(1028, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nat";
            // 
            // txt_Nat
            // 
            this.txt_Nat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nat.Location = new System.Drawing.Point(982, 127);
            this.txt_Nat.Name = "txt_Nat";
            this.txt_Nat.Size = new System.Drawing.Size(127, 35);
            this.txt_Nat.TabIndex = 15;
            // 
            // cmb_Items
            // 
            this.cmb_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Items.FormattingEnabled = true;
            this.cmb_Items.Location = new System.Drawing.Point(80, 249);
            this.cmb_Items.Name = "cmb_Items";
            this.cmb_Items.Size = new System.Drawing.Size(278, 37);
            this.cmb_Items.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.printToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1408, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::StoreManagement.Properties.Resources.icons8_save_32px;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::StoreManagement.Properties.Resources.icons8_delete_folder_32px;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // dt_Date
            // 
            this.dt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Date.Location = new System.Drawing.Point(693, 59);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(181, 28);
            this.dt_Date.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(609, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Date";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.BackColor = System.Drawing.Color.Crimson;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.White;
            this.Balance.Location = new System.Drawing.Point(1119, 223);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(82, 22);
            this.Balance.TabIndex = 23;
            this.Balance.Text = "Balance";
            // 
            // txt_Balance
            // 
            this.txt_Balance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Balance.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Balance.Location = new System.Drawing.Point(1112, 248);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(97, 39);
            this.txt_Balance.TabIndex = 22;
            this.txt_Balance.Text = "0";
            this.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_EditRowFromGrid
            // 
            this.btn_EditRowFromGrid.Image = global::StoreManagement.Properties.Resources.icons8_edit_property_32px_1;
            this.btn_EditRowFromGrid.Location = new System.Drawing.Point(1302, 359);
            this.btn_EditRowFromGrid.Name = "btn_EditRowFromGrid";
            this.btn_EditRowFromGrid.Size = new System.Drawing.Size(54, 59);
            this.btn_EditRowFromGrid.TabIndex = 25;
            this.btn_EditRowFromGrid.UseVisualStyleBackColor = true;
            this.btn_EditRowFromGrid.Click += new System.EventHandler(this.btn_EditRowFromGrid_Click);
            // 
            // btn_DeleteFromGrid
            // 
            this.btn_DeleteFromGrid.Image = global::StoreManagement.Properties.Resources.icons8_add_100px;
            this.btn_DeleteFromGrid.Location = new System.Drawing.Point(1302, 298);
            this.btn_DeleteFromGrid.Name = "btn_DeleteFromGrid";
            this.btn_DeleteFromGrid.Size = new System.Drawing.Size(54, 59);
            this.btn_DeleteFromGrid.TabIndex = 24;
            this.btn_DeleteFromGrid.UseVisualStyleBackColor = true;
            this.btn_DeleteFromGrid.Click += new System.EventHandler(this.btn_DeleteFromGrid_Click);
            // 
            // btn_AddToGrid
            // 
            this.btn_AddToGrid.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddToGrid.Image")));
            this.btn_AddToGrid.Location = new System.Drawing.Point(1250, 240);
            this.btn_AddToGrid.Name = "btn_AddToGrid";
            this.btn_AddToGrid.Size = new System.Drawing.Size(54, 59);
            this.btn_AddToGrid.TabIndex = 21;
            this.btn_AddToGrid.UseVisualStyleBackColor = true;
            this.btn_AddToGrid.Click += new System.EventHandler(this.btn_AddToGrid_Click);
            // 
            // frm_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 655);
            this.Controls.Add(this.btn_EditRowFromGrid);
            this.Controls.Add(this.btn_DeleteFromGrid);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.btn_AddToGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_Date);
            this.Controls.Add(this.cmb_Items);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Nat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Qty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_InvoiceID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Invoices";
            this.Text = "frm_Invoices";
            this.Load += new System.EventHandler(this.frm_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_InvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dt_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dt_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dt_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nat;
        private System.Windows.Forms.ComboBox cmb_Items;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddToGrid;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Button btn_DeleteFromGrid;
        private System.Windows.Forms.Button btn_EditRowFromGrid;
    }
}