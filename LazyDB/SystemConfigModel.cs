using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDB
{
    public class SystemConfigModel
    {
        public string ip { get; set; }
        public string dbName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        /// <summary>
        /// appId
        /// </summary>
        public string appId { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public bool Number { get; set; }
        /// <summary>
        /// 字段英文名
        /// </summary>
        public string EngName { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public bool Type { get; set; }
        /// <summary>
        /// 字段中文名
        /// </summary>
        public bool ChsName { get; set; }
        /// <summary>
        /// 必填
        /// </summary>
        public bool Required { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public bool DefaultValue { get; set; }
    }
}
