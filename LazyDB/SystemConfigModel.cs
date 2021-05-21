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
        public string appId { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string code { get; set; }
    }
}
