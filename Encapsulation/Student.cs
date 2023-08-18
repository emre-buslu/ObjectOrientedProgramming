namespace Encapsulation
{
    class Student : Person
    {
        public string SchoolName { get; set; }
        private int Grade { get; set; }
        protected int StudentNumber { get; set; }

        public Student()
        {
            //this.Id = 0;
            //this.IdentityNo = 0;
            
            
            
            
            
            
            this.Name = "Abc";
            this.getPersonInfo();
            this.Phone = "";
            this.MotherName = "";
            this.FatherName = "";

            this.Grade = 0;
            this.SchoolName = "";
            this.StudentNumber = 0;
        }
    }
}
