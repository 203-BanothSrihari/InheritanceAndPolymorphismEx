using System;

namespace InheritanceAndPolymorphismEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Employee();
            d.GetDepartmentName();
            d.GetNumberOfDepartments();
            d.GetDepartmentDetails();
        }
    }
}
