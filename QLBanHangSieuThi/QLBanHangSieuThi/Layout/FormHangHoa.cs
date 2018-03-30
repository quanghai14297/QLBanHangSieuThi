using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLBanHangSieuThi.Layout
{
    public partial class FormHangHoa : UserControl
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        /*private void FormLoad(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = GetEmployeesList();
        }
        private DataTable GetEmployeesList()
        {
            string conn = "Data Source=DESKTOP-SSCJKUR;Initial Catalog=QLBHSieuThi;Integrated Security=True";
            SqlConnection sqlconn;
            sqlconn = new SqlConnection(conn);
            sqlconn.Open();
            DataTable dtEmployees = new DataTable();
            SqlCommand sqlcom = new SqlCommand("select MASANPHAM as N'Mã hàng hóa', TENSANPHAM as N'Tên hàng hóa',SOLUONG as N'Số lượng',gianhapvao as N'Giá nhập',giabanra as N'Giá bán ra',ngaynhap as N'Ngày nhập' from HANGHOA", sqlconn);
            SqlDataReader reader = sqlcom.ExecuteReader();
            dtEmployees.Load(reader);
            return dtEmployees;
        }*/
    }
}
