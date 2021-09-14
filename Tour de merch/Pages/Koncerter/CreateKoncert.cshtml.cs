using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Module;
using Tour_de_merch.Interface;

namespace Tour_de_merch.Pages.Koncerter
{
    public class CreateKoncertModel : PageModel
    {

        IKoncertRepository repo;

        [BindProperty] public Koncert koncert { get; set; }


        public CreateKoncertModel(IKoncertRepository repo)
        {
            this.repo = repo;
        }


        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            repo.CreateKoncert(koncert);
            return RedirectToPage("Index");
        }
    }
}
