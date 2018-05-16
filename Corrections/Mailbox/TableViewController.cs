using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace Mailbox
{
	partial class TableViewController : UITableViewController
	{
        EmailServer emailServer = new EmailServer();

		public TableViewController (IntPtr handle) : base (handle)
		{
		}

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return emailServer.Email.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Default, null);
            var item = emailServer.Email[indexPath.Row];

            cell.TextLabel.Text = item.Subject;
            cell.TextLabel.Font = UIFont.FromName("Helvetica", 16);
            cell.ImageView.Image = item.GetImage();
            cell.Accessory = UITableViewCellAccessory.DetailButton;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            EmailItem item = emailServer.Email[indexPath.Row];

            var alert = UIAlertController.Create(item.Subject, item.ToString(),UIAlertControllerStyle.ActionSheet);
            alert.AddAction(UIAlertAction.Create("ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }
    }
}
