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
    public partial class MainMenu : Form
    {
        public string Login { get; set; }
        static string connectionString = "Data Source=DESKTOP-7KACT8E\\SQLEXPRESS;Initial Catalog=ChatITochka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
        }

        private void btnHidePanel_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            panelChat.Visible = false;
            lbLogin.Text = Login;

            byte[] getImage = new byte[0];
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Login WHERE login = '" + lbLogin.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lbLogin.Text = dataReader[0].ToString();
                byte[] images = (byte[])dataReader["image"];
                if (images == null)
                {
                    pbAva.Image = null;
                }
                else
                {
                    MemoryStream me = new MemoryStream(images);
                    pbAva.Image = Image.FromStream(me);
                }
            }
            con.Close();
        }

        private void FindPersons()
        {
            //char[] login = new char[rtbFind.Text.Length - 1];   
            //for(int i = 0; i < rtbFind.Text.Length - 1; i++)
            //{
            //    if (rtbFind.Text[i] != '\n') login[i] = rtbFind.Text[i];
            //}
            SqlDataAdapter adapter;
            //adapter = new SqlDataAdapter("select login from Login WHERE login = '" + login + "'", connectionString);
            adapter = new SqlDataAdapter("select login from Login", connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        cbChats.Items.Add(row["login"].ToString());
                    }
                }
            }
        }

        private void rtbFind_TextChanged(object sender, EventArgs e)
        {
            if (rtbFind.Text[rtbFind.Text.Length - 1] == '\n')
            {
                cbChats.Items.Clear();
                FindPersons();
                rtbFind.Clear();
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void rtbMessageText_TextChanged(object sender, EventArgs e)
        {
            if (rtbMessageText.Text[rtbMessageText.Text.Length - 1] == '\n')
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "insert into Chat(userone, usertwo, message)values(@userone,@usertwo,@message)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userone", lbLogin.Text);
                cmd.Parameters.AddWithValue("@usertwo", lbLoginPanelChat.Text);
                cmd.Parameters.AddWithValue("@message", rtbMessageText.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Chat();
                rtbMessageText.Clear();
            }
        }

        private void Chat()
        {
            flpPanelChatMessage.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Chat", connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (table != null)
                {
                    Massege[] masseges = new Massege[table.Rows.Count];
                    UserMessage[] userMessages = new UserMessage[table.Rows.Count];

                    int i = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        if (lbLogin.Text == row["userone"].ToString() && lbLoginPanelChat.Text == row["usertwo"].ToString())
                        {
                            masseges[i] = new Massege();
                            masseges[i].Dock = DockStyle.Top;
                            masseges[i].BringToFront();
                            masseges[i].Title = row["message"].ToString();

                            flpPanelChatMessage.Controls.Add(masseges[i]);
                            flpPanelChatMessage.ScrollControlIntoView(masseges[i]);
                        }
                        else if (lbLogin.Text == row["usertwo"].ToString() && lbLoginPanelChat.Text == row["userone"].ToString())
                        {
                            userMessages[i] = new UserMessage();
                            userMessages[i].Dock = DockStyle.Top;
                            userMessages[i].BringToFront();
                            userMessages[i].Title = row["message"].ToString();
                            userMessages[i].Ava = pbAvaPanelChat.Image;
                            flpPanelChatMessage.Controls.Add(userMessages[i]);
                            flpPanelChatMessage.ScrollControlIntoView(userMessages[i]);
                        }
                    }
                }
            }
        }

        private void btnLeaveFromChat_Click(object sender, EventArgs e)
        {
            panelChat.Visible = false;
        }

        private void cbChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelChat.Visible = true;
            lbLoginPanelChat.Text = cbChats.SelectedItem.ToString();

            //SqlConnection con = new SqlConnection(connectionString);
            //string query = "select image from Login WHERE login = '" + lbLoginPanelChat.Text + "'";
            //con.Open();
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    byte image = (byte)reader[0];
            //    if (image != null)
            //    {
            //        MemoryStream me = new MemoryStream(image);
            //        pbAvaPanelChat.Image = Image.FromStream(me);
            //    }
            //    else pbAvaPanelChat = null;
            //}
            //con.Close();

            Chat();
        }
    }
}
