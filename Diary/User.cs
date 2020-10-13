using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class User : Form
    {
        static int idTest;
        static string nameTest;
        public User()
        {
            InitializeComponent();
        }
        public User(int id, string name)
        {
            InitializeComponent();            
            DatabaseDiary db = new DatabaseDiary();

            User.idTest = id;
            string s = Convert.ToString(idTest);
            idLabel1.Text = s;

            openButton.Enabled = false;
            deleteButton.Enabled = false;

            User.nameTest = name;
            nameLabel1.Text = name;

            bool sig = db.CheckCreatedEvent(name, id, eventListTable);

            if(sig == false)
            {
                eventListTable.Visible = false;
            }
            else
            {
                eventListTable.Visible = true;

            }

            //Using List DataStructure
            //______________________________________________________

            List<string> list1 = new List<string>();
            list1.Add(idLabel1.Text);
            list1.Add(nameLabel1.Text);
            MessageBox.Show("Showing User User Id, User Name... Sequencially");
            foreach (string str in list1)
            {
                MessageBox.Show(str);
            }
            //____________________________________________________________________________
        }

        private void createNewEvent_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(User.idTest);
            //MessageBox.Show(s);
            DiaryForm d = new DiaryForm(User.idTest, User.nameTest);
            d.Show();            
            this.Hide();
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(label6.Text);
            DatabaseDiary db = new DatabaseDiary();
            int i = Convert.ToInt32(idLabel1.Text); 
            db.DeleteUserEvent(label6.Text, i, eventListTable);
        }

        private void eventListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            openButton.Enabled = true;
            deleteButton.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = eventListTable.Rows[e.RowIndex];
                label6.Text = dataGridViewRow.Cells[0].Value.ToString();
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                int sig = 1;
                int i = Convert.ToInt32(idLabel1.Text);
                DiaryForm d = new DiaryForm(i, label6.Text, sig);
                d.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an event");
            }
        }
    }
}
