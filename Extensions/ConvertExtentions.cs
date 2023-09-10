using BookInventory.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookInventory.Extensions
{
    public static class ConvertExtentions
    {
        public static List<SelectListItem> ConvertToSelectList<T>(this IEnumerable<T> collection, int selectedValue) where T : IPrimaryProperties
        {
            return (from item in collection
                    select new SelectListItem
                    {
                        Text = item.DescriptiveName,
                        Value = item.Id.ToString(),
                        Selected = (item.Id == selectedValue)
                    }
                ).ToList();
        }
    }
}
