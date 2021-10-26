using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class MyMessageBox : Form
    {
        private int _secondsToAutoClose;

        /// <summary>
        /// Auto-close form.
        /// </summary>
        /// <param name="MessageBoxTitle"></param>
        /// <param name="MessageText"></param>
        /// <param name="AutoCloseSpan"></param>
        public MyMessageBox(string MessageBoxTitle, string MessageText, int SecondsToAutoClose)
        {
            InitializeComponent();
            this.Text = MessageBoxTitle;
            Message_lbl.Text = MessageText;
            _secondsToAutoClose = SecondsToAutoClose;
            pictureBox.Image = System.Drawing.SystemIcons.Information.ToBitmap();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void MyMessageBox_Activated(object sender, EventArgs e)
        {
            await InitializeAutoCloseAsync();
        }

        private async Task InitializeAutoCloseAsync()
        {
            while (_secondsToAutoClose > 0)
            {
                Ok_btn.Text = $"Ok...{_secondsToAutoClose}";
                _secondsToAutoClose--;
                await Task.Delay(1000);
            }

            this.Close();
        }


    }
}
