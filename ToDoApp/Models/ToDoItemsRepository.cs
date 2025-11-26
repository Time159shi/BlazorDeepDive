using ToDoApp.Components.Pages;
using System.Runtime.CompilerServices;

namespace ToDoApp.Models
{
    public static class ToDoItemsRepository
    {
        private static List<ToDoItem> items = new List<ToDoItem>()
        {
            new ToDoItem{Id=1,Name="Item1"},
            new ToDoItem{Id=2,Name="Item2"},
            new ToDoItem{Id=3,Name="Item3"},
            new ToDoItem{Id=4,Name="Item4"}

        };

        public static void AddItem(ToDoItem item)
        {
            if (items.Count > 0)
            {
                var maxId = items.Max(s => s.Id);
                item.Id = maxId + 1;
                items.Add(item);
            }
            else
            {
                item.Id = 1;
                items.Add(item);
            }

        }
        public static List<ToDoItem> GetItems()
        {
            var srtedItems = items.
                OrderBy(item => item.IsCompleted)
                .ThenByDescending(item => item.Id)
                .ToList();
            return srtedItems;
        }
        public static ToDoItem? GetItemById(int id)
        {
            var item = items.FirstOrDefault(item => item.Id == id);
            if (item != null)
            {
                return new ToDoItem
                {
                    Id = item.Id,
                    Name = item.Name
                };
            }
            return null;
        }

        public static void UpdateItems(int itemId, ToDoItem item)
        {
            if (itemId != item.Id) return;

            var itemToUpdate = items.FirstOrDefault(s => s.Id == itemId);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
            }
        }

        public static void DeleteItem(int itemId)
        {
            var item = items.FirstOrDefault(s => s.Id == itemId);
            if (item != null)
            {
                items.Remove(item);
            }
        }
        public static List<ToDoItem> SearchItems(string itemFilter)
        {
            return items.Where(s => s.Name.Contains(itemFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
