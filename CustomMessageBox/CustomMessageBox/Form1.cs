using System;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Demo_btn_Click(object sender, EventArgs e)
        {
            MyMessageBox myMessageBox = new MyMessageBox("Test", "Message text", new TimeSpan(0,0,3));
            myMessageBox.Show();
            myMessageBox.MessageBoxShown += async () => await myMessageBox.InitializeAutoCloseAsync();
        }
    }
}
