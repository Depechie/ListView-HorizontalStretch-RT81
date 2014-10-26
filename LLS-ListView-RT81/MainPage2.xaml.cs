using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556
using LLS_ListView_RT81.Models;

namespace LLS_ListView_RT81
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage2 : Page
    {
        public MainPage2()
        {
            this.InitializeComponent();

            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

            var grouped = from item in AddressBook.GetDummyData()
                          group item by item.Address
                              into groupedCollection
                              orderby groupedCollection.Key
                              select new GroupedCollection<AddressBook>(groupedCollection);

            ((CollectionViewSource)Resources["AddressGroups"]).Source = grouped;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
