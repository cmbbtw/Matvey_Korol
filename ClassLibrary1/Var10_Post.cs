using System;

namespace ClassLibrary1
{
    public class Var10_Post
    {
        private string Name;
    
        public string name
        {
            get { return Name; }
            set => Name = value;
        }
        private string Salary;
    
        public string salary
        {
            get { return Salary; }
            set => Salary = value;
        }
    
        private Var10_Post(string Name, string salary, string division)
        {
            name = Name;
            Salary = salary;
        }
        internal static Var10_Post ToString(string value)
        {
            throw new NotImplementedException();
        }
    }
    
}