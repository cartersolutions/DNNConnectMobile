using System.Threading.Tasks;

using Xamarin.Forms;

using DNNConnect.Repositories;

namespace DNNConnect.Views
{
    public partial class Items : ContentPage
    {
        public Items()
        {
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Exit",
                Command = new Command((cmd) => {
                    App.SetMainPage(new Login(), false);
                })
            });

            InitializeComponent();

            this.PopulateItems();

            this.itemsView.IsPullToRefreshEnabled = true;
            this.itemsView.Refreshing += ItemsView_Refreshing;
        }

        private void ItemsView_Refreshing(object sender, System.EventArgs e)
        {
            this.PopulateItems();

            this.itemsView.EndRefresh();
        }

        public void PopulateItems()
        {
            var items = Task.Run(() => {
                return ItemRepository.GetItemsAsync();
            }).GetAwaiter().GetResult();

            if (items.Count > 0)
            {
                this.itemsView.ItemsSource = items;
            }
        }
    }
}
