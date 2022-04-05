using abpapi.Brank;
using IOT.electricity.ClassificationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;


using Volo.Abp.Domain.Repositories;

namespace abpapi.Brans
{
    public class BrankServices:ApplicationService,IBrankServices
    {
        private readonly IRepository<Brand, Guid> db;
        public BrankServices(IRepository<Brand,Guid> db)
        {
            this.db = db;
        }
        public async Task<IOT.electricity.ClassificationType.Brand> AddBrank(string BName, string BImg, string BSite, string BDescribe, int BSort, bool BType)
        {
            var list = await db.InsertAsync(new Brand { BName = BName, BImg = BImg, BSite = BSite, BDescribe = BDescribe, BSort = BSort, BType = BType });
            return new Brand
            {
                BName = list.BName,
                BImg = list.BImg,
                BSite = list.BSite,
                BDescribe = list.BDescribe,
                BSort = list.BSort,
                BType = list.BType
            };
        }
        /// <summary>
        /// 品牌修改
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Guid> ProModi(BrandOut brand)
        {
            var list = ObjectMapper.Map<BrandOut, Brand>(brand);
            var lis = await db.UpdateAsync(list);
            return lis.Id;
        }
        /// <summary>
        /// 获取品牌信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<Brand>> GetBrad()
        {
            var list = await db.GetListAsync();
            return list;
        }
        /// <summary>
        /// 品牌删除
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task DeleBrad(Guid guid)
        {
            await db.DeleteAsync(guid);
        }
    }
}
