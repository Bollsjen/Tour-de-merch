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
        ITurneRepository turRepo;

        [BindProperty] public Koncert Koncert { get; set; }
        public Dictionary<int, Turne> turneer;


        public CreateKoncertModel(IKoncertRepository repo, ITurneRepository turRepo)
        {
            this.repo = repo;
            this.turRepo = turRepo;
        }


        public void OnGet()
        {
            turneer = turRepo.GetAllTurneer();
        }

        public IActionResult OnPost()
        {
            repo.CreateKoncert(Koncert);
            return RedirectToPage("Index");
        }
    }
}
