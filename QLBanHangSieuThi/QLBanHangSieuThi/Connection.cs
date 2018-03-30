using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBanHangSieuThi
{
    class Connection
    {
        string conn= "Data Source=DESKTOP-SSCJKUR;Initial Catalog=QLBHSieuThi;Integrated Security=True";
        SqlConnection sqlconn;
        SqlCommand sqlcom;
        SqlDataAdapter sqldataa;
        SqlDataReader sqldatar;
        DataSet ds = new DataSet();
        public void ketnoi()
        {
            sqlconn = new SqlConnection(conn);
            sqlconn.Open();
        }
        public void ngatketnoi()
        {
            sqlconn.Close();
        }
        public bool ktlogin(string data,string strsql,byte cot)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while(sqldatar.Read())
            {
                if(data.ToLower() == sqldatar[cot].ToString().ToLower())
                {
                    ok = true;
                }
            }
            ngatketnoi();
            return ok;
            
        }
        public string tongquan(string strsql,byte cot)
        {
            string temp=null;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while(sqldatar.Read())
            {
                temp=sqldatar[cot].ToString();
                
            }
            ngatketnoi();
            return temp;
        }
     
        public bool tongquan1(string data,string strsql, byte cot)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while (sqldatar.Read())
            {
                if(data == sqldatar[cot].ToString())
                {
                    ok = true;
                }

            }
            ngatketnoi();
            return ok;
        }
        
    }
}
