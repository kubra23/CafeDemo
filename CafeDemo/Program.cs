using CafeDemo.Abstract;
using CafeDemo.Adapters;
using CafeDemo.Concrete;
using System;

namespace CafeDemo
{ //Kahve dükkanları için müşteri yönetimi yapan bir sistem olacak.Starbucks ve Nero firması için çalışıyoruz..İki firma da müşterilerini veri tabanına kaydetmek istiyor.Starbucks müşterileri kaydederken,mutlaka mernis doğrulaması istyor.Nero müşterileri kaydederken böyle birşey istemiyor.Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {  
                DateOfBirth=new DateTime(1995,10,24),
                FirstName = "Kübra",
                LastName="Moğul",
                Id=1,
                NationalityId="16015932120"
                });
            Console.ReadLine();
        }
    }
}
