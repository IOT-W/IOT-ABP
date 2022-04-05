using abpapi.Login;
using abpapi.CommodityManagement;
using abpapi.OutPut;
using AutoMapper;
using abpapi.ILogin.DTO;

namespace abpapi;

public class abpapiApplicationAutoMapperProfile : Profile
{
    public abpapiApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<logintable, logintableDTO>();

        CreateMap<Goods_View, Goods>();
        CreateMap<Order_View, Order>();
    }
}
