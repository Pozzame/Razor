using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppProdotti.Pages
{
    public class ProdottiModel : PageModel // Cambia il nome della classe per evitare conflitti
    {
        private readonly ILogger<ProdottiModel> _logger;

        public ProdottiModel(ILogger<ProdottiModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Prodotto> ElencoProdotti { get; set; }

        public void OnGet()
        {
            ElencoProdotti = new List<Prodotto>
            {
                new Prodotto { Nome = "Prod 1", Prezzo = 100 },
                new Prodotto { Nome = "Prod 2", Prezzo = 200 },
                new Prodotto { Nome = "Prod 3", Prezzo = 300 }
            };
        }
    }
}