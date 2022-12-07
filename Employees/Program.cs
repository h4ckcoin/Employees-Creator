namespace Employees
{
    internal class Program
    {
        static employee _calisan;
        static void Main(string[] args)
        {
            CreateEmploy();
            GetEmploye();
        }
        static void CreateEmploy()
        {
            // 1. Çalısan olusturulacak , isim soyisim , departman , maaş ,  inputu alınacak.    
            // 2. class üzerinden inputlardan çalışan oluşturulacak.
            // 3. 


            Console.Write("Ad : ");
            string Ad = Console.ReadLine();

            Console.Write("Soyad : ");
            string Soyad = Console.ReadLine();

            Console.Write("Maas : ");
            string Maas = Console.ReadLine();

             _calisan = new employee()
            {
                ad = Ad,
                soyad = Soyad,
                maas = Maas,
            };

           
        }
        static void GetEmploye()
        {
            Console.WriteLine("*** Employe Creating ***");
            Console.WriteLine($"Ad: {_calisan.ad}\n" +
                $"Soyad : {_calisan.soyad}\n" +
                $"Maas : {_calisan.maas}\n"
                );

        }



    }
}