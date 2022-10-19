using Api.Cine.DataAccess;
using Api.Cine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.BusinessLogic.Peliculas
{
    public class PeliculaBL
    {


       public async Task<List<Pelicula>> GetPeliculas()
        {

            return await App.DataAccess.GetPeliculas();
      }
        public async Task<Pelicula> GetPeliculasById(int id)
        {

            return await App.DataAccess.GetPelicula(id);
        }

    }
}
