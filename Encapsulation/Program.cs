using System;

namespace Encapsulation
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
            person.Phone = "";
            person.MotherName = "";
            //person.FatherName = "";

            Student student = new Student();
            //student.Id = 0;
            //student.IdentityNo = 0;
            student.Name = "Abc";
            //student.getPersonInfo();
            student.Phone = "";
            student.MotherName = "0";
            //student.FatherName = "";

            //student.Grade = 0;
            //student.StudentNumber = 0;
            student.SchoolName = "";

        }
    }
}
