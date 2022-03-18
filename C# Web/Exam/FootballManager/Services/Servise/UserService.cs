using FootballManager.Data.Common;
using FootballManager.Data.Models;
using FootballManager.Services.Contracts;
using FootballManager.ViewModels;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        private readonly IValidationService validationService;

        public UserService(IRepository _repo, IValidationService _validationService)
        {
            repo = _repo;
            validationService = _validationService;
        }

        public List<string> CreateUser(RegisterFormViewModel model)
        {
            ICollection<string> modelErrors = validationService.ValidateModel(model);

        }

        public (string userId, string error) Login(LoginFormViewModel model)
        {
            string modelErrors = string.Empty;

            var userId = repo.All<User>()
                .Where(u => u.Username == model.Username && u.Password == CalculateHash(model.Password))
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                modelErrors = "Wrong Login Information, UserName or Password are incorect";
            }

            return (userId, modelErrors);
        }



        //public string GetUsername(string userId)
        //{
        //    return repo.All<User>()
        //       .FirstOrDefault(u => u.Id == userId).Username;
        //}

        //public string Login(LoginFormViewModel model)
        //{
        //    var user = repo.All<User>()
        //        .Where(u => u.Username == model.Username)
        //        .Where(u => u.Password == CalculateHash(model.Password))
        //        .SingleOrDefault();

        //    return user?.Id;
        //}

        //public (bool registered, string error) Register(RegisterFormViewModel model)
        //{
        //    bool registered = false;
        //    string error = null;

        //    var (isValid, validationError) = validationService.ValidateModel(model);

        //    if (!isValid)
        //    {
        //        return (isValid, validationError);
        //    }

        //    User user = new User()
        //    {
        //        Email = model.Email,
        //        Password = CalculateHash(model.Password),
        //        Username = model.Username,
        //    };

        //    try
        //    {
        //        repo.Add(user);
        //        repo.SaveChanges();
        //        registered = true;
        //    }
        //    catch (Exception)
        //    {
        //        error = "Could not save user in DB";
        //    }

        //    return (registered, error); 
        //}

        private string CalculateHash(string password)
        {
            byte[] passworArray = Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(passworArray));
            }
        }
    }
}
