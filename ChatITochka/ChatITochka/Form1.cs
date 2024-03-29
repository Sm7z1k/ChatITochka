using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatITochka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string connectionString = "Data Source=DESKTOP-7KACT8E\\SQLEXPRESS;Initial Catalog=ChatITochka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
        }

        private void btnRegisterPanelRegister_Click(object sender, EventArgs e)
        {
            if(pbAva.Image == null)
            {
                MessageBox.Show("select photo");
                return;
            }
            if (tbLoginPanelRegister.Text == "")
            {
                MessageBox.Show("write u login");
                return;
            }
            if (tbEMailPanelRegister.Text == "")
            {
                MessageBox.Show("write u email");
                return;
            }
            if (tbPasswordPanelRegister.Text == "")
            {
                MessageBox.Show("write u password");
                return;
            }
            if (tbConfirmPanelRegister.Text != tbPasswordPanelRegister.Text)
            {
                MessageBox.Show("password not equals");
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "insert into Login(login,email,password,confirmpassword,image)values(@login,@email,@password,@confirmpassword,@image)";
            SqlCommand cmd = new SqlCommand(query, connection);
            MemoryStream me = new MemoryStream();
            pbAva.Image.Save(me, pbAva.Image.RawFormat);
            cmd.Parameters.AddWithValue("login", tbLoginPanelRegister.Text);
            cmd.Parameters.AddWithValue("email", tbEMailPanelRegister.Text);
            cmd.Parameters.AddWithValue("password", tbPasswordPanelRegister.Text);
            cmd.Parameters.AddWithValue("confirmpassword", tbConfirmPanelRegister.Text);
            cmd.Parameters.AddWithValue("image", me.ToArray());
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Registration successfully.....");
            tbLoginPanelRegister.Clear();
            tbEMailPanelRegister.Clear();
            tbPasswordPanelRegister.Clear();
            tbConfirmPanelRegister.Clear();
        }

        private void pbAva_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*Jpg; *.png; *Gif)|*.Jpg;*.jpeg; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbAva.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnLoginPanelLogin_Click(object sender, EventArgs e)
        {            
            if (tbLoginPanelLogin.Text == "")
            {
                MessageBox.Show("write u login");
                return;
            }            
            if (tbPasswordPanelLogin.Text == "")
            {
                MessageBox.Show("write u password");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            string q = "select * from Login WHERE email = '" + tbLoginPanelLogin.Text + "'AND password = '" + tbPasswordPanelLogin.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q, connection);
            SqlDataReader dataReader;
            connection.Open();
            dataReader = cmd1.ExecuteReader();
            
            //////////////////////////////////////////////
            if (!dataReader.HasRows)
            {
                connection.Close();
                connection.Open();
                q = "select * from Login WHERE login = '" + tbLoginPanelLogin.Text + "'AND password = '" + tbPasswordPanelLogin.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q, connection);
                dataReader = cmd2.ExecuteReader();               
            }

            if (!dataReader.HasRows)
            {
                MessageBox.Show("login or password incorrect");
            }
            else
            {
                MainMenu mm = new MainMenu();
                mm.Login = tbLoginPanelLogin.Text;
                this.Hide();
                mm.Show();
            }
            ////////////////////////////////////////////////      
            connection.Close();
        }
    }
}
