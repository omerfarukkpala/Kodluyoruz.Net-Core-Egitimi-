using System;

namespace Chapter19
{
    class Program
    {
        //Erişim Belirleyiciler ve Kurucu Fonksiyonlar

        static void Main(string[] args)
        {
            Console.WriteLine("\n***** Çalışan-1 *****");
            Employee employee_1 = new Employee(001, "Faruk", "Pala", "Bilgi  İşlem Departmanı");
            employee_1.EmployeeManager();
            Console.WriteLine("\n***** Çalışan-2 *****");
            Employee employee_2 = new Employee(002, "Ömer", "Pala", "Pazarlama ve Satış");
            employee_2.EmployeeManager();
            Console.WriteLine("\n***** Çalışan-3 *****");
            Employee employee_3 = new Employee("Ömer Faruk", "Pala");
            employee_3.EmployeeManager();
        }
    }

    class Employee
    {
        public Employee(){}// default
        
        public int Id;
        public string FirstName;
        public string LastName;
        public string Department;

        public Employee(int id, string firstName, string lastName, string department)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
        }
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void EmployeeManager()
        {
            Console.WriteLine("Personel ID: {0}", Id);
            Console.WriteLine("Personel adı: {0}", FirstName);
            Console.WriteLine("Personel soyadı: {0}", LastName);
            Console.WriteLine("Personel departmanı: {0}", Department);
        }
    }
}
