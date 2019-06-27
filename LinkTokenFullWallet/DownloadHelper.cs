using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    public class DownloadHelper
    {
        #region 获取当前链接的文件大小

        //获取当前链接的文件大小
        public static string DownFileSize(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.HEAD);
            request.Timeout = 20000;
            client.Timeout = 20000;
            //request.AddHeader("Accept-Encoding", "identity");
            var reponse = client.Execute(request);
            return CountSize(reponse.ContentLength);
            //HttpWebRequest Myrq = (HttpWebRequest)HttpWebRequest.Create(url);
            //Myrq.Timeout = 20000;
            //HttpWebResponse myrp = (HttpWebResponse)Myrq.GetResponse();
            //long totalBytes = myrp.ContentLength;
            //return CountSize(totalBytes);
        }

        #endregion

        #region 获取一个本地文件的大小

        //获取一个本地文件的大小
        public static long GetFilesSize(String path)
        {
            long length = 0;
            FileInfo file = new FileInfo(path);
            length = file.Length;
            return length;
        }

        #endregion

        #region 计算文件大小函数

        /// <summary>  
        /// 计算文件大小函数(保留两位小数),Size为字节大小  
        /// </summary>  
        /// <param name="Size">初始文件大小</param>  
        /// <returns></returns>  
        public static string CountSize(long Size)
        {
            string m_strSize = "";
            long FactSize = 0;
            FactSize = Size;
            if (FactSize < 1024.00)
                m_strSize = FactSize.ToString("F2") + " Byte";
            else if (FactSize >= 1024.00 && FactSize < 1048576)
                m_strSize = (FactSize / 1024.00).ToString("F2") + " K";
            else if (FactSize >= 1048576 && FactSize < 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00).ToString("F2") + " M";
            else if (FactSize >= 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + " G";
            return m_strSize;
        }

        #endregion

        #region 下载文件

        /// <param name="URL">下载文件地址</param>       
        /// <param name="Filename">下载后的存放地址</param>        
        /// <param name="Prog">用于显示的进度条</param>        
        /// 
        public static void DownloadFile(string URL, string filename, ProgressBar prog, Label la, Label yfs, Label sy)
        {
            float percent = 0;
            try
            {
                HttpWebRequest Myrq = (HttpWebRequest)HttpWebRequest.Create(URL);
                HttpWebResponse myrp = (HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                prog.Invoke(new MethodInvoker(() =>
                {
                    if (prog != null)
                    {
                        prog.Maximum = (int)totalBytes;
                    }
                }));
                Stream st = myrp.GetResponseStream();
                Stream so = new FileStream(filename, FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    Application.DoEvents();
                    so.Write(by, 0, osize);
                    prog.Invoke(new MethodInvoker(() =>
                    {
                        if (prog != null)
                        {
                            prog.Value = (int)totalDownloadedByte;
                        }
                    }));
                    osize = st.Read(by, 0, (int)by.Length);
                    down = (int)totalDownloadedByte;
                    percent = ((float)totalDownloadedByte / (float)totalBytes);
                    yfs.Invoke(new MethodInvoker(() =>
                    {
                        yfs.Text = "已传送：" + CountSize(totalDownloadedByte);
                    }));
                    sy.Invoke(new MethodInvoker(() =>
                    {
                        sy.Text = "剩余：" + CountSize((totalBytes - totalDownloadedByte));
                    }));
                    la.Invoke(new MethodInvoker(() =>
                    {
                        la.Text = "进度：" + percent.ToString("#%");
                    }));
                    Application.DoEvents();
                }
                so.Close();
                st.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("下载失败,异常报告：" + ex.Message);
            }
        }

        #endregion

        #region 计算下载速度

        public static int down = 0;
        public static int last = 0;
        //计算下载速度
        public static void WebLoad(ProgressBar prog, Label la)
        {
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Enabled = true;
            tm.Tick += (s, e) =>
            {
                string size = "KB/S";
                if (((down - last) / 1024) > 1024)
                {
                    size = "M/S";
                }
                la.Text = "下载速度：" + ((down - last) / 1024) + size;
                last = down;
                if (prog.Value == prog.Maximum)
                {
                    tm.Enabled = false;
                }
            };
        }

        #endregion
    }
}
