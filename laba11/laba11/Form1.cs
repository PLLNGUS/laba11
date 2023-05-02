using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserContext hulan = new UserContext();
            hulan.Database.Delete();
            hulan.Database.Create();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                GetHashString gett = new GetHashString();
                User user = new User(textBox1.Text, gett.GetHash(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, "User");
                db.Users.Add(user);
                db.SaveChanges();

            }
        }
    }
}
