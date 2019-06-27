using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.KeyStore;
using Nethereum.KeyStore.Model;
using Nethereum.Signer;
using System;
using System.Diagnostics;
using System.IO;

namespace LinkTokenFullWallet
{
    class KeyStoreEx
    {
        static ScryptParams scryptParams = new ScryptParams() { Dklen = 32, N = 4096, R = 8, P = 6 };

        /// <summary>
        /// 生成一个钱包文件
        /// </summary>
        /// <param name="password"></param>
        /// <param name="path">钱包存放路径</param>
        /// <returns>返回生成的钱包地址</returns>
        public static string GenerateKeyStore(string password,string path)
        {
            var ecKey = EthECKey.GenerateKey();
            Debug.WriteLine("PrivateKey: " +ecKey.GetPrivateKey());
            Debug.WriteLine("PubKey: " + ecKey.GetPubKey().ToHex(true));
            Debug.WriteLine("PublicAddress: " + ecKey.GetPublicAddress());
            var privateKey = ecKey.GetPrivateKeyAsBytes();
            var genAddress = ecKey.GetPublicAddress().ToLower();

            var scryptService = new KeyStoreScryptService();
            var scryptResult = scryptService.EncryptAndGenerateKeyStoreAsJson(password, privateKey, genAddress.Replace("0x", ""), scryptParams);

            path = path + "\\" + genAddress;
            using (var newfile = File.CreateText(path))
            {         
                newfile.Write(scryptResult);
                newfile.Flush();
                return genAddress;
            }
        }

        public static string GetCoolAddress(EthECKey key,string password)
        {
            var scryptService = new KeyStoreScryptService();
            var scryptResult = scryptService.EncryptAndGenerateKeyStoreAsJson(password, key.GetPrivateKeyAsBytes(), key.GetPublicAddress().ToLower().Replace("0x", ""), scryptParams);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + key.GetPublicAddress().ToLower();
            using (var newfile = File.CreateText(path))
            {
                newfile.Write(scryptResult);
                newfile.Flush();
                return scryptResult;
            }
        }

        public static bool IsRealAddress(string address)
        {
            if (address.Length == 42 && address.IndexOf("0x") == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改密码并返回新的钱包json
        /// </summary>
        /// <param name="address"></param>
        /// <param name="newPwd"></param>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string ChangePWD(string address,string newPwd,string privateKey)
        {
            var scryptService = new KeyStoreScryptService();
            var scryptResult = scryptService.EncryptAndGenerateKeyStoreAsJson(newPwd, privateKey.HexToByteArray(), address.Replace("0x", ""), scryptParams);

            return scryptResult;
        }
    }
}
