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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (textBox1Sign.Text.Equals(String.Empty) || textBox2Sign.Text.Equals(String.Empty))
            {
                MessageBox.Show("Fill up the boxes properly");
                
            }
            else
            {
                MessageBox.Show("Account Created Successfully!!!");
                
                DatabaseDiary db = new DatabaseDiary();                

                string name = textBox1Sign.Text;
                string pass = textBox2Sign.Text;
                int idTest3 = db.AddUser(name, pass);
                User user = new User(idTest3, name);
                user.Show();
                this.Hide();
            }            
        }        

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
