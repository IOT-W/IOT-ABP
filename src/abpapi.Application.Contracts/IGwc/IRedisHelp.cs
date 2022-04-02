using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.IGwc
{
    public interface IRedisHelp<T> where T : class, new()
    {
        //添加Redis
        void SetList(string key, T list);
        //显示
        List<T> GetList(string key);
        //显示
        T GetModels(string key);
    }
}
