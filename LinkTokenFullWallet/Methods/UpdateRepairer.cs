using System.IO;

namespace LinkTokenFullWallet.Methods
{
    /// <summary>
    /// 版本升级时需要执行的一些变更
    /// </summary>
    internal class UpdateRepairer
    {
        /// <summary>
        /// demo:
        /// 1.x.x to ~  
        /// </summary>
        internal static void UserSettingFolderNameChange()
        {
            string oldPath = "";
            string newPath = "";
            if (File.Exists(oldPath) && !Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
                File.Copy(newPath, oldPath);
            }
        }

        internal static void CreateFolder()
        {
            
        }
    }
}
