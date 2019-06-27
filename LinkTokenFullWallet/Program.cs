using FSLib.App.SimpleUpdater;
using FSLib.App.SimpleUpdater.Defination;
using LinkTokenFullWallet.Utils;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    static class Program
    {
        public const string softname = "LinkTokenFullWallet";
        public const string updateUrl1 = @"https://gitee.com/iHomeSoft/update/raw/master/" + softname + "/{0}";
        public const string updateUrl2 = @"https://update.ihomesoft.net/" + softname + "/{0}";
        public const string analysisUrl = @"https://ihomesoft.gitee.io/update/" + softname + ".html";

        public static bool isUpdate = false;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
#if !DEBUG 
            //三位版本号与服务器不一致会引起更新
            var updater = Updater.CreateUpdaterInstance(
                new UpdateServerInfo[]
                {
                    new UpdateServerInfo(updateUrl1, "update_c.xml"),
                    new UpdateServerInfo(updateUrl2, "update_c.xml")
                }
            );
            updater.UpdatesFound += (s, e) =>
            {
                isUpdate = true;
            };
            Updater.CheckUpdateSimple();//在任意位置调用此方法可再次检查更新

            //开发调试不进行异常处理
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic);//全局异常捕捉
            Application.ThreadException += Application_ThreadException; //UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //多线程异常
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException; //Task异常
#endif
            Application.ApplicationExit += Application_ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //更新配置文件
            if (!Properties.Settings.Default.Upgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Upgraded = true;
                Properties.Settings.Default.Save();
            }

            Application.Run(new FormMain());
            //单实例模式启动
            //RunOneApp(new FormMain(), true);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            LKCLI.Stop();
            Environment.Exit(0);
        }

        //UI线程异常
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            NLogEx.Default.Error("严重错误UI", e.Exception);
            WinFormEx.FormBugReport.ShowBug(e.Exception);
        }
        //多线程异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            NLogEx.Default.Error("严重错误Thread", (Exception)e.ExceptionObject);
            WinFormEx.FormBugReport.ShowBug((Exception)e.ExceptionObject);
        }
        //Task异常，此事件在GC时由Finalizer线程触发
        static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            NLogEx.Default.Error("严重错误Task", e.Exception);
        }

        #region 只运行启动一个程序实例
        /// <summary>
        /// 防止程序重复运行
        /// </summary>
        /// <param name="startForm">new form()</param>
        /// <param name="activate">是否激活已运行程序</param>
        public static void RunOneApp(Form startForm, bool activate)
        {
            if (activate)
            {
                Process instance = RunningInstance();
                if (instance == null)
                {
                    //没有实例在运行
                    Application.Run(startForm);
                }
                else
                {
                    //已经有一个实例在运行
                    HandleRunningInstance(instance);
                }
            }
            else
            {
                bool initiallyOwned = true;
                bool isCreated;
                Mutex m = new Mutex(initiallyOwned, Application.ProductName, out isCreated);
                if (!(initiallyOwned && isCreated))
                {
                    MessageBox.Show("程序已在运行,请勿重复打开！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    Application.Run(startForm);
                }
            }
        }
        private static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历与当前进程名称相同的进程列表  
            foreach (Process process in processes)
            {
                //如果实例已经存在则忽略当前进程  
                if (process.Id != current.Id)
                {
                    //保证要打开的进程同已经存在的进程来自同一文件路径
                    if (process.MainModule.FileName == current.MainModule.FileName)
                    {
                        //返回已经存在的进程
                        return process;
                    }
                }
            }
            return null;
        }
        private static void HandleRunningInstance(Process instance)
        {
            //MessageBox.Show("已经在运行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowWindowAsync(instance.MainWindowHandle, 9);  //调用api函数，正常显示窗口
            SetForegroundWindow(instance.MainWindowHandle); //将窗口放置最前端
        }
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);
        #endregion
    }
}
