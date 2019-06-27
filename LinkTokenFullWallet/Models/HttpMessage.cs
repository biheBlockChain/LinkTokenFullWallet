using System.Net;

namespace LinkTokenFullWallet.Models
{
    class HttpMessage
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public HttpStatusCode statusCode { get; set; }
        /// <summary>
        /// 如果 statusCode=ok，可返回对应的model，否则返回Content原始内容
        /// </summary>
        public object content { get; set; }
    }
}
