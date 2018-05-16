using System;

using UIKit;
using System.Collections.Generic;
using Foundation;

namespace App1
{
    public partial class ViewController : UIViewController
    {
        List<double> MesTips;

        public ViewController(IntPtr handle) : base(handle)
        {
            MesTips = new List<double>();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        partial void CalculateBtn_TouchUpInside(UIButton sender)
        {
            ResultLabel.ResignFirstResponder();
            double montant = 0;
            double.TryParse(Build.Text, out montant);
            double tipPercent = (10f + (TipPercentSegment.SelectedSegment * 5)) / 100f;
            double tips = montant * tipPercent;
            MesTips.Add(tips);
            ResultLabel.Text = string.Format("le pourboire est de {0:C}", tips);
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            HistoricTipController destTC = segue.DestinationViewController as HistoricTipController;
            destTC.Tips = MesTips;
        }

    }
}