using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class frmHome : Form
    {
        // Định nghĩa biến cờ (flag) để theo dõi trạng thái đăng xuất
        private bool isLoggedOut = false;
        public frmHome()
        {
            InitializeComponent();
        }

        private Button currentButton;
        public static Color color = ColorTranslator.FromHtml("#009688");

        private void OpenChildForm(Form ChildForm, string title)
        {
            // Thiết lập thông tin cho form con.
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None; //Bỏ viền 
            ChildForm.Dock = DockStyle.Fill; // Dãn theo form cha để ko bị vỡ form

            // Thêm form vào panel
            // pnMain là một control được sử dụng để chứa và quản lý các control khác
            // PnMain được khai báo và khởi tạo trước đó, được sử dụng để chứa các form con
            this.pnMain.Controls.Add(ChildForm);
            this.pnMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lbTitle.Text = title; // Gán title
        }

        // Cài đặt màu
        private Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        // Áp dụng màu khi chọn button
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new Font("Arial", 13.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previouBtn in flpMenu.Controls)
            {
                previouBtn.BackColor = Color.FromArgb(51, 51, 76);
                previouBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        // Điều hướng đến chức năng chọn
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmProducts(), "Quản lý sản phẩm");
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmCategories(), "Quản lý danh mục");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmUsers(), "Quản lý người dùng");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmDefault(), "Trang chủ");
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmCarts(), "Bán hàng");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmAnalytics(), "Thống kê");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmSetting(), "Cài đặt");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                // Đặt hành động đăng xuất ở đây, ví dụ: mở form đăng nhập lại
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                isLoggedOut = true;
                this. Close(); // Đóng form chính sau khi đăng xuất
                //this.Hide(); // Ẩn form chính sau khi đăng xuất
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            panelTitle.BackColor = color;
            panelLogo.BackColor = ChangeColorBrightness(color, -0.3);
            if (frmLogin.positionLogin.Equals("2"))
            {
                btnCategories.Enabled = false;
            }
            Code.Functions.Connect();
            OpenChildForm(new frmDefault(), "Trang chủ");
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggedOut)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
