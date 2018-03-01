// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TourStopAppForiOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calcTourDurationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel displayDurationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableView1 { get; set; }

        [Action ("CalcTourDurationButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CalcTourDurationButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (calcTourDurationButton != null) {
                calcTourDurationButton.Dispose ();
                calcTourDurationButton = null;
            }

            if (displayDurationLabel != null) {
                displayDurationLabel.Dispose ();
                displayDurationLabel = null;
            }

            if (TableView1 != null) {
                TableView1.Dispose ();
                TableView1 = null;
            }
        }
    }
}