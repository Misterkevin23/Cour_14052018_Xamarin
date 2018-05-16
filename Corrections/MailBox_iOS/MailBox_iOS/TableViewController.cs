using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace MailBox_iOS
{
    public partial class TableViewController : UITableViewController
    {
        EmailServer emailServer;

        public TableViewController (IntPtr handle) : base (handle)
        {
            emailServer = new EmailServer();
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return emailServer.Email.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Subtitle,null);
            EmailItem item = emailServer.Email[indexPath.Row];

            cell.TextLabel.Font = UIFont.FromName("Helvetica", 16);
            
            cell.TextLabel.Text = item.Subject;
            cell.DetailTextLabel.Text = item.Body;
            cell.ImageView.Image = item.GetImage();
            //cell.TextLabel.Text = emailServer.Email[indexPath.Row].Subject;

            cell.Accessory = UITableViewCellAccessory.DetailButton;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            EmailItem item = emailServer.Email[indexPath.Row];
            
            UIAlertController popup = UIAlertController.Create(item.Subject, item.ToString(), UIAlertControllerStyle.Alert);
            popup.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(popup, true, null);
        }

        public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath)
        {
            UIStoryboard sb = UIStoryboard.FromName("Main",null);
            MailController mc= sb.InstantiateViewController("MailController") as MailController;
            mc.item = emailServer.Email[indexPath.Row];
            ShowViewController(mc, null);
        }
    }
}