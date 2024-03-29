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
    public partial class Massege : UserControl
    {
        public Massege()
        {
            InitializeComponent();
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; lbText.Text = value; AddHeight(); }
        }

        void AddHeight()
        {
            Massege massege = new Massege();
            massege.BringToFront();
            lbText.Height = Uilist.GetTextHeight(lbText) + 10;
            massege.Height = massege.Top + massege.Height;
            this.Height = massege.Bottom + 10;
        }

        private void Massege_Load(object sender, EventArgs e)
        {
            AddHeight();
        }
    }
}
