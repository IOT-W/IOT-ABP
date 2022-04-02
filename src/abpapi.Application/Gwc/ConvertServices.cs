using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abpapi.GwcModels;
using abpapi.IGwc;
using Newtonsoft.Json;

namespace abpapi.Gwc
{
    public class ConvertServices : IConvertServices
    {
        /// <summary>
        /// 购物车转换（转为输入）
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public List<GwcInputRedis> GwcInputConvert<T>(T models)
        {
            var ls = JsonConvert.DeserializeObject<List<GwcInputRedis>>(JsonConvert.SerializeObject(models));
            return ls;
        }
    }
}
