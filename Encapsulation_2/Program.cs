using Encapsulation;

namespace Encapsulation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.Id = 0;
            //person.IdentityNo = 0;
            person.Name = "Abc";
            //person.getPersonInfo();
            //person.Phone = "";
            //person.MotherName = "";
            //person.FatherName = "";

            Employee employee = new Employee();
            //employee.Id = 0;
            //employee.IdentityNo = 0;
            //employee.getPersonInfo();
            employee.Name = "Abc";
            //employee.Phone = "";
            //employee.MotherName = "";
            //employee.FatherName = "";
            employee.Salary = 0;

        }
    }
}
