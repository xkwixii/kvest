﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class videok2 : Form
    {
        public videok2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Image backgroundImage = Image.FromFile("7.jpg");
            this.BackgroundImage = backgroundImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form form in openForms)
            {
                form.Close();
            }

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
