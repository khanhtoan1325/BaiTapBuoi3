using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaiTapBuoi3.Form1;

namespace BaiTapBuoi3
{
    public partial class frm1 : Form
    {
        public string MSNV { get; private set; }
        public string HoTen { get; private set; }
        public decimal LuongCoBan { get; private set; }

        public frm1 (NhanVien nhanVien)
        {
            InitializeComponent();
            txtMNV.Text = nhanVien.MSNV;
            txtTen.Text = nhanVien.HoTen;
            txtLuong.Text = nhanVien.LuongCoBan + "";

        }
        public frm1()
        {
            InitializeComponent();
        }


        private void btnDongY_Click(object sender, EventArgs e)
        {
            
            MSNV = txtMNV.Text;
            HoTen = txtTen.Text;
            LuongCoBan = decimal.Parse(txtLuong.Text);

            if (string.IsNullOrEmpty(MSNV) || string.IsNullOrEmpty(HoTen))
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }

            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn bỏ qua ? ","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK) 
                Close();
        }
    }
}
