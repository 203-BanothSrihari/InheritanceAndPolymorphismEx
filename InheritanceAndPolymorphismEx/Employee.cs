using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphismEx
{
    public class Employee : Department
    {
    
        public void GetFirstName()
        {
            string name1 = "Banoth";
            Console.WriteLine("The first name of the employee is : " + name1);
        }
        public void GetLastName()
        {
            string name2 = "Srihari";
            Console.WriteLine("The last name of the employee is : " + name2);
        }
        public Employee()
        {
            Console.WriteLine("This is Employee Constructor");
        }
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("This method is used for department class to override the methods of employee class by using virtual and override method.");
        }
    }
}
