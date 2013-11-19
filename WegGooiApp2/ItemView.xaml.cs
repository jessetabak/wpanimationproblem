using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WegGooiApp2.ViewModels;

namespace WegGooiApp2
{
    public partial class ItemView : UserControl
    {            
        private Storyboard _showStoryboard;
        private Storyboard _hideStoryboard;        

        public ItemView()
        {
            InitializeComponent();
            _showStoryboard = (Storyboard) this.Resources["ShowMenu"];
            _hideStoryboard = (Storyboard) this.Resources["HideMenu"];            
            Debug.WriteLine("ItemView CONSTRUCTED");
        }

        private void Button_Tap(object sender, GestureEventArgs e)
        {
            var button = (Button)sender;
            var viewModelItem = (ItemViewModel)button.Tag;

            viewModelItem.SubMenuIsVisible = !viewModelItem.SubMenuIsVisible;            
        }

        public void MenuEnabled()
        {
            Debug.WriteLine("MENU ENABLED!");
            if (Submenu.Visibility == Visibility.Collapsed)
            {
                _showStoryboard.Begin();
            }
        }

        public void MenuDisabled()
        {
            Debug.WriteLine("MENU DISABLED!");
            if (Submenu.Visibility == Visibility.Visible)
            {
                _hideStoryboard.Begin();
            }
        }        

        private void ThisUserControl_LayoutUpdated(object sender, EventArgs e)
        {
            //Debug.WriteLine("ITEMVIEW LAYOUT UPDATED!");
        }
    }
}
