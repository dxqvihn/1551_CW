using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Thêm lựa chọn Role vào ComboBox khi form load
            cmbRole.Items.Add("Player");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; // Mặc định chọn "Player
                                       // "
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString(); // Lấy role đã chọn từ ComboBox

            // Kiểm tra tên người dùng và mật khẩu (ví dụ đơn giản)
            if (username == "admin" && password == "12345" && role == "Admin")
            {
                MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính cho Admin
                CreatorForm creatorForm = new CreatorForm();
                creatorForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else if (username == "player" && password == "12345" && role == "Player")
            {
                MessageBox.Show("Đăng nhập thành công với quyền Người chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính cho Player
                
                PlayerForm playerForm = new PlayerForm();
                playerForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên người dùng, mật khẩu hoặc role không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
    }


