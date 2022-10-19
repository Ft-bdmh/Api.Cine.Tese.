using Api.Cine.BusinessLogic.Peliculas;
using Api.Cine.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Cine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly PeliculaBL peliculaBL;

        public PeliculaController()
        {
            peliculaBL = new PeliculaBL();
        }


        [HttpGet()]
        [Route("GetPeliculas")]

        public async Task<List<Pelicula>>GetPeliculas()
        {
            List<Pelicula> ls = new List<Pelicula>();
            try
            {
                ls = await peliculaBL.GetPeliculas();

                if (ls == null)
                {
                    return new List<Pelicula>();
                }                

            }
            catch(Exception e)
            {
                return new List<Pelicula>();
            }

            return ls;
        }

      

        [HttpPost()]
        [Route("PostPelicula")]

        public async Task<Pelicula>PostPelicula(int id)
        {
            return await peliculaBL.GetPeliculasById(id);
        }


    }
}
