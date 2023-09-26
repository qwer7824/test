using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using test.DBConn;
using test.Model;

namespace test.Repository
{
    class UserRepository
    {
        private MySqlConnection conn = null;

        public UserRepository()
        {
            conn = DBConn.DBConn.getConn();
        }

            public string Login(string userId, string userPw)
            {
                try
                {

                string selectQuery = "SELECT * FROM user WHERE user_id = \'" + userId + "\' ";

                    conn.Open();

                   MySqlCommand command = new MySqlCommand(selectQuery, conn);


                // 데이터 출력
                MySqlDataReader userAccount = command.ExecuteReader();

                while (userAccount.Read())
                {
                    if (userId == (string)userAccount["user_id"] && userPw == (string)userAccount["user_pw"])
                    {
                        return userId;
                    }
                    conn.Close();
                }
                return "회원정보가 없습니다.";
          
                }
                catch (SqlException e)
                {
                    return e.Message;
                }
                finally
                {
                    conn.Close();
                }
            }


        // 사용자 전체 리스트
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                string selectQuery = "SELECT * FROM user";

                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                conn.Open();


                // 데이터 출력
                using (MySqlDataReader SR = command.ExecuteReader())
                {
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        // 사용자 등록
        public bool AddUser(User user)
        {
            try
            {
                string insertQuery = string.Format("INSERT INTO user (user_id, user_pw, user_name, user_address, user_phone, user_auth) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}');"
                    , user.userId, user.userPw, user.userName, user.userAddress, user.userPhone, user.userAuth);

                conn.Open();

                MySqlCommand command = new MySqlCommand(insertQuery, conn);


                return command.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        // 유저 조회
        public User GetUserByNumber(string userNo)
        {
            User user = null;
            try
            {
                string selectQuery = "SELECT * FROM user WHERE user_no = \'" + userNo + "\' ";

                conn.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, conn);

                // 데이터 출력
                using (MySqlDataReader SR = command.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        user = new User();
                        user.userNo = SR[0].ToString();
                        user.userId = SR[1].ToString();
                        user.userName = SR[3].ToString();
                        user.userAddress = SR[4].ToString();
                        user.userPhone = SR[5].ToString();
                    }
                }
                return user;
            }
            catch (SqlException e)
            {
                return user;
            }
            finally
            {
                conn.Close();
            }
        }

        // 사용자 정보 수정
        public bool UpdateUserInfo(User user)
        {
            try
            {
                string Query = "update USER set USER_NO = '" + user.userNo + "', USER_NAME = '" + user.userName + "'," +
    "user_address ='" + user.userAddress + "', USER_ID = '" + user.userId + "',user_phone = '" + user.userPhone + "'" +
    " where user_no = '" + user.userNo + "';";


                conn.Open();

                MySqlCommand command = new MySqlCommand(Query, conn);


                return command.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
    }
