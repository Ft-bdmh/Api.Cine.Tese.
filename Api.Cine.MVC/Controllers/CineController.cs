using Api.Cine.Entities;
using Api.Cine.MVC.BusinessLogic;
using Microsoft.AspNetCore.Mvc;


namespace Api.Cine.MVC.Controllers
{
    public class CineController : Controller
    {
        private readonly PeliculaBL peliculaBL;

        public CineController()
        {
            peliculaBL = new PeliculaBL();
        }

        public async Task<IActionResult> Index(string namePelicula)
        {
            if (namePelicula == null)
            {
                ViewBag.listPelicula = await peliculaBL.GetPeliculas();
            }else

            {
                ViewBag.listPelicula = await GetPeliculasByName(namePelicula.ToLower());

            }

            ViewBag.TestMessage = "A continuacion se muestra los peliculas";


            return View();
        }

        public async Task<List<Pelicula>> GetPeliculasByName(string Name)
        {
            List<Pelicula> list = await peliculaBL.GetPeliculas();

            List<Pelicula> listResult = new List<Pelicula>();

            listResult = (from pelicula in list
                          where pelicula.Name.ToLower().Contains(Name)
                          select new Pelicula
                          {


                              Id = pelicula.Id,
                              Name = pelicula.Name,
                              Actors = pelicula.Actors,
                              Duration = pelicula.Duration,
                              Classification = pelicula.Classification,
                              Genre = pelicula.Genre,
                              Country = pelicula.Country,
                          }).ToList();

            return listResult;
        }

       
    }
}
