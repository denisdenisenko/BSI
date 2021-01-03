using System;
using System.Collections.Generic;
using System.Text;

namespace BSI
{
    class Person
    {
        private String name;
        private String lastName;

        public Person(String n, String ln) 
        {
            this.name = n;
            this.lastName = ln;
        }

        public override string ToString()
        {
            return "The person's name is : " + this.name.ToString() + " " +  "The person's Last Name is : " + this.lastName.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
                return this.name == ((Person)obj).name && this.lastName == ((Person)obj).lastName;
        }
    }
}
