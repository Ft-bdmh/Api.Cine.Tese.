using Api.Cine.DataAccess.DataAccess.Mock;
using Api.Cine.DataAccess.DataAccess.Mock.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.DataAccess
{
    public class App
    {


        private static IDataAccess dataAccess;

        public static IDataAccess DataAccess
        {
            get 
            {
            if(App.dataAccess==null)

                {
                    App.dataAccess = new SqlServerDataAccess("Server=localhost;DataBase=Peliculas;Trusted_Connection=True;Integrated Security=True;");

                }

                return App.dataAccess;
            
            }

        }
    }
}
