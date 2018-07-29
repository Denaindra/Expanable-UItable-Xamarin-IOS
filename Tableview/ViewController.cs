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
                { "Faces", new List<string> { "\ud83d\ude01","\ud83d\ude02","\ud83d\ude03","\ud83d\ude21"} },
                { "Animals", new List<string> { "\ud83d\udc2f", "\ud83d\udc30", "\ud83d\udc2e", "\ud83d\udc37" } },
                { "Weapons", new List<string> { "\ud83d\udd28","\ud83d\udd2a","\ud83d\udd2b" } },
                { "Food", new List<string> { "\ud83c\udf53","\ud83c\udf52","\ud83c\udf4f" } },
                { "Weather", new List<string> { "\ud83c\udf24","⛅","\ud83c\udf25","\ud83c\udf26",} }
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
