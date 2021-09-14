using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;

namespace Tour_de_merch.Pages
{
    public class IndexModel : PageModel
    {
        ITurneRepository repo;
        public Dictionary<int, Turne> Turneer;

        public IndexModel(ITurneRepository repo)
        {
            this.repo = repo;
        }

        public void OnGet()
        {
            Turneer = repo.GetAllTurneer();
        }
    }
}
