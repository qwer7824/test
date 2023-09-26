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

namespace test.UserController
{
    public partial class UserSearch : Form
    {
        UserRepository userRepository = new UserRepository();
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectBut_Click(object sender, EventArgs e)
        {   
                if (string.IsNullOrEmpty(userNoText.Text))
                {
                    MessageBox.Show("사용자 번호를 입력해주세요.");
                    userNoText.Focus();
                    return;
                }

                User user = userRepository.GetUserByNumber(userNoText.Text);

                if (user == null)
                {
                    MessageBox.Show("사용자 번호를 확인해주세요!");
                    userNoText.Focus();
                    return;
                }

                userNoText.ReadOnly = true;

                userName.Text = user.userName;
                userAddress.Text = user.userAddress;
                userPhone.Text = user.userPhone;
                userId.Text = user.userId;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (!userNoText.ReadOnly)
                {
                    MessageBox.Show("사용자 조회를 하고 수정해주세요.");
                    return;
                }

                if (string.IsNullOrEmpty(userNoText.Text))
                {
                    MessageBox.Show("사용자 번호를 입력해주세요.");
                    userNoText.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(userName.Text))
                {
                    MessageBox.Show("사용자 이름을 입력해주세요.");
                    userName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(userAddress.Text))
                {
                    MessageBox.Show("사용자 주소를 입력해주세요.");
                    userAddress.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(userId.Text))
                {
                    MessageBox.Show("아이디를 입력해주세요.");
                    userId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(userPhone.Text))
                {
                    MessageBox.Show("번호를 입력해주세요.");
                    userPhone.Focus();
                    return;
                }

                if (MessageBox.Show($"{userNoText.Text}번의 사용자를 수정하시겠습니까?", null, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    User user = new User();
                    user.userNo = userNoText.Text;
                    user.userName = userName.Text;
                    user.userAddress = userAddress.Text;
                    user.userId = userId.Text;
                    user.userPhone = userPhone.Text;

                    if (userRepository.UpdateUserInfo(user))
                    {
                        MessageBox.Show("정상적으로 수정 되었습니다.");
                        this.Close();
                        return;
                    }
                    MessageBox.Show("없는 사용자 이거나 번호를 확인해주세요.");
                    return;
                }
                MessageBox.Show("취소 하셨습니다.");
            }
        }
    }
    }
