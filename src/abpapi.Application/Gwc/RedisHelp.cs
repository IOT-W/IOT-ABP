using abpapi.IGwc;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.Gwc
{
    public class RedisHelp<T> : IRedisHelp<T> where T : class, new()
    {
        private string host = "127.0.0.1";
        private int port = 6379;
        public List<T> GetList(string key)
        {
            RedisClient client = new RedisClient(host, port);
            return client.Get<List<T>>(key);
        }

        public T GetModels(string key)
        {
            RedisClient client = new RedisClient(host, port);
            return client.Get<T>(key);
        }

        public void SetList(string key, T list)
        {
            RedisClient client = new RedisClient(host, port);
            client.Set(key, list);
        }
    }
}
