using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tour_de_merch.Module;
using Tour_de_merch.Interface;


namespace Tour_de_merch.Pages.Koncerter.KoncertItemKatalog
{
    public class IndexModel : PageModel
    {
        public Koncert koncert { get; set; }

        IKoncertRepository repository;

        public IndexModel(IKoncertRepository repository)
        {
            this.repository = repository;
        }
        
        

        public void OnGet(int id)
        {
            koncert = repository.GetKoncert(id);
            int 0;
        }
    }
}
