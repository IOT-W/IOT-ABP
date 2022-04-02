using IOT.electricity.ClassificationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpapi.Brank
{
    public interface IBrankServices:IApplicationService
    {
        /// <summary>
        /// 添加品牌管理
        /// </summary>
        /// <param name="BName"></param>
        /// <param name="BImg"></param>
        /// <param name="BSite"></param>
        /// <param name="BDescribe"></param>
        /// <param name="BSort"></param>
        /// <param name="BType"></param>
        /// <returns></returns>
        Task<Brand> AddBrank(string BName, string BImg, string BSite, string BDescribe, int BSort, bool BType);
        /// <summary>
        /// 品牌列表
        /// </summary>
        /// <returns></returns>
        Task<List<Brand>> GetBrad();
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        Task<Guid> ProModi(BrandOut brand);
        Task DeleBrad(Guid guid);
    }
}
