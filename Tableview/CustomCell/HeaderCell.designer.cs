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
        UIKit.UILabel headerCell { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (headerCell != null) {
                headerCell.Dispose ();
                headerCell = null;
            }
        }
    }
}