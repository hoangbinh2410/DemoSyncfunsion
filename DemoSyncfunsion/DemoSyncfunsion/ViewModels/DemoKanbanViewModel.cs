using DemoSyncfunsion.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoSyncfunsion.ViewModels
{
    public class DemoKanbanViewModel : ViewModelBase
    {
        private List<Card> _cards;
        public List<Card> Cards
        {
            get { return _cards; }
            set { SetProperty(ref _cards, value); }
        }
        private string _descriptopn;
        public string Description
        {
            get { return _descriptopn; }
            set { SetProperty(ref _descriptopn, value); }
        }
        private string _imageurl;
        public string ImageURL
        {
            get { return _imageurl; }
            set { SetProperty(ref _imageurl, value); }
        }
        private List<object> _kanban1;
        public List<object> Kanban1
        {
            get { return _kanban1; }
            set { SetProperty(ref _kanban1, value); }
        }
        public DemoKanbanViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Kanban1 = new List<object>() { "Open" };
            Cards = new List<Card>()
            {
                new Card{ID = 1,
            Title = "iOS - 1002",
            ImageURL = "girl2",
            Category = "Open",
            Description = "Analyze customer requirements",
            ColorKey = "Red",
            Tags = new string[] { "Incident", "Customer" }},
                new Card{ID = 6,
            Title = "Xamarin - 4576",
            ImageURL = "girl2",
            Category = "Open",
            Description = "Show the retrieved data from the server in grid control",
            ColorKey = "Green",
            Tags = new string[] { "Story", "Customer" }},
                new Card{ID = 13,
            Title = "UWP - 13",
            ImageURL = "girl2",
            Category = "In Progress",
            Description = "Add responsive support to application",
            ColorKey = "Brown",
            Tags = new string[] { "Story", "Customer" }},
                new Card{ID = 2543,
            Title = "People_Circle4.png",
            Category = "Code Review",
            ImageURL = "girl2",
            Description = "Check login page validation",
            ColorKey = "Brown",
            Tags = new string[] { "Story", "Customer" }},
            };
        }
    }
}
