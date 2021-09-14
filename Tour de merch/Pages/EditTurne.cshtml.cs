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
    public class EditTurneModel : PageModel
    {
        ITurneRepository repo;
        [BindProperty] public Turne Turne { get; set; }

        public EditTurneModel(ITurneRepository repo)
        {
            this.repo = repo;
        }
        public void OnGet(int id)
        {
            Turne = repo.GetTurne(id);
        }

        public IActionResult OnPost()
        {
            repo.UpdateTurne(Turne);
            return RedirectToPage("Index");
        }
    }
}
