using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Adventure.Helper
{
    public class ObservableCollectionWithItemNotify<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        public ObservableCollectionWithItemNotify()
        {
            CollectionChanged += Items_CollectionChanged;
        }

        public ObservableCollectionWithItemNotify(IEnumerable<T> collection)
            : base(collection)
        {
            CollectionChanged += Items_CollectionChanged;

            foreach (INotifyPropertyChanged item in collection)
                item.PropertyChanged += Item_PropertyChanged;
        }

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e != null)
            {
                if (e.OldItems != null)
                    foreach (INotifyPropertyChanged item in e.OldItems)
                        item.PropertyChanged -= Item_PropertyChanged;

                if (e.NewItems != null)
                    foreach (INotifyPropertyChanged item in e.NewItems)
                        item.PropertyChanged += Item_PropertyChanged;
            }
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var replace = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, sender, sender);

            this.OnCollectionChanged(replace);
        }
    }
}