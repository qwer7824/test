using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;
using test.Repository;

namespace test
{
    public partial class SignUp : Form
    {

        UserRepository userRepository = new UserRepository();
        public SignUp()
        {
            InitializeComponent();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (userRepository.AddUser(CreateUserInstance()))
            {
                MessageBox.Show("사용자 등록에 성공하였습니다.");
                this.Close();
                return;
            }
            MessageBox.Show("사용자 등록에 실패했습니다.");
        }

        private User CreateUserInstance()
        {
            User user = new User();
            user.userId = userId.Text;
            user.userPw = userPw.Text;
            user.userName = userName.Text;
            user.userAddress = userAddress.Text;
            user.userPhone = userPhone.Text;
            user.userAuth = 0;
            return user;
        }
    }
}
