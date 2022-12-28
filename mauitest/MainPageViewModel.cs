using System;
using System.Collections.ObjectModel;

namespace mauitest
{
	public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<ItemSupport> _favouriteMenuItems = new ObservableCollection<ItemSupport>();
        public ObservableCollection<ItemSupport> FavouriteMenuItems
        {
            get { return _favouriteMenuItems; }
            set { SetProperty(ref _favouriteMenuItems, value); }
        }
        public MainPageViewModel()
		{
            FavouriteMenuItems.Add(new ItemSupport()
            {
                FeaturesItem = new List<UserMenu>()
                {
                    new UserMenu()
                    {
                        MenuName = "001",
                        ImageName = "dotnet_bot.png"
                    },
                    new UserMenu()
                    {
                        MenuName = "002",
                        ImageName = "dotnet_bot.png"
                    },
                    new UserMenu()
                    {
                        MenuName = "003",
                        ImageName = "dotnet_bot.png"
                    }
                }
            });

            FavouriteMenuItems.Add(new ItemSupport()
            {
                FeaturesItem = new List<UserMenu>()
                {
                    new UserMenu()
                    {
                        MenuName = "004",
                        ImageName = "dotnet_bot.png"
                    },
                    new UserMenu()
                    {
                        MenuName = "005",
                        ImageName = "dotnet_bot.png"
                    },
                    new UserMenu()
                    {
                        MenuName = "006",
                        ImageName = "dotnet_bot.png"
                    }
                }
            });

        }
	}
    public class ItemSupport
    {
        public List<UserMenu> FeaturesItem { get; set; }
    }
    public class UserMenu
    {
        public string MenuName { get; set; }
        public string ImageName { get; set; }
    }
}

