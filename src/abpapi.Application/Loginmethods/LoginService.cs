using abpapi.ILoginService.DTO;
using abpapi.Login;
using IOT.electricity.ILogin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace IOT.electricity.Loginmethods
{
    public class LoginService : ApplicationService, ILoginService
    {
        private readonly IRepository<logintable, Guid> repository;

        public LoginService(IRepository<logintable, Guid> repository )
        {
            this.repository = repository;
        }

        [HttpPost, Route("api/AddLogin")]
        public async Task<logintableDTO> AddLogin(logintable userLogins)
        {
            var emp =  await repository.InsertAsync(userLogins);
            return new logintableDTO
            {
                Login_account = emp.Login_account,
                Login_pwd = emp.Login_pwd,
                Login_name = emp.Login_name,
                Login_state = emp.Login_state,
            };
        }

        [HttpGet,Route("api/Login")]
        public async Task<logintableDTO> Getlogin(string name, string pwd)
        {
            var emp = await repository.GetAsync(x => x.Login_account.Equals(name) & x.Login_pwd.Equals(pwd));

            var list = ObjectMapper.Map<logintable, logintableDTO>(emp);

            return list;
        }
    }
}
