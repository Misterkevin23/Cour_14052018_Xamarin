using Foundation;
using System;
using UIKit;

namespace App1
{
    public partial class TableViewController : UITableViewController
    {
        EmailServer emailServer = new EmailServer();

        public TableViewController(IntPtr handle) : base(handle)
        {
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return emailServer.Email.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell(CoreGraphics.CGRect.Empty);
            cell.TextLabel.Text = emailServer.Email[indexPath.Row].Subject;
            return base.GetCell(tableView, indexPath);
        }
    }
}