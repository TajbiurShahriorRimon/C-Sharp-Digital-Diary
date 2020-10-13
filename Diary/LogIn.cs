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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(String.Empty) || textBox2.Text.Equals(String.Empty) || textBox3.Text.Equals(String.Empty))
            {
                MessageBox.Show("Fill up all the boxes");

            }
            else
            {
                DatabaseDiary db = new DatabaseDiary();
                string name = textBox1.Text;
                string pass = textBox2.Text;
                
                try
                {
                    int id = Int32.Parse(textBox3.Text);
                    bool sig = db.CheckUser(name, pass, id);
                    if (sig == true)
                    {
                        User user = new User(id, name);
                        user.Show();
                        this.Hide();
                    }
                    else
                    {
                        db.CheckUser(name, pass, id);
                    }
                    int sig1 = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Id must be a Number, not Text!");

                }
            }
        }
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
