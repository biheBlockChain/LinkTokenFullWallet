using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkTokenFullWallet.WinFormEx
{
    static class ToolTipUtil
    {
        static ToolTip tip { get { return new ToolTip(); } }
        /// <summary>
        /// 为控件提供Tooltip
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="tip">ToolTip</param>
        /// <param name="message">提示消息</param>
        public static void ShowTooltip(this Control control, string message)
        {
            Point _mousePoint = Control.MousePosition;
            int _x = control.PointToClient(_mousePoint).X;
            int _y = control.PointToClient(_mousePoint).Y;
            tip.Show(message, control, _x, _y);
            tip.Active = true;
        }
        /// <summary>
        /// 为控件提供Tooltip
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="tip">ToolTip</param>
        /// <param name="message">提示消息</param>
        /// <param name="durationTime">保持提示的持续时间</param>
        public static void ShowTooltip(this Control control, string message, int durationTime)
        {
            Point _mousePoint = Control.MousePosition;
            int _x = control.PointToClient(_mousePoint).X;
            int _y = control.PointToClient(_mousePoint).Y;
            tip.Show(message, control, _x, _y, durationTime);
            tip.Active = true;
        }
        /// <summary>
        /// 为控件提供Tooltip
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="tip">ToolTip</param>
        /// <param name="message">提示消息</param>
        /// <param name="xoffset">水平偏移量</param>
        /// <param name="yoffset">垂直偏移量</param>
        public static void ShowTooltip(this Control control, string message, int xoffset, int yoffset)
        {
            Point _mousePoint = Control.MousePosition;
            int _x = control.PointToClient(_mousePoint).X;
            int _y = control.PointToClient(_mousePoint).Y;
            tip.Show(message, control, _x + xoffset, _y + yoffset);
            tip.Active = true;
        }
        /// <summary>
        /// 为控件提供Tooltip
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="tip">ToolTip</param>
        /// <param name="message">提示消息</param>
        /// <param name="xoffset">水平偏移量</param>
        /// <param name="yoffset">垂直偏移量</param>
        /// <param name="durationTime">保持提示的持续时间</param>
        public static void ShowTooltip(this Control control, string message, int xoffset, int yoffset, int durationTime)
        {
            Point _mousePoint = Control.MousePosition;
            int _x = control.PointToClient(_mousePoint).X;
            int _y = control.PointToClient(_mousePoint).Y;
            tip.Show(message, control, _x + xoffset, _y + yoffset, durationTime);
            tip.Active = true;
        }
    }
}
