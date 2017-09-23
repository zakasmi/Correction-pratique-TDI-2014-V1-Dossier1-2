using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestMovement
{
    class Provider
    {

        public static SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=GestMove;Integrated Security=True");
        public static DataSet ds = new DataSet();


        public static bool UpdateProf()
        {
            try
            {

                using (SqlDataAdapter da = new SqlDataAdapter("select * from Professeur", cnx))
                {
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Professeur");
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
    }
}
