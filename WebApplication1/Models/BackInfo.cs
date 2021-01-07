using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BackInfo
    {
        /// <summary>
        /// 返回状态1是成功0是失败
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 返回接口
        /// </summary>
        public object result { get; set; }
    }
}
