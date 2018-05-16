using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace App1
{
    public partial class HistoricTipController : UITableViewController
    {
       public List<double> Tips { get; set; }

        public HistoricTipController (IntPtr handle) : base (handle)
        {
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return Tips.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            double tip = Tips[indexPath.Row];
            UITableViewCell cell = new UITableViewCell(CoreGraphics.CGRect.Empty);
            cell.TextLabel.Text = tip.ToString();

            return cell;
        }
    }
}