using Foundation;
using System;
using UIKit;

namespace MailBox_iOS
{
    public partial class MailController : UIViewController
    {
        public EmailItem item;

        public MailController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            if(item!=null)
            {
                ResumeLabel.Text = item.ToString();
                bodyLabel.Text = item.Body;
            }
        }
    }
}