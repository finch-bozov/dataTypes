using System;

namespace employeeData
{
    class employeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Gosho";
            string lastName = "Peshoto";
            byte age = 35;
            string gender = "M";
            ulong personalID = 8306112507;
            ulong employeeNumber = 27569999;

            Console.WriteLine("First Name of employee is {0} \nLast name is {1}\nAge = {2} \nGender = {3} \nPersonal ID = {4} \nEmployee Number = {5}", firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
