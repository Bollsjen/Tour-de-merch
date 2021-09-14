using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;

namespace Tour_de_merch.Pages.Koncerter
{
    public class IndexModel : PageModel
    {
        IKoncertRepository koncertRepo;
        public Dictionary<int, Koncert> Koncerter;

        public IndexModel(IKoncertRepository koncertRepo)
        {
            this.koncertRepo = koncertRepo;
        }

        public void OnGet()
        {
            Koncerter = koncertRepo.GetAllKoncerts();
        }
    }
}
