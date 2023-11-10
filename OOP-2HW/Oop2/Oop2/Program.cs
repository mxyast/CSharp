namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "2222222222";
            musteri1.MusteriNo = "12345";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "123456789";
            musteri2.Id = 2;
            musteri2.SirketAdi = "kodlama.io";

           
            //Gerçek - Tüzel
            //solid ......l->soyutlama

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}