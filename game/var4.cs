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
    public partial class var4 : Form
    {
        public var4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ubors newForm = new ubors();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            video newForm = new video();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var3 newForm = new var3();
            newForm.Show();
            this.Hide();
        }
    }
}
