using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;

namespace Tour_de_merch.Pages
{
    public class CreateTurneModel : PageModel
    {
        ITurneRepository repo;

        [BindProperty] public Turne turne { get; set; }

        public CreateTurneModel(ITurneRepository repo)
        {
            this.repo = repo;
        }


        public void OnGet() {
            
        }

        public IActionResult OnPost()
        {
            repo.CreateTurne(turne);
            return RedirectToPage("Index");
        }
    }
}
