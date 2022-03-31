using System;

namespace Chapter20
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Encapsulation kavramı, bir özeliği başka sınıflardan saklamak ya da korumaktır.
            
            Student student_1 = new Student(010, "Faruk", "Pala",  26, 4);
            Student student_2 = new Student(020, "Ömer", "Pala", 24, 1);
            student_1.StudentConsole();
            student_2.StudentConsole();

            Console.WriteLine("\n***** Yeni Dönem *****");
            student_1.increaseGrade();// öğrenciyi sınıf atlat
            student_1.StudentConsole();
            student_2.decreaseGrade();// öğrenciyi birinci sınıftan düşürmeyi dene
            student_2.StudentConsole();

        }
    }
    class Student
    {
            private int no;
            private string firstName;
            private string LastName;
            private int age;
            private int 	grade;
            public int No { get => no; set => no = value; }// set kısımları silinirse dışarıdan ekleme yapılamaz
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName1 { get => LastName; set => LastName = value; }
            public int Age { get => age; set => age = value; }
            
            // -- önemli! -- start
            public int Grade
            {
                get => grade;
                set
                {
                    if(value <= 1)
                    {
                        Console.WriteLine("Sınıf değeri birden az olamaz!");
                        grade = 1;
                    }
                    else
                    grade = value;
                } 
            }
            // -- önemli! -- end
        public Student(){}
        public Student(int no, string firstName, string lastName1, int age, int grade)
        {
            No = no;
            FirstName = firstName;
            LastName1 = lastName1;
            Age = age;
            Grade = grade;
        }
        public void StudentConsole()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Numarası     :{0}", this.No);
            Console.WriteLine("Öğrenci Adı          :{0}", this.FirstName);
            Console.WriteLine("Öğrenci Soyadı       :{0}", this.LastName);
            Console.WriteLine("Öğrenci Yaşı         :{0}", this.Age);
            Console.WriteLine("Öğrenci Sınıfı       :{0}", this.Grade);
        }
        public void increaseGrade()
        {
            this.Grade = this.Grade +1;
        }
        public void decreaseGrade()
        {
            this.Grade = this.Grade -1;
        }
    }
}