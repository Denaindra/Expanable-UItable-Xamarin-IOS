﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using Tableview.CustomCell;
using Tableview.Model;
using UIKit;

namespace Tableview
{
    public class TableSource : UITableViewSource
    {
        List<ExpandableListModel<String>> TableItems;
        private bool[] _isSectionOpen;
        private UITableView tableView;
        private int expandIndex = -1;
     
        public TableSource(List<ExpandableListModel<String>> items, UITableView tableView)
        {
            TableItems = items;
            this.tableView = tableView;
            _isSectionOpen = new bool[items.Count];
            tableView.RegisterNibForCellReuse(UINib.FromName(TableViewCell.Key, NSBundle.MainBundle), TableViewCell.Key);
            tableView.RegisterNibForHeaderFooterViewReuse(UINib.FromName(HeaderCell.Key, NSBundle.MainBundle), HeaderCell.Key);
        }
        private void HeaderClick(object sender, EventArgs e)
        {
            var button = sender as UIButton;
            var section = button.Tag;
            _isSectionOpen[section] = !_isSectionOpen[section];
            expandIndex = (int)section;
            tableView.ReloadData();
            // Animate the section cells
            var paths = new NSIndexPath[RowsInSection(tableView, section)];
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = NSIndexPath.FromItemSection(i, section);
            }
            tableView.EndUpdates();
            tableView.ReloadRows(paths, UITableViewRowAnimation.Fade);
           
        
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return TableItems.Count;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _isSectionOpen[section] ? TableItems[(int)section].Count : 0;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            //set header title and template with click event
            HeaderCell header = tableView.DequeueReusableHeaderFooterView(HeaderCell.Key) as HeaderCell;
            if( _isSectionOpen[section] == true)
            {
                header.SetHeaderText(((ExpandableListModel<String>)TableItems[(int)section]).Title,true);
            }else{
                header.SetHeaderText(((ExpandableListModel<String>)TableItems[(int)section]).Title, false);
            }

          
            foreach (var view in header.Subviews)
            {
                if (view is UIButton)
                {
                    view.RemoveFromSuperview();
                }
            }
            var hiddenButton = CreateHiddenHeaderButton(header.Bounds, section);
            header.AddSubview(hiddenButton);
            return header;
        }
        private UIButton CreateHiddenHeaderButton(CGRect frame, nint tag)
        {
            var button = new UIButton(frame);
            button.Tag = tag;
            button.TouchUpInside += HeaderClick;
            return button;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(TableViewCell.Key, indexPath) as TableViewCell;

            var rowData = TableItems[indexPath.Section][indexPath.Row] as string;
            if (rowData != null)
            {
                cell.SetCelletails(rowData);
            }

            return cell;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cell = tableView.CellAt(indexPath) as TableViewCell;
        }

       
    }
}