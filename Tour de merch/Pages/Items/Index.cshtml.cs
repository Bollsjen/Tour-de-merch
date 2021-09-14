using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;

namespace Tour_de_merch.Pages.Items
{
    public class IndexModel : PageModel
    {
        IItemRepository repo;
        public Dictionary<int,Item> Items;

        public IndexModel(IItemRepository repo)
        {
            this.repo = repo;
        }

        public void OnGet()
        {
            Items = repo.GetAllItems();
        }
    }
}
