using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.ILoginService.DTO
{
    public class logintableDTO 
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        public string Login_account { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Login_pwd { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string Login_name { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        public int Login_state { get; set; }
    }
}
