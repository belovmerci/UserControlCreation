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
    // https://learn.microsoft.com/ru-ru/dotnet/desktop/winforms/controls-design/how-to-create-usercontrol?view=netdesktop-7.0&authuser=0
    public partial class ClearableTextBox : UserControl
    {
        [Browsable(true)]
        public new event EventHandler TextChanged
        {
            add => txtValue.TextChanged += value;
            remove => txtValue.TextChanged -= value;
        }

        [Browsable(true)]
        public new string Text
        {
            get => txtValue.Text;
            set => txtValue.Text = value;
        }

        [Browsable(true)]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
            => Text = "";

        private void ClearableTextBox_Load(object sender, EventArgs e)
        {

        }
        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
