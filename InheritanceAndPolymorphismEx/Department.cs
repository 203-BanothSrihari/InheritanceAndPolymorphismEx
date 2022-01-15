using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphismEx
{
   public class Department
    {
        public Department()
        {
            Console.WriteLine("This is Department Constructor");
        }
        public void GetDepartmentName()
        {
            string name = "Information Technology";

            Console.WriteLine("Department name of the employee is :" +name);
        }
        public void GetNumberOfDepartments()
        {
            int number = 5;
            Console.WriteLine("The number of departments are present in the company are :" +number);
        }
        public virtual void GetDepartmentDetails()
        {

            Console.WriteLine("This method is used to get details of the employee details : ");
        }
    }
}
