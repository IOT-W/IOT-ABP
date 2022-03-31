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
        Task<logintableDTO> AddLogin(logintable userLogins);
        Task<logintableDTO> Getlogin(string account, string pwd);
    }
}
