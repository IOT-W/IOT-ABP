using abpapi.CommodityManagement;
using abpapi.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abpapi.Services
{
    public class OrderServices:ApplicationService,IOrderServices
    {
        private readonly IRepository<Order, Guid> repository;
        public OrderServices(IRepository<Order, Guid> repository)
        {
            this.repository = repository;
        }

        public async Task<Order> Addbook(string Order_Type, string Order_TheMember, string Order_Consignee, string Order_State, string Order_MethodPayment, string Order_AfterState, string Order_Number, string Order_TotalAmount, string Order_Amountpayable, string Order_DateTime)
        {
            var list = await repository.InsertAsync(new Order { Order_Type = Order_Type, Order_TheMember = Order_TheMember, Order_Consignee = Order_Consignee, Order_State = Order_State, Order_MethodPayment = Order_MethodPayment, Order_AfterState = Order_AfterState, Order_Number = Order_Number, Order_TotalAmount = Order_TotalAmount, Order_Amountpayable= Order_Amountpayable, Order_DateTime = Order_DateTime });
            return new Order
            {
                Order_Type = list.Order_Type,
                Order_TheMember = list.Order_TheMember,
                Order_Consignee = list.Order_Consignee,
                Order_State = list.Order_State,
                Order_MethodPayment = list.Order_MethodPayment,
                Order_AfterState = list.Order_AfterState,
                Order_Number = list.Order_Number,
                Order_TotalAmount = list.Order_TotalAmount,
                Order_Amountpayable = list.Order_Amountpayable,
                Order_DateTime = list.Order_DateTime
            };
        }

        public async Task<int> DeleteAsync(string id)
        {
            string[] strArr = id.Split(',');

            var all = await repository.GetListAsync(x => id.ToString().Contains(x.Id.ToString()));

            repository.DeleteManyAsync(all);

            return 0;
        }

        public async Task<List<Order>> GetOrder(string Order_Type, string Order_TheMember, string Order_Consignee, string Order_State, string Order_MethodPayment, string Order_AfterState, string Order_Number, string Order_TotalAmount, string Order_Amountpayable, string Order_DateTime)
        {
            var list = await repository.GetListAsync();
            if (!string.IsNullOrEmpty(Order_Type))
            {
                list = list.Where(x => x.Order_Type.Contains(Order_Type)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_TheMember))
            {
                list = list.Where(x => x.Order_TheMember.Contains(Order_TheMember)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_Consignee))
            {
                list = list.Where(x => x.Order_Consignee.Contains(Order_Consignee)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_State))
            {
                list = list.Where(x => x.Order_State.Contains(Order_State)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_MethodPayment))
            {
                list = list.Where(x => x.Order_MethodPayment.Contains(Order_MethodPayment)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_AfterState))
            {
                list = list.Where(x => x.Order_AfterState.Contains(Order_AfterState)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_Number))
            {
                list = list.Where(x => x.Order_Number.Contains(Order_Number)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_TotalAmount))
            {
                list = list.Where(x => x.Order_TotalAmount.Contains(Order_TotalAmount)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_Amountpayable))
            {
                list = list.Where(x => x.Order_Amountpayable.Contains(Order_Amountpayable)).ToList();
            }
            if (!string.IsNullOrEmpty(Order_DateTime))
            {
                list = list.Where(x => x.Order_DateTime.Contains(Order_DateTime)).ToList();
            }
            return list;
        }

        public async Task<Guid> ProModif(Order_View order)
        {
            var lists = ObjectMapper.Map<Order_View, Order>(order);
            var list = await repository.UpdateAsync(lists);
            return list.Id;
        }
    }
}
