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
    public class EditKoncertModel : PageModel
    {
        IKoncertRepository repo;
        ITurneRepository turRepo;
        [BindProperty] public Koncert Koncert { get; set; }
        [BindProperty]public int Turne { get; set; }
        public Dictionary<int, Turne> Turneer { get; set; }
        public EditKoncertModel(IKoncertRepository repo, ITurneRepository turRepo)
        {
            this.repo = repo;
            this.turRepo = turRepo;
        }

        public void OnGet(int id)
        {
            Turneer = turRepo.GetAllTurneer();
            Koncert = repo.GetKoncert(id);
        }

        public IActionResult OnPost()
        {
            Koncert.Turne = turRepo.GetTurne(Turne);
            repo.UpdateKoncert(Koncert);
            return RedirectToPage("Index");
        }
    }
}
