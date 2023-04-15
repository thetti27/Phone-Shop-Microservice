using PhoneManagementMicroservice.Models;

namespace PhoneManagementMicroservice.Data
{
    public static class PhoneMockDataService
    {
        public static List<Models.Phone> Phones = new List<Models.Phone>()
        {
            new Phone { Id = 1, Brand = "Apple", Model = "iPhone 13 Pro Max", OS = "iOS 15", ReleaseYear = 2021 },
            new Phone { Id = 2, Brand = "Samsung", Model = "Galaxy S21 Ultra", OS = "Android 11", ReleaseYear = 2021 },
            new Phone { Id = 3, Brand = "OnePlus", Model = "9 Pro", OS = "OxygenOS 11", ReleaseYear = 2021 },
            new Phone { Id = 4, Brand = "Google", Model = "Pixel 6 Pro", OS = "Android 12", ReleaseYear = 2021 },
            new Phone { Id = 5, Brand = "Xiaomi", Model = "Mi 11 Ultra", OS = "MIUI 12.5", ReleaseYear = 2021 }
        };
    }
}
