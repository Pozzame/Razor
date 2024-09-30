using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

    public class DettaglioProdotto : PageModel
    {
        private readonly ILogger<DettaglioProdotto> _logger;

        public DettaglioProdotto(ILogger<DettaglioProdotto> logger)
        {
            _logger = logger;
            logger.LogInformation( "Pagina Dettaglio Prodotto caricata" );
        }

        public Prodotto Prodotto { get; set; }
        public void OnGet(int id, string nome, decimal prezzo, string dettaglio, string immagine)
        {
            Prodotto = new Prodotto{ Id = id, Nome = nome, Prezzo = prezzo, Dettaglio = dettaglio, Immagine = immagine};
        }
    }