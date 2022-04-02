using abpapi.Brank;
using abpapi.ClassificationType;
using abpapi.Spuk;
using abpapi.ILoginService.DTO;
using abpapi.Login;
using AutoMapper;
using IOT.electricity.ClassificationType;

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

    }
}
