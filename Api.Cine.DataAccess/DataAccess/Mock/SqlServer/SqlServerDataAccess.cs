using Api.Cine.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.DataAccess.DataAccess.Mock.SqlServer
{
    public class SqlServerDataAccess : IDataAccess
    {
        private readonly string _connectionString;
        
        public SqlServerDataAccess(string connectionString)
            {
            _connectionString = connectionString;


            }

        public Task<Pelicula> GetPelicula(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pelicula> GetPeliculas(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pelicula>> GetPeliculas()
        {
            try
            {
                List<Pelicula> peliculas= new List<Pelicula>();

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using(SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.Connection.Open();
                        cmd.CommandType=System.Data.CommandType.Text;

                        cmd.CommandText = "select * from Peliculas";


                        using (SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                        {
                            Pelicula pelicula;


                            while (rdr.Read())
                            {
                                pelicula = new Pelicula();

                                pelicula.Id = Convert.ToInt32(rdr["IdPelicula"].ToString());
                                pelicula.Name = rdr["Name"].ToString();
                                pelicula.Genre = rdr["Genre"].ToString();
                                pelicula.Duration = rdr["Duration"].ToString();
                                pelicula.Actors = rdr["Actors"].ToString();
                                pelicula.Classification = rdr["Classification"].ToString();

                                peliculas.Add(pelicula);



                            }
                        }

                   
                    }
                    return peliculas;
                }
            }catch(Exception ex)
            {
                
                Console.WriteLine("" + ex.Message);
        

            }
            return new List<Pelicula> { new Pelicula() };
        }

        public Task<Pelicula> PostPelicula(int id)
        {
            throw new NotImplementedException();
        }
    }
}
