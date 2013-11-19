using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WegGooiApp2.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private bool _subMenuIsVisible;
        public bool SubMenuIsVisible
        {
            get { return _subMenuIsVisible; }
            set
            {
                _subMenuIsVisible = value;
                NotifyPropertyChanged("SubMenuIsVisible");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}