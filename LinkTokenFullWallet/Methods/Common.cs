using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using RestSharp;
using System;
using System.IO;

namespace LinkTokenFullWallet.Methods
{
    /// <summary>
    /// 专属该项目的通用类
    /// </summary>
    class Common
    {
        public static void UnGzipFile(string zipfilepath, string unzippath)
        {
            Stream inStream = null;
            Stream gzipStream = null;
            TarArchive tarArchive = null;
            try
            {
                using (inStream = File.OpenRead(zipfilepath))
                {
                    using (gzipStream = new GZipInputStream(inStream))
                    {
                        tarArchive = TarArchive.CreateInputTarArchive(gzipStream);
                        tarArchive.ExtractContents(unzippath);
                        tarArchive.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (null != tarArchive)
                    tarArchive.Close();
                if (null != gzipStream)
                    gzipStream.Close();
                if (null != inStream)
                    inStream.Close();
            }
        }

        /// <summary>
        /// 复制文件夹中的所有内容
        /// </summary>
        /// <param name="sourceDirPath">源文件夹目录</param>
        /// <param name="saveDirPath">指定文件夹目录</param>
        public static void CopyDirectory(string sourceDirPath, string saveDirPath)
        {
            try
            {
                if (!Directory.Exists(saveDirPath))
                {
                    Directory.CreateDirectory(saveDirPath);
                }

                //获取源路径文件的名称
                string[] files = Directory.GetFiles(sourceDirPath);

                //遍历子文件夹的所有文件。
                foreach (string file in files)
                {
                    string pFilePath = saveDirPath + "\\" + Path.GetFileName(file);
                    if (File.Exists(pFilePath))
                        continue;
                    File.Copy(file, pFilePath, true);
                }

                string[] dirs = Directory.GetDirectories(sourceDirPath);

                //递归，遍历文件夹
                foreach (string dir in dirs)
                {
                    CopyDirectory(dir, saveDirPath + "\\" + Path.GetFileName(dir));
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static bool RPCServerTest()
        {
            var request = new RestRequest(Method.HEAD);
            var reponse = GlobalVar.http_client_local.Execute(request);
            return reponse.IsSuccessful;
        }
    }
}
