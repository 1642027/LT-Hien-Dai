namespace Client
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraTu = new System.Windows.Forms.Button();
            this.txtTiengViet = new System.Windows.Forms.TextBox();
            this.txtTiengAnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraTu);
            this.groupBox1.Controls.Add(this.txtTiengViet);
            this.groupBox1.Controls.Add(this.txtTiengAnh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pháp - Việt";
            // 
            // btnTraTu
            // 
            this.btnTraTu.Location = new System.Drawing.Point(109, 92);
            this.btnTraTu.Name = "btnTraTu";
            this.btnTraTu.Size = new System.Drawing.Size(75, 23);
            this.btnTraTu.TabIndex = 4;
            this.btnTraTu.Text = "Tra Từ";
            this.btnTraTu.UseVisualStyleBackColor = true;
            this.btnTraTu.Click += new System.EventHandler(this.btnTraTu_Click);
            // 
            // txtTiengViet
            // 
            this.txtTiengViet.Location = new System.Drawing.Point(84, 49);
            this.txtTiengViet.Name = "txtTiengViet";
            this.txtTiengViet.Size = new System.Drawing.Size(147, 20);
            this.txtTiengViet.TabIndex = 3;
            // 
            // txtTiengAnh
            // 
            this.txtTiengAnh.Location = new System.Drawing.Point(84, 17);
            this.txtTiengAnh.Name = "txtTiengAnh";
            this.txtTiengAnh.Size = new System.Drawing.Size(147, 20);
            this.txtTiengAnh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiếng Việt : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếng Pháp : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraTu;
        private System.Windows.Forms.TextBox txtTiengViet;
        private System.Windows.Forms.TextBox txtTiengAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

