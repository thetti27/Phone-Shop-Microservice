using PhoneManagementMicroservice.Data;
using PhoneManagementMicroservice.Models;


namespace PhoneManagementMicroservice.Services
{
    
    public class PhoneService : IPhoneService
    {
  
        public List<Models.Phone> GetPhones()
        {
            return PhoneMockDataService.Phones;
        }
        //------------------------------------------
        public Phone? GetPhone(int id)
        {
            return PhoneMockDataService.Phones.FirstOrDefault(x => x.Id == id);
        }
        //--------------------------------------------
        public Models.Phone? AddPhone(Phone phone)
        {
            PhoneMockDataService.Phones.Add(phone);
            return phone;
        }

        //--------------------------------------------
        public Models.Phone? UpdatePhone(Phone phone)
        {
            Models.Phone selectedPhone = PhoneMockDataService.Phones.FirstOrDefault(x => x.Id == phone.Id);
            if (selectedPhone != null)
            {
                selectedPhone.Brand = phone.Brand;
                selectedPhone.Model = phone.Model;
                selectedPhone.OS = phone.OS;
                selectedPhone.ReleaseYear = phone.ReleaseYear;
                return selectedPhone;
            }
            return selectedPhone;
        }   


        public bool? DeletePhone(int id)
        {
            Models.Phone selectedPhone= PhoneMockDataService.Phones.FirstOrDefault(x => x.Id == id);
            if (selectedPhone != null)
            {
                PhoneMockDataService.Phones.Remove(selectedPhone);
                return true;
            }
            return false;
        }
    }
}
