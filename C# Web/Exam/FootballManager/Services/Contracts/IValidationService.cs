namespace FootballManager.Services.Contracts
{
    public interface IValidationService
    {
        ICollection<string> ValidateModel(object model);
    }
}
