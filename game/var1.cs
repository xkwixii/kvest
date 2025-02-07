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
    public partial class var1 : Form
    {
        public var1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

             Image backgroundImage = Image.FromFile("3.jpg");
            this.BackgroundImage = backgroundImage;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

     

        private void button3_Click(object sender, EventArgs e)
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
