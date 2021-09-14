using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tour_de_merch.Pages.Items
{
    public class CreateItemModel : PageModel
    {
        //ref
        private IItemRepository _itemRepo;
        public Dictionary<int, Item> Items;
        [BindProperty] public Item Item { get; set; }

        public CreateItemModel(IItemRepository repo)
        {
            this._itemRepo = repo;
        }

        public IActionResult OnGet()
        {
            return Page();            r
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _items.CreateItem(Item);
            return RedirectToPage("Index");

        }


    }
}
