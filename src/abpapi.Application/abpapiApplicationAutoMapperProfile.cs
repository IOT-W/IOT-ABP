using abpapi.Login;
using abpapi.CommodityManagement;
using abpapi.OutPut;
using AutoMapper;
using IOT.electricity.ClassificationType;
using abpapi.ILogin.DTO;
using abpapi.Brank;
using abpapi.ClassificationType;
using abpapi.Spuk;

namespace abpapi;

public class abpapiApplicationAutoMapperProfile : Profile
{
    public abpapiApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<BrandOut, Brand>();
        CreateMap<SpuInput, Spu>();
        CreateMap<logintable, logintableDTO>();

        CreateMap<Goods_View, Goods>();
        CreateMap<Order_View, Order>();
    }
}
