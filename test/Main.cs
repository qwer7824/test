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
using test.UserController;

namespace test
{
    public partial class Main : Form
    {
        UserRepository userRepository = new UserRepository();

        public Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void UserAll()
        {
            DataTable table = userRepository.GetAllUsers();
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            userSearch.ShowDialog();
        }
    }
}
