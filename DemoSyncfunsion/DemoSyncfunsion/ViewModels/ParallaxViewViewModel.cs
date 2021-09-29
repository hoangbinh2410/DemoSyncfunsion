using DemoSyncfunsion.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoSyncfunsion.ViewModels
{
    public class ParallaxViewViewModel : ViewModelBase
    {
        private List<Items> _items;
        public List<Items> Item
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private string _author;
        public string Author
        {
            get { return _author; }
            set { SetProperty(ref _author, value); }
        }
        public ParallaxViewViewModel(INavigationService navigationService)
            : base(navigationService)
        {

            Item = new List<Items>()
            {
                new Items() { Name = "Thriller", Author = "Michael Jackson" },
                new Items() { Name = "Like a Prayer", Author = "Madonna" },
                new Items() { Name = "When Doves Cry", Author = "Prince" },
                new Items() { Name = "I Wanna Dance", Author = "Whitney Houston" },
                new Items() { Name = "It’s Gonna Be Me", Author = "N Sync"},
                new Items() { Name = "Everybody", Author = "Backstreet Boys"},
                new Items() { Name = "Rolling in the Deep", Author = "Adele" },
                new Items() { Name = "Don’t Stop Believing", Author = "Journey" },
                new Items() { Name = "Billie Jean", Author = "Michael Jackson" },
                new Items() { Name = "Firework", Author = "Katy Perry"},
                new Items() { Name = "Thriller", Author = "Michael Jackson" },
                new Items() { Name = "Like a Prayer", Author = "Madonna" },
                new Items() { Name = "When Doves Cry", Author = "Prince" },
                new Items() { Name = "I Wanna Dance", Author = "Whitney Houston" },
                new Items() { Name = "It’s Gonna Be Me", Author = "N Sync" },
                new Items() { Name = "Everybody", Author = "Backstreet Boys" },
                new Items() { Name = "Rolling in the Deep", Author = "Adele" },
                new Items() { Name = "Don’t Stop Believing", Author = "Journey"},
            };
        }
    }
}
