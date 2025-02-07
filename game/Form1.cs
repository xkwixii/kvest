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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Image backgroundImage = Image.FromFile("menu.jpg");
            this.BackgroundImage = backgroundImage;
        }

        private void exitgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            opisanie newForm = new opisanie();    
            newForm.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
