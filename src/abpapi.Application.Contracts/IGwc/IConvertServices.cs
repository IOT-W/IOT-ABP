using abpapi.GwcModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.IGwc
{
    public interface IConvertServices
    {
        List<GwcInputRedis> GwcInputConvert<T>(T models);
    }
}
