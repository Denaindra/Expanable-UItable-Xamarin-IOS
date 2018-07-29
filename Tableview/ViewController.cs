using System;
using System.Collections.Generic;
using Foundation;
using Tableview.Model;
using UIKit;

namespace Tableview
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var DataDic = new Dictionary<string, List<string>>
            {
                { "ABC_123456789", new List<string> { "Apple","Orange","Grapes","Mango"} },
                { "ASD_45678923456", new List<string> { "January", "February", "March", "Aprial" } },
                { "PLM_45676787654", new List<string> { "VS","Ecipls","NetBeans" } },
                { "UHB_12346789890", new List<string> { "TOYOTA","Mazda","Hhunda" } },
                { "YGV_5678&567898", new List<string> { "Java","C#","C++","Swift",} }
            };

           
            var list = new List<ExpandableListModel<string>>();
            foreach (var section in DataDic)
            {
                var sectionData = new ExpandableListModel<string>()
                {
                    Title = section.Key
                };
                foreach (var row in section.Value)
                {
                    sectionData.Add(row);
                }

                list.Add(sectionData);
            }

            TableView.Source = new TableSource(list, TableView);
            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.SectionHeaderHeight = 80f;

        }
    }
}
