using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace IOT.electricity.ClassificationType
{
    /// <summary>
    /// 品牌表
    /// </summary>
    public class Brand : Entity<Guid>
    {
       
        /// 品牌名称
        /// </summary>
        public string BName { get; set; }
        /// <summary>
        /// 品牌loge
        /// </summary>
        public string BImg { get; set; }
        /// <summary>
        /// 网站
        /// </summary>
        public string BSite { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string BDescribe { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int BSort { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool BType { get; set; }
    }
}
