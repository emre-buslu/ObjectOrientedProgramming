using System;

namespace Encapsulation
{
    public class Person
    {
        private int Id { get; set; }
        int IdentityNo { get; set; }
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Name must be longer");
                }
            }
        }
        protected string getPersonInfo()
        {
            return string.Format("Person Id : {0} , Identity Number : {1}", Id, this.IdentityNo);
        }
        internal string Phone { get; set; }
        protected internal string MotherName { get; set; }
        private protected string FatherName { get; set; }

    }
}