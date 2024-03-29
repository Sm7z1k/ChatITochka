using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ChatITochka
{
    internal class Login
    {
        ConnectionToSQL connectionToSQL = new ConnectionToSQL();
        string login;
        string email;
        string password;
        string confirmPassword;
        PictureBox image; 
        Login(TextBox login, TextBox email, TextBox password, TextBox confirmpassword, PictureBox image)
        {
            this.login = login.Text;
            this.email = email.Text;
            this.password = password.Text;
            this.confirmPassword = confirmpassword.Text;
            this.image = image;
        }
        void Registration()
        {
            string query = "insert into Login(login,email,password,confirmpassword,image)values(@login,@email,@password,@confirmpassword,@image)";
            SqlCommand cmd = new SqlCommand(query, connectionToSQL.Connection);
            MemoryStream me = new MemoryStream();
            
        }
    }
}
