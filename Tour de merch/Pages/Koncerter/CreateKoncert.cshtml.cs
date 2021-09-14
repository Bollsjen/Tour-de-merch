using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Module;

namespace Tour_de_merch.Pages.Koncerter
{
    public class CreateKoncertModel : PageModel
    {

        [BindProperty] public Koncert Koncert { get; set; }
        public void OnGet()
        {
        }
    }
}
