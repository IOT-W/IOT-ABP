using abpapi.ILoginService.DTO;
using System;
using abpapi.Login;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace IOT.electricity.ILogin
{

    public interface ILoginService : IApplicationService
    {
        //判断账号是否存在
        Task<int> ExistUser(string userid);
        // 注册账户
        Task<int> AddLogin(logintable userLogins);
        //登录
        Task<logintableDTO> Getlogin(string account, string pwd);
        // 支付宝请求用户授权码
        public string RequestUserCode(string rCode);
        // 支付宝获取用户信息
        public string GetUserInfo(string authCode);
    }
}
