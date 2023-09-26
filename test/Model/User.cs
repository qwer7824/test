using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test.Model
{
    class User
    {
        private string user_no;
        private string user_id;
        private string user_pw;
        private string user_name;
        private string user_address;
        private string user_phone;
        private int user_auth;

        public string userNo { get { return user_no; } set { user_no = value; } }
        public string userId { get { return user_id; } set { user_id = value; } }
        public string userPw { get { return user_pw; } set { user_pw = value; } }
        public string userName { get { return user_name; } set { user_name = value; } }
        public string userAddress { get { return user_address; } set { user_address = value; } }
        public string userPhone { get { return user_phone; } set { user_phone = value; } }
        public int userAuth { get { return user_auth; } set { user_auth = value; } }

        public User(string user_no, string user_name, string user_address, string user_id, string user_pw,string user_phone, int user_auth)
        {
            this.user_no = user_no;
            this.user_name = user_name;
            this.user_address = user_address;
            this.user_id = user_id;
            this.user_pw = user_pw;
            this.user_phone = user_phone;
            this.user_auth = user_auth;
        }

        public User()
        {
        }
    }


}
