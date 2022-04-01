using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace IOT.electricity.ClassificationType
{
    /// <summary>
    /// 品牌分类表
    /// </summary>
    public class BrandType: Entity<Guid>
    {
      
        /// <summary>
        /// 分类名称        /// </summary>
        public string TName { get; set; }
        public string TType { get; set; }

    }
}
