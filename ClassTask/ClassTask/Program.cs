using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            Student pasha = new Student("Pavel", "Gnom", 19, "Ukraine", "Kherson", "Nekrasova", 21);
            Student slava = new Student("Slava", "Bortnik", 18, "Ukraine", "Kherson", "John Govard", 76, 5);

            Teacher valera = new Teacher("Valera", "Bull", 19, "Ukraine", "Kherson", "Ushakova", 122, 4);

            valera.AddStudent(pasha);
            valera.AddStudent(slava);
            valera.InfoTeacher();
            valera.RemoveStudent(pasha);
            valera.InfoTeacher();
            
        }
    }
}
