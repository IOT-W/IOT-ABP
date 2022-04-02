using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.CommodityManagement
{
    /// <summary>
    /// 订单管理
    /// </summary>
    public class Order:BasicAggregateRoot<Guid>
    {
        /// <summary>
        /// 订单类型
        /// </summary>
        public string Order_Type { get; set; }
        /// <summary>
        /// 下单会员
        /// </summary>
        public string Order_TheMember { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Order_Consignee { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string Order_State { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string Order_MethodPayment { get; set; }
        /// <summary>
        /// 售后状态
        /// </summary>
        public string Order_AfterState { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public string Order_Number { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public string Order_TotalAmount { get; set; }
        /// <summary>
        /// 应付金额
        /// </summary>
        public string Order_Amountpayable { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public string Order_DateTime { get; set; }
    }
}
