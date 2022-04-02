using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoMapper;
using abpapi.IGwc;
using abpapi.GwcModels;

namespace abpapi.Gwc
{
    public class GwcServices : IGwcServices
    {
        private readonly IConvertServices convert;

        private readonly IRedisHelp<GwcOutPutModels> redis;
        private readonly IRedisHelp<List<GwcInputRedis>> redisList;
        public GwcServices(IRedisHelp<GwcOutPutModels> redis, IRedisHelp<List<GwcInputRedis>> redisList, IConvertServices convert)
        {
            this.redis = redis;
            this.redisList = redisList;
            this.convert = convert;
        }
        /// <summary>
        /// 添加|修改商品到购物车Redis
        /// </summary>
        /// <param name="gwc"></param>
        /// <returns></returns>
        public int AddGwcRedis(GwcInputModels gwc, string UserName)
        {
            int i = 0;

            try
            {
                //根据Gwc数据查询商品主表|详情表数据
                //var master = servicesMaster.QueryMaster(gwc.Number);
                //var datail = servicesDatail.QueryDatail(gwc.Did);
                //实例化购物车对象
                GwcInputRedis GwcRedis = new GwcInputRedis();
                //#region 赋值
                //GwcRedis.Number = master.ProductNumber;
                //GwcRedis.Img = master.Imgs.Split(";")[0];
                //GwcRedis.Title = master.Title;
                //GwcRedis.SizeOrColorId = datail.DId;
                //GwcRedis.Color = datail.Color;
                //GwcRedis.Size = datail.Size;
                //GwcRedis.Price = datail.Dprice;
                //GwcRedis.Sku = datail.Sku;
                //GwcRedis.Num = gwc.Num;
                //#endregion


                //获取redis集合
                var lss = redis.GetList("GWC_" + UserName);
                //转换为 redis输入 集合
                var ls = convert.GwcInputConvert(lss);
                //判断购物车reids是否有数据
                if (ls != null)
                {
                    //判断是否有相同商品（有：数量叠加）
                    var IsCun = ls.FirstOrDefault(x => x.SizeOrColorId.Equals(GwcRedis.SizeOrColorId));
                    if (IsCun != null)
                    {
                        //计算总数
                        GwcRedis.Num += IsCun.Num;
                        //删除数据
                        ls.Remove(IsCun);
                    }
                    //加入数据
                    ls.Add(GwcRedis);
                    redisList.SetList("GWC_" + UserName, ls);
                }
                else
                {
                    //如果没有数据就添加数据
                    List<GwcInputRedis> list = new List<GwcInputRedis>();
                    list.Add(GwcRedis);
                    redisList.SetList("GWC_" + UserName, list);
                }
                i = 1;
            }
            catch (Exception ex)
            {
                i = 0;
                var Message = ex.Message;
            }

            return i;
        }

        /// <summary>
        /// 删除Redi购物车里的商品数据（可不写）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRedis(int id, string UserName)
        {
            int i = 0;

            try
            {
                //实例化集合
                List<GwcOutPutModels> ls = new List<GwcOutPutModels>();
                //从Redis获取数据
                ls = redis.GetList("GWC_" + UserName);
                //查找要删除的对象
                var dells = ls.FirstOrDefault(x => x.SizeOrColorId.Equals(id));
                //删除数据
                ls.Remove(dells);
                //json转换
                var Newls = convert.GwcInputConvert(ls);
                //把修改后的数据重新放入Redis
                redisList.SetList("GWC_" + UserName, Newls);
                i = 1;
            }
            catch (Exception ex)
            {
                i = 0;
                var Message = ex.Message;
            }

            return i;
        }

        /// <summary>
        /// 清空购物车Redis
        /// </summary>
        /// <returns></returns>
        public void EmptyRedis(string UserName)
        {
            redis.SetList("GWC_" + UserName, null);
        }

        /// <summary>
        /// 显示购物车Reids里的商品数据
        /// </summary>
        /// <returns></returns>
        public List<GwcOutPutModels> GetRedis(string UserName)
        {
            var ls = redis.GetList("GWC_" + UserName);
            if (ls != null)
            {
                ls = ls.OrderBy(x => x.SizeOrColorId).ToList();
                return ls;
            }

            return ls;
        }

        /// <summary>
        /// 批量删除（单个删除也可）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteAllRedis(string id, string UserName)
        {
            int i = 0;

            try
            {
                var ls = redis.GetList("GWC_" + UserName);
                var DelList = ls.Where(x => id.Contains(x.SizeOrColorId.ToString())).ToList();

                //遍历删除
                foreach (var item in DelList)
                {
                    ls.Remove(item);
                }

                //json转换
                var Newls = convert.GwcInputConvert(ls);
                //把修改后的数据重新放入Redis
                redisList.SetList("GWC_" + UserName, Newls);
                i = 1;
            }
            catch (Exception ex)
            {
                i = 0;
                var Message = ex.Message;
            }

            return i;
        }

        /// <summary>
        /// 添加购买数量
        /// </summary>
        /// <param name="gwc"></param>
        public void UpdRedis(int id, int num, string UserName)
        {
            //获取redis数据
            var ls = redis.GetList("GWC_" + UserName);
            //获取需要添加购买数量的商品
            var UpdList = ls.FirstOrDefault(x => x.SizeOrColorId.Equals(id));
            //删除需要添加购买数量的旧数据
            ls.Remove(UpdList);
            //更换购买数量
            UpdList.Num = num;
            //重新添加需要更换购买数量的商品
            ls.Add(UpdList);
            var NewList = convert.GwcInputConvert(ls);
            //重新添加到redis
            redisList.SetList("GWC_" + UserName, NewList);
        }
    }
}
