using System;

namespace Dictionary
{
    public class Details
    {
        public string name;
        public int id;
        public double gpa;
        public string major;
        public string email;

        public Details(string name, int id, double gpa, string major, string email){
            this.name = name;
            this.id = id;
            this.gpa = gpa;
            this.major = major;
            this.email = email;
        }
    }
}
