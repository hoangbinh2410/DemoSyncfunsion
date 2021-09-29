using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSyncfunsion.Model
{
    public class Card
    {
        public int  ID { get; set; }
        public  string  Title { get; set; }
        public string ImageURL { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ColorKey { get; set; }
        public string[] Tags { get; set; }
    }
}
