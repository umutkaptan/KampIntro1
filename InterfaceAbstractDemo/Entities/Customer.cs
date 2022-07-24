using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}






//Senaryo: Kahve dükkanları için müşteri yönetimi yapmak isteyen bir sistem yazıyoruz.Starbuck ve Nero diye iki firmayla çalışıyoruz.İki
//firmada müşterilerini veri tabanına kaydetmek istiyor. Starbuck müşterileri kaydederken mutlaka mernis taraması istiyor.Nero böyle birşey
//istemiyor.Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.