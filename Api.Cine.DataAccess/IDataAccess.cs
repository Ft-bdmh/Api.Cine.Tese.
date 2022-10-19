using Api.Cine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.DataAccess
{
    public interface IDataAccess
    {
        Task<List<Pelicula>>  GetPeliculas();
        
        Task<Pelicula> GetPelicula(int id);

        Task<Pelicula> PostPelicula(int id);
    }
}
