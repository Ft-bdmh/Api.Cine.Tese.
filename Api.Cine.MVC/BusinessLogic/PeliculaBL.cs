using Api.Cine.Entities;

namespace Api.Cine.MVC.BusinessLogic
{
    public class PeliculaBL
    {
        private static HttpClient client;


        public PeliculaBL()
        {
            client = new HttpClient();
        }


        public async Task<List<Pelicula>> GetPeliculas()
        {
            List<Pelicula> peliculaList = new List<Pelicula>();
            using (client = new HttpClient())
            {
                var result = await client.GetFromJsonAsync<List<Pelicula>>("https://localhost:44312/api/Pelicula/GetPeliculas");

                if (result != null)
                {
                    peliculaList = result;

                }

            }
            return peliculaList;
        }

    }
}

