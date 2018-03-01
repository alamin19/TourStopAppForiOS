using System;

using UIKit;

namespace TourStopAppForiOS
{
    public partial class ViewController : UIViewController
    {
        private Foundation.NSUrl url;
        private const int TimePerStop = 45; // minutes

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TableView1.Source = new TourStopsTableSource();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void CalcTourDurationButton_TouchUpInside(UIButton sender)
        {
            var numberOfStops = TableView1.NumberOfRowsInSection(0);
            var duration = new TourLib.Duration();
            double result = duration.CalculateTourDuration(numberOfStops: (int)numberOfStops, speedRatio: 1.2);
            displayDurationLabel.Text = String.Format("{0} minutes", result);
        }

        private void CallNumber(string phoneNumber)
        {
            url = new Foundation.NSUrl("tel:" + phoneNumber);
            var alert = UIAlertController.Create("Alert", "Simulated call to  " + phoneNumber, UIAlertControllerStyle.Alert);

            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, MakeCallAction));
            alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(alert, true, null);
        }

        private void MakeCallAction(UIAlertAction action)
        {
            bool wasSuccessful = UIApplication.SharedApplication.OpenUrl(url);
        }

        private double CalculateTourDuration(int numberOfStops, double speedRatio)
        {
            var temp = numberOfStops;
            var duration = (numberOfStops * TimePerStop) * speedRatio;
            return duration;
        }
    }
}