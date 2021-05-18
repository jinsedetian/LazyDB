using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDB
{
    public class TableStruct
    {
        [DisplayName("序号")]
        public int Number { get; set; }
        /// <summary>
        /// 表名
        /// </summary>
        public string FormName { get; set; }
        [DisplayName("字段英文名称")]
        public string ColName { get; set; }
        [DisplayName("类型（精度）")]
        public string Type { get; set; }
        [DisplayName("字段中文名称")]
        public string ColDes { get; set; }
        [DisplayName("必填")]
        public int IsNullAble { get; set; }

        [DisplayName("默认值")]
        public string DefaultValue { get; set; }
    }
}
