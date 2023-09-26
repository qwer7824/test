using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Repository;

namespace test
{
    public partial class Login : Form
    {
        UserRepository userRepository = new UserRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            doLogin();
        }


        private void doLogin()
        {
            if (string.IsNullOrEmpty(textId.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                textId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPw.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                textPw.Focus();
                return;
            }

            string result = userRepository.Login(textId.Text, textPw.Text);
            if (!result.All(char.IsDigit))
            {
                MessageBox.Show(result);
                return;
            }

            Main main = new Main();
            main.Show();
            main.BringToFront();

            this.Hide();
        }

    }
}