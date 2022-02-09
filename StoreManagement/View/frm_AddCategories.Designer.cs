
namespace StoreManagement.View
{
    partial class frm_AddCategories
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Unite = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(488, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(134, 91);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(293, 35);
            this.txt_Name.TabIndex = 12;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(134, 42);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(293, 35);
            this.txt_ID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // cmb_Unite
            // 
            this.cmb_Unite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unite.FormattingEnabled = true;
            this.cmb_Unite.Location = new System.Drawing.Point(134, 142);
            this.cmb_Unite.Name = "cmb_Unite";
            this.cmb_Unite.Size = new System.Drawing.Size(293, 37);
            this.cmb_Unite.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Unit:";
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
            this.menuStrip1.Size = new System.Drawing.Size(492, 36);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::StoreManagement.Properties.Resources.icons8_new_copy_80px;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.newToolStripMenuItem.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::StoreManagement.Properties.Resources.icons8_delete_folder_32px;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // frm_AddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmb_Unite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_AddCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AddCategories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Unite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}