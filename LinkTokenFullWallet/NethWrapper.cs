using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using System.Numerics;
using System.Threading.Tasks;

namespace LinkTokenFullWallet
{
    class NethWrapper
    {
        public Web3 web3 { get; set; }

        public NethWrapper(string url)
        {
            this.web3 = new Web3(url);
        }

        /// <summary>
        /// 返回最新块的编号(十进制)
        /// </summary>
        public async Task<string> GetBlockNumberAsync()
        {
            var result = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
            return result.Value.ToString();
        }

        /// <summary>
        /// 返回指定编号的块
        /// </summary>
        /// <param name="num">传入十进制的区块编号</param>
        /// <returns></returns>
        public async Task<BlockWithTransactions> GetBlockWithTransactionsByNumberAsync(int num)
        {
            var hex = new HexBigInteger(new BigInteger(num));
            var result = await web3.Eth.Blocks.GetBlockWithTransactionsByNumber.SendRequestAsync(hex);
            return result;
        }

        /// <summary>
        /// 返回当前客户端所连接的对端节点数量(十进制)
        /// </summary>
        public async Task<string> GetPeerCountAsync()
        {
            var result = await web3.Net.PeerCount.SendRequestAsync();
            return result.Value.ToString();
        }

        /// <summary>
        /// 转换交易金额为可读的数值
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public decimal ConvertHexToDecimal(string hexNum)
        {
            HexBigInteger hex = new HexBigInteger(hexNum);
            return Nethereum.Util.UnitConversion.Convert.FromWei(hex.Value);
        }
    }
}
