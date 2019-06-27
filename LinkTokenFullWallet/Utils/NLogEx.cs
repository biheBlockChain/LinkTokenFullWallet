using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;
using System;

namespace LinkTokenFullWallet.Utils
{
    class NLogEx
    {
        Logger _logger;

        private NLogEx(Logger logger)
        {
            this._logger = logger;
        }
        public static NLogEx Default { get; private set; }
        static NLogEx()
        {
            Default = new NLogEx(LogManager.GetCurrentClassLogger());
        }

        #region 1. Trace - 最常见的记录信息，一般用于普通输出
        public void Trace(string msg)
        {
            _logger.Trace(msg);
        }

        public void Trace(string msg, params object[] args)
        {
            _logger.Trace(msg, args);
        }

        public void Trace(string msg, Exception err)
        {
            _logger.Trace(err, msg);
        }
        #endregion

        #region 2. Debug - 同样是记录信息，不过出现的频率要比Trace少一些，一般用来调试程序
        public void Debug(string msg)
        {
            _logger.Debug(msg);
        }

        public void Debug(string msg, params object[] args)
        {
            _logger.Debug(msg, args);
        }

        public void Debug(string msg, Exception err)
        {
            _logger.Debug(err, msg);
        }
        #endregion

        #region 3. Info - 信息类型的消息
        public void Info(string msg)
        {
            _logger.Info(msg);
        }

        public void Info(string msg, params object[] args)
        {
            _logger.Info(msg, args);
        }

        public void Info(string msg, Exception err)
        {
            _logger.Info(err, msg);
        }
        #endregion

        #region 4. Warn - 警告信息，一般用于比较重要的场合
        public void Warn(string msg)
        {
            _logger.Warn(msg);
        }

        public void Warn(string msg, params object[] args)
        {
            _logger.Warn(msg, args);
        }

        public void Warn(string msg, Exception err)
        {
            _logger.Warn(err, msg);
        }
        #endregion

        #region 5. Error - 错误信息
        public void Error(string msg)
        {
            _logger.Error(msg);
        }

        public void Error(string msg, params object[] args)
        {
            _logger.Error(msg, args);
        }

        public void Error(string msg, Exception err)
        {
            _logger.Error(err, msg);
        }
        #endregion

        #region 6. Fatal - 致命异常信息。一般来讲，发生致命异常之后程序将无法继续执行
        public void Fatal(string msg)
        {
            _logger.Fatal(msg);
        }

        public void Fatal(string msg, params object[] args)
        {
            _logger.Fatal(msg, args);
        }

        public void Fatal(string msg, Exception err)
        {
            _logger.Fatal(err, msg);
        }
        #endregion


        /// <summary>
        /// info级别的日志输出到一个richtextbox
        /// </summary>
        /// <param name="msg"></param>
        public void LogToRichTextBox(string msg)
        {
            _logger.Info(msg);
        }
    }
}