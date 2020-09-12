using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP44.Model
{
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category= "Financial", Headline="Lorem ipum", Subhead="a", DateLine="a", Image="a" });
            items.Add(new NewsItem() { Id = 1, Category= "Financial", Headline="Lorem ipum", Subhead="a", DateLine="a", Image="a" });
            items.Add(new NewsItem() { Id = 1, Category= "Financial", Headline="Lorem ipum", Subhead="a", DateLine="a", Image="a" });
            items.Add(new NewsItem() { Id = 1, Category= "Financial", Headline="Lorem ipum", Subhead="a", DateLine="a", Image="a" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipum", Subhead = "a", DateLine = "a", Image = "a" });

            return items;
        }
    }
}
