namespace Oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager =new TasitKrediManager();
            IKrediManager konutKrediManager =new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new DataBaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvururYap(new EsnafKrediManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}