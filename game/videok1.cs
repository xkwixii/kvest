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
    public partial class videok1 : Form
    {
        public videok1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
    }
}
