using abpapi.ClassificationType;
using abpapi.Spuk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abpapi.Spuc
{
    public class SpuServices : ApplicationService, ISpuServices
    {
        private readonly IRepository<Spu, Guid> db;
        public SpuServices(IRepository<Spu, Guid> db)
        {
            this.db = db;
        }
        public async Task<Spu> CreateSpu(SpuInput spu)
        {
            var goods = ObjectMapper.Map<SpuInput, Spu>(spu);
            var good = await db.InsertAsync(goods);
            return good;
        }
    }
}
