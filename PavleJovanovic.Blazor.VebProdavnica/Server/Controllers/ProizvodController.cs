using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PavleJovanovic.Blazor.VebProdavnica.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private static List<Proizvod> Proizvodi = new()
        {
            new Proizvod
            {
                Id = 1,
                Naziv = "WTL Easy Job 200",
                Opis = "Savrsen za kucnu upotrebu i lakše radioničke potrebe! Tehnicki podaci za WTL aparat za zavarivanje EASY JOB 200 4 kg",
                UrlSlike = "https://www.biljaca.rs/wp-content/uploads/2023/05/easy-job-200.jpg",
                Cena = 19.980m
            },

            new Proizvod
            {
                Id = 2,
                Naziv = "WTL MIG 315",
                Opis = "Profesionalni inverterski aparat sa duplim pogonom na dodavaču žice i euro centralnom utičnicom,veoma kompaktan IGBT inverterski mig/mag(CO2 aparat za zavarivanje).",
                UrlSlike = "https://www.biljaca.rs/wp-content/uploads/2019/01/aparat-zavarivanje-wtl-multimig-200-slika-42091184-300x300-2.jpg",
                Cena = 144.550m
            },

            new Proizvod
            {
                Id = 3,
                Naziv = "WTL CUT 100 CNC",
                Opis = "Aparat za plazma rezanje maksimalne jačine 100 A Paljenje luka bez kontakta sa materijalom(vazdušno). Intermitenca mu je na 90 A 100% Reže do maksimalne debljine od 55 mm Količina vazduha koja mu je potrebna za pravilan rad je od 30 do 290 litara u   minuti. Brener za rezanje je dužine 6M i opremljen je TECMO PT 100 gorionikom.",
                UrlSlike = "https://www.biljaca.rs/wp-content/uploads/2019/01/cut_100_cnc_fotor.jpg",
                Cena = 268.450m
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProizvod()
        {
            return Ok(Proizvodi);
        }

    }
}
