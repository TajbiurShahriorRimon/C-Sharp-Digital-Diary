using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Globalization;

namespace Diary
{
    class DatabaseDiary
    {
        SqlConnection con;
        SqlCommand command;
        public DatabaseDiary()
        {
            try
            {
                this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalDiary"].ConnectionString);
                this.con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public int AddUser(string n, string pass)
        {
            try
            {
                string sql = "INSERT INTO Users(user_name, user_password) VALUES('" + n + "', '"+pass+"')";
            
                command = new SqlCommand(sql, con);
                int result = command.ExecuteNonQuery();

                string query1 = "SELECT count(*) FROM USERS";
                command = new SqlCommand(query1, con);
                int count = (int)command.ExecuteScalar();
                string y = Convert.ToString(count);
                MessageBox.Show("Your User ID: " + y + "\nRemember your user ID for log in purpose!");
                return count;

            } catch (Exception ex)
            {
                MessageBox.Show("Error! "+ex);
                return -1;
                
            }
        }
        public bool CheckUser(string n, string pass, int id)
        {
            try
            {
                string query = "SELECT * FROM USERS WHERE user_name= '" + n + "'and user_password = '" + pass + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();                

                sqlDataAdapter.Fill(dataTable);
                if(dataTable.Rows.Count == 1)
                {
                    //MessageBox.Show("Found");
                    return true;
                }
                else
                {
                    MessageBox.Show("Not Found");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                return false;
            }
            //return false;
        }

        public bool CheckCreatedEvent(string n, int id, DataGridView dg)
        {

            try
            {
                //string s = Convert.ToString(id);
                MessageBox.Show("Id searching: " + id);
                string query = "SELECT * FROM UserEVENTS WHERE user_id= '"+ id +"'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);                
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > -1)
                {
                    //MessageBox.Show("Found");

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select event from UserEvents WHERE user_id= '"+ id + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(cmd.CommandText);
                    DataTable dataTable2 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable2);
                    dg.DataSource = dataTable2;

                    //Using List DataStructure
                    //______________________________________________________
                    int f;
                    int dCount = dataTable2.Rows.Count;
                    List<string> l1 = new List<string>();
                    for (f = 0; f < dCount; f++)
                    {
                        l1.Add(dataTable.Rows[f].ToString());
                    }

                    MessageBox.Show("Total Number of events: " + l1.Count);
                    //____________________________________________________________

                    return true;
                }
                else
                {
                    //MessageBox.Show("Not Found");
                    dg.Visible = true;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                return false;
            }
        }

        /*public void AddUserEvent(string story, string modTime, string priority, string evName, int id, string n, string crTime, object image)
        {
            try
            {
                

                string query = "INSERT INTO UserEvents(story, modified_date, priority, event, user_id, user_name, created_date, photo) Values('" + story + "', '" + modTime + "', '" + priority + "', '" + evName + "', '"+ id +"', '"+ n + "', '" + crTime + "', '"+ image +"')";
                MessageBox.Show("....");
                command = new SqlCommand(query, con);
                MessageBox.Show("2....");
                int result = command.ExecuteNonQuery();
                MessageBox.Show("3....");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Last...! " + ex);            
            }
        }*/
        public void AddUserEvent(string story, string modTime, string priority, string evName, int id, string n, string crTime)
        {
            try
            {
                /*SqlCommand testCmd = con.CreateCommand();
                testCmd.Parameters.AddWithValue("@photo", image);
                testCmd.CommandText = "INSERT INTO UserEvents(story, modified_date, priority, event, user_id, user_name, created_date, photo) Values('" + story + "', '" + modTime + "', '" + priority + "', '" + evName + "', '" + id + "', '" + n + "', '" + crTime + "', '"+ image +"')";
                testCmd.ExecuteNonQuery();*/

                //this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalDiary"].ConnectionString);
                //this.con.Open();
                MessageBox.Show(id.ToString()+ " time: " +crTime);
                
                //DateTime myDate = Convert.ToDateTime(crTime);
                DateTime crDate = DateTime.ParseExact(crTime, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);//dd-MM-yyyy HH:mm:ss M/d/yyy
                DateTime modDate = DateTime.ParseExact(modTime, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                //story = "htrh"; n = "taj"; id = 5; evName = "bt"; priority = "High";
                //string query = "INSERT INTO UserEvents(story, modified_date, priority, event, user_id, user_name, created_date) Values('" + story + "', '" + modTime + "', '" + priority + "', '" + evName + "', '" + id + "', '" + n + "', '" + crTime + "')";

                string query = "INSERT INTO USEREVENTS(story, priority, event, user_id, user_name, created_date, modified_date) VALUES ('" + story +
                               "', '" + priority + "', '" + evName + "','" + id + "', '"+ n +"', '"+ crDate +"', '"+ modDate +"')";
                MessageBox.Show("....");

                command = new SqlCommand(query, con);
                MessageBox.Show("2....");
                //command.Connection = con;
                //command.CommandTimeout = 300;
                command.ExecuteNonQuery();
                MessageBox.Show("3....");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Last...! " + ex);
            }
        }

        public void DeleteUserEvent(string evName, int id, DataGridView dg)
        {
            try
            {
                string query = "delete from UserEvents where event= '" + evName + "' and user_id= '" + id + "'";
                command = new SqlCommand(query, con);
                int result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Last...! " + ex);
            }

            this.CheckCreatedEvent(evName, id, dg);
        }

        public void DeleteUserEventEdit(string evName, int id)
        {
            try
            {
                string query = "delete from UserEvents where event= '" + evName + "' and user_id= '" + id + "'";
                command = new SqlCommand(query, con);
                int result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Last...! " + ex);
            }

            //this.CheckCreatedEvent(evName, id, dg);
        }

        public void Show(DiaryForm diaryForm, string evName, int uId)
        {
            
        }
    }
}
