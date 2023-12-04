using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 13.1");
            BankAccount account = new BankAccount("12345", "Savings", "Adel");
            Console.WriteLine(account.AccountNumber);  // Вывод: "12345"
            Console.WriteLine(account.AccountType);    // Вывод: "Savings"

            BankTransaction transaction = new BankTransaction(DateTime.Now, 1000);
            Console.WriteLine(transaction.TransactionDate);  // Вывод: текущая дата и время
            Console.WriteLine(transaction.Amount);          // Вывод: 1000
            Console.WriteLine();


            Console.WriteLine("Упр 13.2");
            BankAccount account1 = new BankAccount("123456789", "Savings", "Adel");
            account1.Deposit(100); // Внесение 100 на счет
            account1.Withdraw(50); // Снятие 50 со счета
            BankTransaction transaction1 = account1[0]; 
            BankTransaction transaction2 = account1[1]; 
            Console.WriteLine();


            Console.WriteLine("Упр 13.3");
            Building building = new Building();

            building.BuildingNumber = 1;
            building.Height = 50;
            building.Floors = 10;
            building.Apartments = 100;
            building.Entrances = 2;

            Console.WriteLine($"Номер дома: {building.BuildingNumber}");
            Console.WriteLine($"высота дома: {building.Height}");

            double floorHeight = building.CalculateFloorHeight();
            Console.WriteLine($"Высота этажа: {floorHeight}");

            double apartmentsPerEntrance = building.CalculateApartmentsPerEntrance();
            Console.WriteLine($"Квартир в подъезде: {apartmentsPerEntrance}");

            double apartmentsPerFloor = building.CalculateApartmentsPerFloor();
            Console.WriteLine($"Квартир на этаже: {apartmentsPerFloor}");
            Console.WriteLine();


            Console.WriteLine("Упр 13.4");
            BuildingCollection buildingCollection = new BuildingCollection();

            buildingCollection[0] = new Building { BuildingNumber = 1, Height = 50, Floors = 10, Apartments = 100, Entrances = 2 };
            buildingCollection[1] = new Building { BuildingNumber = 2, Height = 60, Floors = 12, Apartments = 120, Entrances = 3 };

            Building building1 = buildingCollection[0];
            Building building2 = buildingCollection[1];

            Console.WriteLine($"Дом: #{building1.BuildingNumber}, высота: {building1.Height}");
            Console.WriteLine($"Дом: #{building2.BuildingNumber}, высота: {building2.Height}");
            Console.WriteLine();


            Console.WriteLine("Упр 14.1");
            BankAccount account3 = new BankAccount("123456789", "Savings", "Adel");
            account3.Deposit(100);
            account3.DumpToScreen(); // Метод будет вызван только при наличии символа условной компиляции DEBUG_ACCOUNT
            Console.WriteLine();


            Console.WriteLine("Упр 14.3");
            Type type = typeof(Building);
            DeveloperInfoAttribute attribute = (DeveloperInfoAttribute)Attribute.GetCustomAttribute(type, typeof(DeveloperInfoAttribute));

            if (attribute != null)
            {
                Console.WriteLine($"Developer: {attribute.DeveloperName}");
                Console.WriteLine($"Organization: {attribute.OrganizationName}");
            }
            else
            {
                Console.WriteLine("Developer info not found");
            }
            Console.ReadKey();
        }
    }
}
