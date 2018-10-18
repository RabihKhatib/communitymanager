using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace communitylibs
{
    public class SqliteDAO
    {
        public static List<SP_CITIZEN_VO> loadCitizens()
        {
            using (IDbConnection conn = new SQLiteConnection(loadConnectionString()))
            {
                var output = conn.Query<SP_CITIZEN_VO>("select * from SP_CITIZEN", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void saveCitizen(SP_CITIZEN_VO citizenVO)
        {
            using (IDbConnection conn = new SQLiteConnection(loadConnectionString()))
            {
                conn.Execute("insert into SP_CITIZEN (FIRST_NAME, LAST_NAME) values (@FIRST_NAME, @LAST_NAME)", citizenVO);
            }
        }

        private static string loadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
