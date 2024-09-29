using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi3
{
    public partial class Form1 : frm1 
    {
        // Lớp Nhân Viên
        public class NhanVien
        {
            public string MSNV { get; set; } 
            public string HoTen { get; set; }
            public decimal LuongCoBan { get; set; }
        }

        private BindingList<NhanVien> danhSachNhanVien = new BindingList<NhanVien>();

        public Form1()
        {
            InitializeComponent();
            DataDanhSach.DataSource = danhSachNhanVien; 
        }
        //Nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn đang muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Nút thêm nhân viên
        private void bntThem_Click(object sender, EventArgs e)
        {
            
            frm1 form2 = new frm1(); 

            
            if (form2.ShowDialog() == DialogResult.OK)
            {
                
                NhanVien NVM = new NhanVien
                {
                    MSNV = form2.MSNV,       
                    HoTen = form2.HoTen,     
                    LuongCoBan = form2.LuongCoBan 
                };

                
                danhSachNhanVien.Add(NVM);
            }
        }
        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (DataDanhSach.SelectedRows.Count > 0) 
            {
                
                int index = DataDanhSach.SelectedRows[0].Index;

                
                NhanVien NVDC = danhSachNhanVien[index];

                
                frm1 form2 = new frm1 (NVDC); 
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    
                    NVDC.MSNV = form2.MSNV;
                    NVDC.HoTen = form2.HoTen;
                    NVDC.LuongCoBan = form2.LuongCoBan;

                    DataDanhSach.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để sửa");
            }
        }

        // Nút Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataDanhSach.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = DataDanhSach.SelectedRows[0].Index;
                    danhSachNhanVien.RemoveAt(index);
                }    
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 người để xóa");
                }    
            }    
        }

        private void DataDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào hàng hợp lệ không
            if (e.RowIndex >= 0) 
            {
                NhanVien nv = danhSachNhanVien[e.RowIndex];
            }
        }

    }

}

