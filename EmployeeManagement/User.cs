using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PharmacyManagement.EmployeeManagement;

namespace PharmacyManagement
{
    class User
    {
        static AddEmployeeInterface addEmpObj;
        static LoginInterface logObj;
        static ChangePasswordInterface changePassObj;
        static SecurityQuestion securityQuesObj;

        public static SecurityQuestion SecurityQuesObj
        {
            get { return User.securityQuesObj; }
            set { User.securityQuesObj = value; }
        }
        private static String currentUserName;
        private static String userType;
        private static String userShop;

        public static String UserShop
        {
            get { return User.userShop; }
            set { User.userShop = value; }
        }

        public static String UserType
        {
            get { return User.userType; }
            set { User.userType = value; }
        }

        private String empID, fullName, firstName, nic, address, shop, type, status, password;

        private int contactNo;

        public User(String empID, String fullName, String firstName, String nic, String address, int contactNo, String shop, String type, String status, String password)
        {
            this.empID = empID;
            this.fullName = fullName;
            this.firstName = firstName;
            this.nic = nic;
            this.address = address;
            this.contactNo = contactNo;
            this.shop = shop;
            this.type = type;
            this.status = status;
            this.password = password;
            addUserToDatabase(this);
        }

        /*private void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        private String getFirstName()
        {
            return firstName;
        }

        private void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        private String getLastName()
        {
            return lastName;
        }

        private void setNIC(String nic)
        {
            this.nic = nic;
        }
        private String getNIC()
        {
            return nic;
        }

        private void setAddress(String address)
        {
            this.address = address;
        }
        private String getAddress()
        {
            return address;
        }

        private void setEmpID(String empID)
        {
            this.empID = empID;
        }
        private String getEmpID()
        {
            return empID;
        }

        private void setShop(String shop)
        {
            this.shop = shop;
        }
        private String getShop()
        {
            return shop;
        }

        private void setType(String type)
        {
            this.type = type;
        }
        private String getType()
        {
            return type;
        }

        private void setPassword(String password)
        {
            this.password = password;
        }
        private String getPassword()
        {
            return password;
        }

        private void setContactNo(int contactNo)
        {
            this.contactNo = contactNo;
        }
        private int getContactNo()
        {
            return contactNo;
        }*/

        public String EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public String Shop
        {
            get { return shop; }
            set { shop = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public void addUserToDatabase(User user)
        {
            string query = "insert into employee (EmpID,FullName,FirstName,NIC,Address,ContactNo,Shop,Type,Status,Password) values ('" + user.empID + "','" + user.fullName + "','" + user.firstName + "','" + user.nic + "','" + user.address + "','" + user.contactNo + "','" + user.shop + "','" + user.type + "','" + user.status + "','" + user.password + "')";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //addemp.clearAllText();
                //addemp.showMessage("Successfully added the new Employee!");
                User.addEmpObj.clearAllText();
                User.addEmpObj.showMessage("Successfully added the new Employee!");
            }
            catch (Exception ex)
            {
                User.addEmpObj.showMessage(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        public static void changePassword(String oldPassword, String newPassword, String question,  String answer)
        {
            if (isPasswordCorrect(oldPassword))
            {
                string query = "update employee set password ='" + newPassword + "', SecurityQuestion = '"+question+"', Answer = '"+answer+"' where EmpID = '" + User.LogObj.getUserName() + "'";
                MySqlConnection con = DBConnection.getConn();
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    User.ChangePassObj.clearText();
                    ChangePasswordInterface.showMessage("Password Changed successfully!");
                }
                catch (Exception ex)
                {
                    ChangePasswordInterface.showMessage("Error in doing, Please try again later" + ex.Message);
                }
                finally
                {
                    con.Close();
                    DBConnection.returnConn(con);
                    con = null;
                }
            }
            else 
            {
                ChangePasswordInterface.showMessage("Current Password wrong!");
            }
        }

        private static bool isPasswordCorrect(String password)
        {
            bool correct = false;
            string query = "Select Password from employee where EmpID ='" + User.LogObj.getUserName() + "'";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) == password)
                    {
                        correct = true;
                        break;
                    }   
                }
                return correct;            
            }
            catch (Exception ex)
            {
                ChangePasswordInterface.showMessage("Catch exception");
                return correct;
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        public static AddEmployeeInterface AddEmpObj
        {
            get { return User.addEmpObj; }
            set { User.addEmpObj = value; }
        }

        public static void loginUsers(String userName, String password)
        {
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                String query = "Select Type,Password,Status,Shop from employee where EmpID = '"+userName+"'";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string type = reader["Type"].ToString();
                    string type = reader.GetString(0);
                    string status = reader.GetString(2);
                    if (status == "Active")
                    {
                        if (reader.GetString(1) == password)
                        {
                            User.CurrentUserName = userName;
                            User.UserShop = reader.GetString(3);
                            User.UserType = type;
                            if (type == "Owner")
                            {
                                /*AdminInterface owner = new AdminInterface();
                                owner.Show();
                                this.Hide();*/
                                Owner.login();
                                LogObj.Hide();
                            }
                            else if (type == "Supervisor")
                            {
                                /*SupervisorInterface sp = new SupervisorInterface();
                                sp.Show();
                                this.Hide();*/
                                Supervisor.login();
                                LogObj.Hide();
                            }
                            else if (type == "Cashier")
                            {
                                /*CashierInterface emp = new CashierInterface();
                                emp.Show();
                                this.Hide();*/
                                Cashier.login();
                                LogObj.Hide();
                            }
                            else
                            {
                                //nameErLbl.Visible = true;
                                User.LogObj.displayErr();
                            }
                        }
                        else
                        {
                            //nameErLbl.Visible = true;
                            User.LogObj.displayErr();
                            User.LogObj.showForgotPassButton();
                        }
                    }
                    else
                        User.LogObj.inactiveErr();
                }
                if (!reader.HasRows)
                    //nameErLbl.Visible = true;
                    User.LogObj.displayErr();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        public static LoginInterface LogObj
        {
            get { return User.logObj; }
            set { User.logObj = value; }
        }

        public void login()
        {
        }

        public void logout()
        { }

        public static ChangePasswordInterface ChangePassObj
        {
            get { return User.changePassObj; }
            set { User.changePassObj = value; }
        }

        public static String CurrentUserName
        {
            get { return User.currentUserName; }
            set { User.currentUserName = value; }
        }

        public static String showSecurityQuestion()
        {
            String question = "";
            string query = "Select SecurityQuestion from employee where EmpID = '" + User.LogObj.getUserName() + "'";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    question = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
            return question;
        }

        public static void checkAnswer(String answer)
        {
            
            if (getAnswer() == answer)
            {
                User.ChangePassObj = new ChangePasswordInterface();
                User.ChangePassObj.setCurrentPassword(getCurrentPassword());
                User.ChangePassObj.Show();
            }
        }

        public static String getCurrentPassword()
        {
            String password = "";
            string query = "Select Password from employee where EmpID = '" + User.LogObj.getUserName() + "'";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    password = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
            return password;
        }

        public static String getAnswer()
        {
            String answer = "";
            string query = "Select Answer from employee where EmpID = '" + User.LogObj.getUserName() + "'";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    answer = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
            return answer;
        }

        public static String getQuestion()
        {
            String question = "";
            string query = "Select SecurityQuestion from employee where EmpID = '" + User.LogObj.getUserName() + "'";
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    question = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
            return question;
        }
    }
}
