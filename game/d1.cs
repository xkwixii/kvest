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
    public partial class d1 : Form
    {
        public d1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var1 newForm = new var1();
            newForm.Show();
            this.Hide();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            var3 newForm = new var3();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var4 newForm = new var4();
            newForm.Show();
            this.Hide();
        }
    }
}
