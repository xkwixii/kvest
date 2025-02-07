using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class opisanie : Form
    {
        public opisanie()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Image backgroundImage = Image.FromFile("2.jpg");
            this.BackgroundImage = backgroundImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1 newForm = new d1();
            newForm.Show();
            this.Hide();
        }
    }
}
