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
        /// <returns></returns>
        Task<int> AddBrank(BrandInput brand);
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
