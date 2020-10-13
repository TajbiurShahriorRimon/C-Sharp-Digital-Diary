using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Diary
{
    public partial class DiaryForm : Form
    {
        static int idTest2;
        static string nameTest2;
        static object pic;        
        public DiaryForm()
        {
            InitializeComponent();
            createdTime.Text = System.DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        public DiaryForm(int i, string n)
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            browse.Visible = false;
            showPicture.Visible = false;

            createdTime.Text = System.DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            DiaryForm.idTest2 = i;
            string s = Convert.ToString(i);
            idLabel2.Text = s;

            DiaryForm.nameTest2 = n;
            nameLabel2.Text = n;

            evIdLabel.Visible = false;
        }

        public DiaryForm(int i, string n, int sign)
        {
            InitializeComponent();
            evIdLabel.Visible = false;
            done.Enabled = false;
            edit.Enabled = false;
            showPicture.Enabled = false;
            browse.Enabled = false;
            pictureBox1.Visible = false;
            browse.Visible = false;
            showPicture.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalDiary"].ConnectionString);
                con.Open();

                /*SqlCommand testCmd = con.CreateCommand();
                testCmd.Parameters.AddWithValue("@n", 5);
                testCmd.CommandText = "SELECT USER_NAME, MODIFIED_DATE, CREATED_DATE, EVENT, STORY, PRIORITY, USER_ID, PHOTO FROM UserEVENTS WHERE USER_ID= '" + i + "' and event= '" + n + "'";
                testCmd.ExecuteNonQuery();
                SqlDataReader da = testCmd.ExecuteReader();*/

                //string query = "SELECT USER_NAME, MODIFIED_DATE, CREATED_DATE, EVENT, STORY, PRIORITY, USER_ID, PHOTO, EVENT_ID FROM UserEVENTS WHERE USER_ID= '" + i + "' and event= '" + n + "'";
                string query = "SELECT USER_NAME, MODIFIED_DATE, CREATED_DATE, EVENT, STORY, PRIORITY, USER_ID, PHOTO, EVENT_ID FROM UserEVENTS WHERE USER_ID= '" + i + "' and event= '" + n + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader da = cmd.ExecuteReader();
                /*if (da.Read())
                {
                    MemoryStream stream = new MemoryStream(da.GetSqlBytes(7).Buffer);
                    pictureBox1.Image = Image.FromStream(stream);
                }*/
                while (da.Read())
                {
                    eventText.Text = da.GetValue(3).ToString();
                    storyText.Text = da.GetValue(4).ToString();
                    createdTime.Text = da.GetValue(2).ToString();
                    modifiedTime.Text = da.GetValue(1).ToString();
                    importanceBox.Text = da.GetValue(5).ToString();
                    idLabel2.Text = da.GetValue(6).ToString();
                    nameLabel2.Text = da.GetValue(0).ToString();

                    evIdLabel.Text = da.GetValue(8).ToString();                    
                }

                //Using Array DataStructure
                //______________________________________________________
                string[] array = new string[3];
                array[0] = eventText.Text;
                array[1] = storyText.Text;
                array[2] = importanceBox.Text;

                for (int n1 = 0; n1 < 3; n1++)
                {
                    MessageBox.Show(array[n1].ToString());
                }
                //________________________________________________________________________

                MessageBox.Show("Showing Created Date and Modified Date Sequencially");

                //Using LinkedList DataStructure
                //______________________________________________________
                LinkedList<string> dt = new LinkedList<string>();
                dt.AddLast(createdTime.Text);
                dt.AddLast(modifiedTime.Text);

                foreach (string str in dt)
                {
                    MessageBox.Show(str);
                }
                //_______________________________________________________________
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error connecting... " + ex);
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (!eventText.Text.Equals(String.Empty))
            {
                storyText.ReadOnly = true;
                eventText.ReadOnly = false;
                modifiedTime.Text = System.DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

                done.Enabled = false;
                browse.Enabled = false;
                importanceBox.Enabled = false;
                eventText.ReadOnly = false;

                string priority = importanceBox.Text;
                string modTime = modifiedTime.Text;
                string story = storyText.Text;
                string evName = eventText.Text;
                string crTime = createdTime.Text;

            //MessageBox.Show("done clock");

                DatabaseDiary db = new DatabaseDiary();
            //MessageBox.Show("done clock2");
            //MessageBox.Show("time now: " +crTime);
            db.AddUserEvent(story, modTime, priority, evName, DiaryForm.idTest2, DiaryForm.nameTest2, crTime);//pic
            //MessageBox.Show("done clock 3");
            }
            else
            {
                MessageBox.Show("Fill the event name");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (!eventText.Text.Equals(String.Empty))
            {
                storyText.ReadOnly = false;
                done.Enabled = true;
                browse.Enabled = true;
                importanceBox.Enabled = true;
                eventText.ReadOnly = false;

                DatabaseDiary db = new DatabaseDiary();
                int i = Convert.ToInt32(idLabel2.Text);
                db.DeleteUserEventEdit(eventText.Text, i);
            }
            else
            {
                MessageBox.Show("Fill the event name");
            }

        }

        private void browse_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog od = new OpenFileDialog();
            od.FileName = "";
            try
            {
                if(od.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(od.FileName);
                    
                }
                var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
                pic = image;
            } catch(Exception ex)
            {

            }
        }       

        private void DiaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(idLabel2.Text);
            User user = new User(s, nameLabel2.Text);
            user.Show();
            this.Hide();
        }

        private void showPicture_Click(object sender, EventArgs e)
        {
            

        }
        
        
    }    
}
