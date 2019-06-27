using System.Data;
using System.Data.SqlClient;

namespace LinkTokenFullWallet.Utils
{
    public class DapperEx
    {
#if DEBUG
        private static string defaultConnString = "";
#else
        private static string defaultConnString = "";
#endif


        /// <summary>
        /// 返回一个默认的数据库链接对象，用于dapper操作
        /// </summary>
        /// <returns></returns>
        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(defaultConnString);
            }
        }
    }


}
