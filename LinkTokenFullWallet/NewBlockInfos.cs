using System.Text;
using System.Threading.Tasks;

namespace LinkTokenFullWallet
{
    class NewBlockInfos
    {
        public static async Task<string> GetNewBlockHtmlAsync(string newBlockNum)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">");
            sb.Append("<style>");
            sb.Append("table.dataintable {");
            sb.Append("border: 1px solid #888888;");
            sb.Append("border-collapse: collapse;");
            sb.Append("font-family: Arial,Helvetica,sans-serif;");
            sb.Append("margin-top: 10px;");
            sb.Append("width: 100%;");
            sb.Append("}");
            sb.Append("table.dataintable th {");
            sb.Append("background-color: #CCCCCC;");
            sb.Append("border: 1px solid #888888;");
            sb.Append("padding: 5px 15px 5px 5px;");
            sb.Append("text-align: left;");
            sb.Append("vertical-align: baseline;");
            sb.Append("}");
            sb.Append("table.dataintable td {");
            sb.Append("background-color: #EFEFEF;");
            sb.Append("border: 1px solid #AAAAAA;");
            sb.Append("padding: 5px 15px 5px 5px;");
            sb.Append("vertical-align: text-top;");
            sb.Append("}");
            sb.Append("</style>");
            sb.Append("</head>");
            sb.Append("<body>");
            sb.Append("<table class=\"dataintable\">");
            sb.Append("<tr>");
            sb.Append("<th>区块</th>");
            sb.Append("<th>生成时间</th>");
            sb.Append("<th>交易数</th>");
            sb.Append("<th>交易总量</th>");
            sb.Append("</tr>");
            var num = int.Parse(newBlockNum);
            for (int i = 0; i < 8; i++)
            {
                var b = num - i;
                var blockInfo = await GlobalVar.web3_local.GetBlockWithTransactionsByNumberAsync(b);
                sb.Append("<tr>");
                sb.Append("<td>" + blockInfo.Number.Value.ToString() + "</td>");
                sb.Append("<td>" + ihslib.Extension.DateTimeExtension.UnixTimeToTime(blockInfo.Timestamp.Value.ToString()).Replace(".000", "") + "</td>");
                var trans = blockInfo.Transactions;
                var trans_count = 0;
                var trans_num = 0m;
                foreach (var item in trans)
                {
                    trans_count++;
                    trans_num += GlobalVar.web3_local.ConvertHexToDecimal(item.Value.HexValue);
                }
                sb.Append("<td>" + trans_count + "</td>");
                sb.Append("<td>" + trans_num + "</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            return sb.ToString();
        }

        public static void GetBlockByNumber(int num)
        {
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //var p = new
            //{
            //    jsonrpc = "2.0",
            //    method = "eth_getBlockByNumber",
            //    @params = new List<object> { "0x"+Convert.ToString(num, 16), true },
            //    id = 1
            //};
            //request.AddJsonBody(p);
            //var response = GlobalVar.local_client.Execute(request);
            //return response.Content;
        }
    }
}
