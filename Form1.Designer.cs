namespace BaiTapBuoi3
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
            this.DataDanhSach = new System.Windows.Forms.DataGridView();
            this.bntThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDanhSach
            // 
            this.DataDanhSach.AllowUserToAddRows = false;
            this.DataDanhSach.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DataDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDanhSach.Location = new System.Drawing.Point(54, 70);
            this.DataDanhSach.Name = "DataDanhSach";
            this.DataDanhSach.RowHeadersWidth = 51;
            this.DataDanhSach.RowTemplate.Height = 24;
            this.DataDanhSach.Size = new System.Drawing.Size(435, 236);
            this.DataDanhSach.TabIndex = 0;
            this.DataDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDanhSach_CellContentClick);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(566, 83);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(114, 40);
            this.bntThem.TabIndex = 1;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(566, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(566, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(566, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.DataDanhSach);
            this.Name = "Form1";
            this.Text = "List View";
            this.Controls.SetChildIndex(this.DataDanhSach, 0);
            this.Controls.SetChildIndex(this.bntThem, 0);
            this.Controls.SetChildIndex(this.btnXoa, 0);
            this.Controls.SetChildIndex(this.btnSua, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataDanhSach;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
    }
}

