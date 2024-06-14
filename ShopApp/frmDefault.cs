using ShopApp.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }
        private void frmDefault_Load(object sender, EventArgs e)
        {
            lbName.ForeColor = frmHome.color;
            panel1.BackColor = frmHome.color;
            panel2.BackColor = frmHome.color;
            lbName.Text = frmLogin.nameLogin;

            // Thống kê tổng
            SqlCommand cmd = Code.Functions.RunProcedure("CountOrders");
            cmd.ExecuteNonQuery(); // 
            SqlDataReader data = cmd.ExecuteReader(); // Đọc dữ liệu trả về

            if (data.Read())
            {
                lbOrder.Text = Functions.FormatMoney(data[0].ToString());
            }
            cmd.Cancel();
            data.Close();

            SqlCommand cmdc = Code.Functions.RunProcedure("SumOrders");
            cmdc.ExecuteNonQuery();
            SqlDataReader datac = cmdc.ExecuteReader();

            if (datac.Read())
            {
                lbMoney.Text = Functions.FormatMoney(datac[0].ToString()) + " đ";
            }
            cmdc.Cancel();
            datac.Close();


            // Thống kê theo tháng
            SqlCommand cmds = Code.Functions.RunProcedure("CountOrdersCurrentMonth");
            cmds.ExecuteNonQuery(); // 
            SqlDataReader datas = cmds.ExecuteReader(); // Đọc dữ liệu trả về

            if (datas.Read())
            {
                lbOlderCurrentMonth.Text = Functions.FormatMoney(datas[0].ToString());
            }
            cmds.Cancel();
            datas.Close();

            SqlCommand cmdss = Code.Functions.RunProcedure("SumOrdersByCurrentMonth");
            cmdss.ExecuteNonQuery();
            SqlDataReader datass = cmdss.ExecuteReader();

            if (datass.Read())
            {
                lbMoneyCurrentMonth.Text = Functions.FormatMoney(datass[0].ToString()) + " đ";
            }
            cmdss.Cancel();
            datass.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
