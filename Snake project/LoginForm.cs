using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Snake_project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Настенька\source\repos\Snake project\Snake project\Users.mdf"";Integrated Security=True");

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username1;
            username1 = textBox1.Text;

            try
            {
                conn.Open();
                String querry = "SELECT * FROM UserTable WHERE username = '" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    username1 = textBox1.Text;

                    MenuForm form1 = new MenuForm();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Some dumb error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                username1 = textBox1.Text;
                MessageBox.Show(textBox1.Text);
            }

            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }
    }
}
