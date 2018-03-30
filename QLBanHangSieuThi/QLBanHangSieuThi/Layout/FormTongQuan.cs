using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi.Layout
{
    public partial class FormTongQuan : UserControl
    {
        public FormTongQuan()
        {
            InitializeComponent();
            HoatDong();
        }
        Connection cn = new Connection();
        string tongtienlai2 = "select sum(giabanra-gianhapvao) from hanghoa inner join donhang on hanghoa.masanpham=donhang.masanpham where DONHANG.NGAYDAT= cast(getdate() as date)";
        public string day1= (DateTime.Now.Day).ToString();
        public string month1 = (DateTime.Now.Month).ToString();
        public string year1 = (DateTime.Now.Year).ToString();
        
        public void HoatDong()
        {
            day.Text = day1;
            month.Text = month1;
            year.Text = year1;
            tienbanhang.Text=cn.tongquan("select sum(giabanra) from hanghoa INNER JOIN DONHANG ON HANGHOA.MASANPHAM=DONHANG.MASANPHAM where DONHANG.NGAYDAT= cast(getdate() as date)", 0);
            hangbanra.Text = cn.tongquan("select count(masanpham) from donhang where NGAYDAT= cast(getdate() as date)", 0);
            sodonhang.Text = cn.tongquan("select count(madonhang) from donhang where NGAYDAT= cast(getdate() as date)", 0);
            taicho.Text = cn.tongquan("select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=1",0);
            giaohang.Text = cn.tongquan("select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=2", 0);
            hangkhachtra.Text = cn.tongquan("select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=3", 0);

            hangtrongkho.Text = cn.tongquan("select sum(SOLUONG) FROM HANGHOA ", 0);
            hangtonkholau.Text = cn.tongquan("select count(masanpham) from hanghoa where month(ngaynhap) <= month(cast(GETDATE() as date)) - 1 and year(ngaynhap)=year(cast(GETDATE() as date))",0);//san pham co ngay nhap qua 1 thang so voi hien tai
            hangdanghet.Text = cn.tongquan("select count(masanpham) from hanghoa where soluong=0", 0);
            sohangsaphet.Text = cn.tongquan("select count(masanpham) from hanghoa where soluong<5", 0);


            hangbiloi.Text = cn.tongquan("select count(*) from hanghoa where kiemtraloi=1", 0);
            HoatDongHN();
        }
        public void HoatDongHN()
        {
            
            tienbanhang1.Text = tienbanhang.Text ;
            tongtienlai1.Text = cn.tongquan(tongtienlai2, 0);
            sodonhang1.Text = sodonhang.Text;
            int temp = Int32.Parse(tienbanhang1.Text) / Int32.Parse(sodonhang1.Text);
            tientrungbinh.Text = temp.ToString();
            hangkhachtra1.Text = hangkhachtra.Text;
        }
        private void ddtime_Selected(object sender, EventArgs e)
        {
            if (ddtime.selectedValue.ToString() == "Hôm nay")
            {
                if (cn.tongquan1(day1,"select DAY(NGAYDAT) FROM DONHANG", 0) == true && cn.tongquan1(month1, "select MONTH(NGAYDAT) FROM DONHANG", 0) == true && cn.tongquan1(year1, "select YEAR(NGAYDAT) FROM DONHANG", 0) == true)
                {
                    HoatDongHN();
                }
            }
            else if (ddtime.selectedValue.ToString() == "Tháng này")
            {
                if (cn.tongquan1(month1, "select MONTH(NGAYDAT) FROM DONHANG", 0) == true && cn.tongquan1(year1, "select YEAR(NGAYDAT) FROM DONHANG", 0) == true)
                {
                    tienbanhang1.Text = cn.tongquan("select sum(giabanra) from hanghoa inner join donhang on hanghoa.MASANPHAM=DONHANG.MASANPHAM where year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))", 0);
                    tongtienlai1.Text = cn.tongquan("select sum(giabanra-gianhapvao) from hanghoa inner join donhang on hanghoa.masanpham=donhang.masanpham where year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))", 0);
                    sodonhang1.Text= cn.tongquan("select count(madonhang) from donhang where year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))", 0);
                    int temp1 = Int32.Parse(tienbanhang1.Text) / Int32.Parse(sodonhang1.Text);
                    tientrungbinh.Text = temp1.ToString();
                    hangkhachtra1.Text= cn.tongquan("select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=3 and year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))", 0);
                }
                
            }
            else
            {
                if(cn.tongquan1(year1, "select YEAR(NGAYDAT) FROM DONHANG", 0) == true)
                {
                    tienbanhang1.Text = cn.tongquan("select sum(giabanra) from hanghoa inner join donhang on hanghoa.MASANPHAM=DONHANG.MASANPHAM where year(donhang.NGAYDAT)=year(cast(getdate() as date))", 0);
                    sodonhang1.Text = cn.tongquan("select count(madonhang) from donhang where year(donhang.NGAYDAT)=year(cast(getdate() as date))", 0);
                    tongtienlai1.Text = cn.tongquan("select sum(giabanra-gianhapvao) from hanghoa inner join donhang on hanghoa.masanpham=donhang.masanpham where year(donhang.NGAYDAT)=year(cast(getdate() as date))", 0);
                    int temp2 = Int32.Parse(tienbanhang1.Text) / Int32.Parse(sodonhang1.Text);
                    tientrungbinh.Text = temp2.ToString();
                    hangkhachtra1.Text= cn.tongquan("select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=3 and  year(donhang.NGAYDAT)=year(cast(getdate() as date))", 0);
                }
            }
        }
    }
}
