using Api.Cine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.DataAccess.DataAccess.Mock
{
    public class MockDataAccess : IDataAccess
    {
        public async Task<Pelicula> GetPelicula(int id)
        {
            Pelicula pelicula = new Pelicula();
                pelicula.Id = 1;
                pelicula.Name = "Interestelar";
                pelicula.Genre = "Ciencia Ficcion";
                pelicula.Duration = "2 horas 49 minutos";
                pelicula.Actors = "Matthew McConaughey";
                pelicula.Country = "USA";
                pelicula.Classification = "PG-13";

            return pelicula;
        }


        public async Task<List<Pelicula>> GetPeliculas()
        {


            List<Pelicula> pl = new List<Pelicula>();

            pl.Add(new Pelicula()
            {
                Id = 1,
                Name = "Interestelar",
                Genre = "Ciencia Ficcion",
                Duration = "2 horas 49 minutos",
                Actors = "Matthew McConaughey"
            });
            pl.Add(new Pelicula()
            {
                Id = 2,
                Name = "Amazing Spiderman",
                Genre = "Ciencia Ficcion",
                Duration = "2 horas 30 minutos",
                Actors = "Tom Holland"
            });
            pl.Add(new Pelicula()
            {
                Id = 3,
                Name = "It",
                Genre = "Terror",
                Duration = "2 horas",
                Actors = "Jaeden Martell"
            });

            return pl;



        }

        public Task<Pelicula> PostPelicula(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Test()
        {
            throw new NotImplementedException();
        }
    
    }
}
