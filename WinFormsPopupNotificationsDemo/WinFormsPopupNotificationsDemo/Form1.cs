using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WinFormsPopupNotificationsDemo
{
    /*
     Install nuget package Tulpep.NotificationWindow
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotificationDemo_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier()
            {
                TitleText = "Popup window",
                ContentText = "Notification test",
                Image = System.Drawing.SystemIcons.Information.ToBitmap(),
                ImagePadding = new Padding(5),
                Size = new Size(200, 100),
                Delay = 1500
            };

            popup.Popup();
        }
    }
}
