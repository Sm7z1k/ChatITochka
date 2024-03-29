using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatITochka
{
    public partial class UserMessage : UserControl
    {
        public UserMessage()
        {
            InitializeComponent();
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; lbText.Text = value; AddHeight(); }
        }

        private Image ava;

        public Image Ava
        {
            get { return ava; }
            set { ava = value; pbAva.Image = value; AddHeight(); }
        }

        void AddHeight()
        {
            UserMessage massege = new UserMessage();
            massege.BringToFront();
            lbText.Height = Uilist.GetTextHeight(lbText) + 10;
            massege.Height = massege.Top + massege.Height;
            this.Height = massege.Bottom + 10;
        }        
        private void UserMessage_Load(object sender, EventArgs e)
        {
            AddHeight();
        }
    }
}
