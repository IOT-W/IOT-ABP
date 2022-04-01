﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.Poin
{
    public class PointOut
    {
        public int Id { get; set; }
        /// 商品名称
        /// </summary>
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
