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
    [Register ("TableViewCell")]
    partial class TableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cellLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cellLabel != null) {
                cellLabel.Dispose ();
                cellLabel = null;
            }
        }
    }
}