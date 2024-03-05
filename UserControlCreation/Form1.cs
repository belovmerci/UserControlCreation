using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void clearableTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) =>
           UpdateNameLabel();

        private void ctlFirstName_TextChanged(object sender, EventArgs e) =>
           UpdateNameLabel();

        private void ctlLastName_TextChanged(object sender, EventArgs e) =>
           UpdateNameLabel();

        private void UpdateNameLabel()
        {
           if (string.IsNullOrWhiteSpace(ctlFirstName.Text) || string.IsNullOrWhiteSpace(ctlLastName.Text))
               lblFullName.Text = "Please fill out both the first name and the last name.";
           else
               lblFullName.Text = $"Hello {ctlFirstName.Text} {ctlLastName.Text}, I hope you're having a good day.";
        }

    }
}
