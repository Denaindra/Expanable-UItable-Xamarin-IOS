using System;
using System.Collections.Generic;

namespace Tableview.Model
{
    public class ExpandableListModel<T> : List<T>
    {
        public string Title { get; set; }
        public ExpandableListModel(IEnumerable<T> collection) : base(collection) { }
        public ExpandableListModel() : base() { }
    }
}
