
namespace PhoneManagementMicroservice.Services
{
    public interface IPhoneService
    {
        List<Models.Phone> GetPhones();
        Models.Phone? GetPhone(int id);
        Models.Phone? AddPhone(Models.Phone phone);
        Models.Phone? UpdatePhone(Models.Phone phone);
        bool? DeletePhone(int id);
    }
}
