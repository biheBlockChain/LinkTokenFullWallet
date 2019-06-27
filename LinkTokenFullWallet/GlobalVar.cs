using RestSharp;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    class GlobalVar
    {
        public static readonly string lk_bin_path = Application.StartupPath + @"\lk-chain\bin\";
        public static readonly string lk_init_data = Application.StartupPath + @"\lk-chain\data\";
        public static readonly string lk_data_path = Application.StartupPath + @"\lk-chain\sbin\DataPath\peer_data\";
        public static readonly string lk_log_path = Application.StartupPath + @"\lk-chain\sbin\DataPath\peer_logs\";
        public static readonly string keystore_path = Application.StartupPath + @"\KeyStore";


        //public static readonly string state_db_download_url = "https://www.ihomesoft.net/my-files/state.db.tar.gz"; 
        public static readonly string state_db_download_url = "http://biheresource.wrbug.cn:8001/lk-chain/data/state.db.tar.gz";
        public static readonly string state_db_local_path = lk_init_data + @"\state.db.tar.gz";

        public static readonly string lock_file = Application.StartupPath + @"\lock";

        public static RestClient http_client_local = new RestClient("http://127.0.0.1:44000/");
        public static NethWrapper web3_local = new NethWrapper("http://127.0.0.1:44000/");
        public static NethWrapper web3_main = new NethWrapper("https://linktoken.bihe.wrbug.cn");
    }
}
