using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class MyMessageBox : Form
    {
        private TimeSpan timer;
        public event Action MessageBoxShown;

        /// <summary>
        /// To activate auto close, subscribe MessageBoxShown event,
        /// on subscription call InitializeAutoCloseAsync()
        /// ex.: myMessageBox.MessageBoxShown += async () => await myMessageBox.InitializeAutoCloseAsync();
        /// </summary>
        /// <param name="MessageBoxTitle"></param>
        /// <param name="MessageText"></param>
        /// <param name="AutoCloseSpan"></param>
        public MyMessageBox(string MessageBoxTitle, string MessageText, int SecondsToAutoClose)
        {
            InitializeComponent();
            this.Text = MessageBoxTitle;
            Message_lbl.Text = MessageText;
            timer = new TimeSpan().Add(TimeSpan.FromSeconds(SecondsToAutoClose));
            pictureBox.Image = System.Drawing.SystemIcons.Information.ToBitmap();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyMessageBox_Shown(object sender, EventArgs e)
        {
            MessageBoxShown?.Invoke();
        }

        public async Task InitializeAutoCloseAsync()
        {
            while (timer > new TimeSpan(0, 0, 0))
            {
                Ok_btn.Text = $"Ok...{timer.Seconds}";
                timer = timer.Add(TimeSpan.FromSeconds(-1));
                await Task.Delay(1000);
            }

            this.Close();
        }
    }
}
