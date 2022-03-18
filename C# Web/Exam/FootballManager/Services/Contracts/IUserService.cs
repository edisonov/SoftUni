using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Services.Contracts
{
    public interface IUserService
    {
        List<string> CreateUser(RegisterFormViewModel model);

        (string userId, string error) Login(LoginFormViewModel model);

    }
}
