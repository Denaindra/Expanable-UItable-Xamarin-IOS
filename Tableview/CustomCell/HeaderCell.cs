using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Tableview.CustomCell
{
    public partial class HeaderCell : UITableViewHeaderFooterView
    {
        public static readonly NSString Key = new NSString("HeaderCell");
        public static readonly UINib Nib;

        static HeaderCell()
        {
            Nib = UINib.FromName("HeaderCell", NSBundle.MainBundle);
        
        }

        protected HeaderCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }


        public void SetHeaderText(string title,bool isexpandable){
            headerCell.Text = title;
            if(isexpandable)
            {
                orderText.Text = "apple";
                headerArrow.Image = UIImage.FromBundle("uparrow");
            }else{
                headerArrow.Image = UIImage.FromBundle("downarrow");
            }
        }

        public void UpdateTextAnimation(bool isExpanded)
        {
            if(isExpanded)
            {
               // orderText.Frame = new CGRect(0, 0, 0, 0);
            }
            else{
                
            }
        }
    }
}
