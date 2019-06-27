using Nethereum.Hex.HexTypes;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace LinkTokenFullWallet
{
    class TransactionEx
    {
        RestClient client;
        RestRequest request;

        public TransactionEx(string url)
        {
            client = new RestClient(url);
            client.ClearHandlers();
            client.AddHandler("application/json", new JsonDeserializer());//设置Accept参数
            client.UserAgent = "Go-http-client/1.1";
            client.AddDefaultHeader("Otc-Timestamp", ((DateTime.Now.Ticks - 621355968000000000) / 10000000).ToString());
            client.AddDefaultHeader("Otc-Uatype", "0");

            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Connection", "close");
            request.Parameters.Clear();
        }

        public static Account UnlockAccountFromKeyStoreJson(string json, string password)
        {
            return Account.LoadFromKeyStore(json, password);
        }
        public static Account UnlockAccountFromKeyStoreFile(string path, string password)
        {
            return Account.LoadFromKeyStoreFile(path, password);
        }

        /// <summary>
        /// 查询帐户余额
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public decimal GetBalance(string address)
        {
            request.Parameters.Clear();
            var postData = new
            {
                jsonrpc = "2.0",
                method = "eth_getBalance",
                //@params = new List<string> { address, "delay" },
                @params = new List<string> { address, "latest" },
                id = 1
            };
            request.AddJsonBody(postData);
            var response = client.Execute(request);
            var content = response.Content;
            try
            {
                var resultJson = JsonConvert.DeserializeObject<dynamic>(content);
                string money_hex = resultJson.result;
                HexBigInteger money_bigint = new HexBigInteger(money_hex);
                return Nethereum.Util.UnitConversion.Convert.FromWei(money_bigint.Value);
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// 获取帐户发出交易的总次数
        /// </summary>
        /// <param name="address"></param>
        /// <returns>0x000</returns>
        public string GetTransactionCount(string address)
        {
            request.Parameters.Clear();
            var postData = new
            {
                jsonrpc = "2.0",
                method = "eth_getTransactionCount",
                @params = new List<string> { address, "pending" },
                id = 1
            };
            request.AddJsonBody(postData);
            var response = client.Execute(request);
            var content = response.Content;
            var resultJson = JsonConvert.DeserializeObject<dynamic>(content);
            string nonce = resultJson.result;//第二步提交需要的参数，该帐户的发出交易总次数   0x
            if (string.IsNullOrEmpty(nonce))
                nonce = "0x0";
            return nonce;
        }

        /// <summary>
        /// 签名一个交易
        /// </summary>
        /// <param name="privatekey"></param>
        /// <param name="to_address"></param>
        /// <param name="weiNum"></param>
        /// <param name="nonce">通过GetTransactionCount获取0x000   16进制的值</param>
        /// <returns>签名后的16进制表达形式</returns>
        public string SignTransaction(string privatekey, string to_address, decimal to_num, string nonce, string from_address)
        {
            var sign = new Nethereum.Signer.TransactionSigner();
            var weiNum = Nethereum.Util.UnitConversion.Convert.ToWei(to_num);
            var hexNum = new HexBigInteger(weiNum).HexValue;
            BigInteger nonce_bigint = Convert.ToInt32(nonce, 16);
            var gasLimit = new HexBigInteger(GetGasLimit(from_address, to_address, hexNum, nonce)).Value;
            var gasPrice = new BigInteger(100000000000);
            var txSign = sign.SignTransaction(privatekey, to_address, weiNum, nonce_bigint, gasPrice, gasLimit);
            return "0x" + txSign;
        }

        public string GetGasLimit(string from_address, string to_address, string num, string nonce)
        {
            request.Parameters.Clear();
            var p = new
            {
                from = from_address,
                gas = "0x1",
                gasPrice = "0x174876e800",
                nonce = nonce,
                to = to_address,
                value = num
            };
            var postData = new
            {
                jsonrpc = "2.0",
                method = "eth_estimateGas",
                @params = new List<object> { p },
                id = 1,
                Nc = "IN"
            };
            request.AddJsonBody(postData);
            var response = client.Execute(request);
            var content = response.Content;
            if (string.IsNullOrEmpty(content))
            {
                return "";
            }
            var resultJson = JsonConvert.DeserializeObject<dynamic>(content);
            string txHash = resultJson.result;//交易成功后的hash
            if (string.IsNullOrEmpty(txHash))
            {
                string errorMsg = resultJson.error.message;
                return errorMsg;
            }
            else
            {
                return txHash;
            }
        }
        /// <summary>
        /// 发送一个已签名的交易
        /// </summary>
        /// <returns>交易成功返回hash，否则返回错误信息</returns>
        public string SendRawTransaction(string signTransaction)
        {
            request.Parameters.Clear();
            var postData = new
            {
                jsonrpc = "2.0",
                method = "eth_sendRawTransaction",
                @params = new List<string> { signTransaction },
                id = 1,
                Nc = "IN"
            };
            request.AddJsonBody(postData);
            var response = client.Execute(request);
            var content = response.Content;
            if (string.IsNullOrEmpty(content))
            {
                return "";
            }
            var resultJson = JsonConvert.DeserializeObject<dynamic>(content);
            string txHash = resultJson.result;//交易成功后的hash
            if (string.IsNullOrEmpty(txHash))
            {
                string errorMsg = resultJson.error.message;
                return errorMsg;
            }
            else
            {
                return txHash;
            }
        }
    }
}
