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
    public partial class var3 : Form
    {
        public var3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var1 newForm = new var1();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            video newForm = new video();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var4 newForm = new var4();
            newForm.Show();
            this.Hide();
        }
    }
}
