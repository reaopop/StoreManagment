
namespace StoreManagement.View
{
    partial class frm_AboutMe
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Youtube = new System.Windows.Forms.Button();
            this.btn_Facebook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer Mohamed Ali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thank you ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Exit.Image = global::StoreManagement.Properties.Resources.icons8_delete_100px;
            this.btn_Exit.Location = new System.Drawing.Point(736, 510);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 72);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Youtube.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Youtube.Image = global::StoreManagement.Properties.Resources.icons8_youtube_squared_100px;
            this.btn_Youtube.Location = new System.Drawing.Point(110, 526);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(56, 47);
            this.btn_Youtube.TabIndex = 5;
            this.btn_Youtube.UseVisualStyleBackColor = false;
            // 
            // btn_Facebook
            // 
            this.btn_Facebook.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facebook.Image = global::StoreManagement.Properties.Resources.icons8_facebook_100px;
            this.btn_Facebook.Location = new System.Drawing.Point(25, 526);
            this.btn_Facebook.Name = "btn_Facebook";
            this.btn_Facebook.Size = new System.Drawing.Size(56, 47);
            this.btn_Facebook.TabIndex = 4;
            this.btn_Facebook.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreManagement.Properties.Resources.information;
            this.pictureBox1.Location = new System.Drawing.Point(250, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(814, 585);
            this.Controls.Add(this.btn_Youtube);
            this.Controls.Add(this.btn_Facebook);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AboutMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Facebook;
        private System.Windows.Forms.Button btn_Youtube;
    }
}