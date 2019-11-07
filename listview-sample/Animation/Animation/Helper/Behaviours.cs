using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Animation
{
    [Preserve(AllMembers = true)]
    public class Behaviours : Behavior<ContentPage>
    {
        private SfListView listView;
        private SearchBar searchBar = null;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            listView = bindable.FindByName<SfListView>("listView");
            listView.ItemGenerator = new ItemGeneratorExt(listView);
            searchBar = bindable.FindByName<SearchBar>("filterText");
            searchBar.TextChanged += SearchBar_TextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {            
            searchBar.TextChanged -= SearchBar_TextChanged;
            listView = null;
            searchBar = null;
            base.OnDetachingFrom(bindable);
        }

        #region Private Methods
        private bool FilterContacts(object obj)
        {
            if (searchBar == null || searchBar.Text == null)
                return true;

            var contacts = obj as Contacts;
            if (contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower())
                || contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower()))
                return true;
            else
                return false;
        }

        #endregion

        #region CallBacks

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchBar = (sender as SearchBar);
            if (listView.DataSource != null)
            {
                this.listView.DataSource.Filter = FilterContacts;
                this.listView.DataSource.RefreshFilter();
            }
        }
        #endregion

    }

    public class ItemGeneratorExt : ItemGenerator
    {        
        public ItemGeneratorExt(SfListView listview) : base(listview)
        {
            
        }
        protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
                return new ListViewItemExt();
            return base.OnCreateListViewItem(itemIndex, type, data);
        }
    }
    public class ListViewItemExt : ListViewItem
    {        
        public ListViewItemExt()
        {            
        }
        protected override void OnItemAppearing()
        {
           this.Opacity = 0;
            this.FadeTo(1, 400, Easing.SinInOut);
            base.OnItemAppearing();
        }       
    }
}
