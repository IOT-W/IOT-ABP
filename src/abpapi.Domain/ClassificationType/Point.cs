using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.ClassificationType
{
    public class Point: Entity<Guid>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string PName { get; set; }
        /// <summary>
        /// 上级分类
        /// </summary>
        public string PSName { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int PSort { get; set; }
    }
}
