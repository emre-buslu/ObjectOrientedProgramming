using Encapsulation;

namespace Encapsulation_2
{
    internal class Employee : Person
    {
        public int Salary { get; set; }
        public Employee()
        {
            //this.Id = 0;
            //this.IdentityNo = 0;
            this.Name = "Abc";
            this.getPersonInfo();
            //this.Phone = "";
            this.MotherName = "";
            //this.FatherName = "";

            this.Salary = 0;
        }
        
    }
}
