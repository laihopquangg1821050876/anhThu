using QuanLyCuaHang.View.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UC_DanhSachHangHoa _DanhSachHangHoa = new UC_DanhSachHangHoa();
        private void btnDanhSachHang_Click(object sender, EventArgs e)
        {
            if (!this.pnChucNang.Controls.Contains(_DanhSachHangHoa))
            {
                _DanhSachHangHoa = new UC_DanhSachHangHoa();
                this.pnChucNang.Controls.Add(_DanhSachHangHoa);
            }
            _DanhSachHangHoa.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pnChucNang.Controls.Add(_DanhSachHangHoa);
        }
    }
}
