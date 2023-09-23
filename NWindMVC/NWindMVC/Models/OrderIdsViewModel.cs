using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVC.Models {

    public class OrderIdsViewModel
    {
        public int Id { get; set; }
        public List<SelectListItem> OrderIdSelectedList;
        public OrderIdsViewModel()
            {
            }   
        public OrderIdsViewModel(List<int> orderIds) 
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var obj in orderIds) 
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{obj}", Value = $"{obj}" });
            }
        }
    }
}
