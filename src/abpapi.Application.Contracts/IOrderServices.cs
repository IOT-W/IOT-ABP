using abpapi.CommodityManagement;
using abpapi.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpapi
{
    public interface IOrderServices:IApplicationService
    {
        Task<List<Order>> GetOrder(string Order_Type, string Order_TheMember, string Order_Consignee, string Order_State, string Order_MethodPayment, string Order_AfterState, string Order_Number, string Order_TotalAmount,string Order_Amountpayable,string Order_DateTime);
        Task<Order> Addbook(string Order_Type, string Order_TheMember, string Order_Consignee, string Order_State, string Order_MethodPayment, string Order_AfterState, string Order_Number, string Order_TotalAmount, string Order_Amountpayable, string Order_DateTime);
        Task<int> DeleteAsync(string id);
        Task<Guid> ProModif(Order_View order);
    }
}
