using QuanLyCuaHang.View.Functions.Functions_DanhSachHangHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.View.Functions
{
    public partial class UC_DanhSachHangHoa : UserControl
    {
        public UC_DanhSachHangHoa()
        {
            InitializeComponent();
        }
        UC_FC_DanhSachHangHoa _FC_DanhSachHangHoa = new UC_FC_DanhSachHangHoa();
        UC_FC_ThemHangHoa _UC_FC_ThemHangHoa;
        private void btnDanhSachHang_Click(object sender, EventArgs e)
        {
            if (!this.pnFunction.Controls.Contains(_FC_DanhSachHangHoa))
            {
                _FC_DanhSachHangHoa = new UC_FC_DanhSachHangHoa();
                this.pnFunction.Controls.Add(_FC_DanhSachHangHoa);
            }
            _FC_DanhSachHangHoa.BringToFront();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            if (!this.pnFunction.Controls.Contains(_UC_FC_ThemHangHoa))
            {
                _UC_FC_ThemHangHoa = new UC_FC_ThemHangHoa();
                this.pnFunction.Controls.Add(_UC_FC_ThemHangHoa);
            }
            _UC_FC_ThemHangHoa.BringToFront();
        }

        private void UC_DanhSachHangHoa_Load(object sender, EventArgs e)
        {
            this.pnFunction.Controls.Add(_FC_DanhSachHangHoa);
        }
    }
}
