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
            _logger.LogInformation("Prodotti caricati");
        }

        public IEnumerable<Prodotto> ElencoProdotti { get; set; }

        public void OnGet(decimal? minPrezzo, decimal? maxPrezzo)
        {
            List<Prodotto> allProdotti = new List<Prodotto>
            {
                new Prodotto { Id = 1, Nome = "Prod 1", Prezzo = 100, Dettaglio ="Dettaglio 1", Immagine = "./Images/1.jpg" },
                new Prodotto { Id = 2, Nome = "Prod 2", Prezzo = 200, Dettaglio ="Dettaglio 2", Immagine = "./Images/2.jpg"},
                new Prodotto { Id = 3, Nome = "Prod 3", Prezzo = 300, Dettaglio ="Dettaglio 3", Immagine = "./Images/3.jpg"}
            };

            List<Prodotto> ElencoProdottiFiltrati = new List<Prodotto>();

            foreach (var prodotto in allProdotti)
            {
                bool aggiungi = true;
                if (minPrezzo.HasValue)
                {
                    if (prodotto.Prezzo < minPrezzo)
                        aggiungi = false;
                }
                if (maxPrezzo.HasValue)
                {
                    if (prodotto.Prezzo > maxPrezzo)
                        aggiungi = false;
                }
            if (aggiungi)
                ElencoProdottiFiltrati.Add(prodotto);
            }
            ElencoProdotti = ElencoProdottiFiltrati;
        }
    }
}