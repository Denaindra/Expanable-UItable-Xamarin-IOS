// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Tableview.CustomCell
{
    [Register ("HeaderCell")]
    partial class HeaderCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView headerArrow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headerCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel orderNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel orderText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel processNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel processText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel remainingText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel remainInNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel shippedNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel shippedText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (headerArrow != null) {
                headerArrow.Dispose ();
                headerArrow = null;
            }

            if (headerCell != null) {
                headerCell.Dispose ();
                headerCell = null;
            }

            if (orderNum != null) {
                orderNum.Dispose ();
                orderNum = null;
            }

            if (orderText != null) {
                orderText.Dispose ();
                orderText = null;
            }

            if (processNum != null) {
                processNum.Dispose ();
                processNum = null;
            }

            if (processText != null) {
                processText.Dispose ();
                processText = null;
            }

            if (remainingText != null) {
                remainingText.Dispose ();
                remainingText = null;
            }

            if (remainInNum != null) {
                remainInNum.Dispose ();
                remainInNum = null;
            }

            if (shippedNum != null) {
                shippedNum.Dispose ();
                shippedNum = null;
            }

            if (shippedText != null) {
                shippedText.Dispose ();
                shippedText = null;
            }
        }
    }
}