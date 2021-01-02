using System;
using System.Collections.Generic;
using System.Text;

namespace BSI
{
    class Man : Person
    {
        private int id;

        public Man(String n, String ln, int i) : base(n, ln) 
        {
            this.id = i;
        }

        public override string ToString()
        {
            return base.ToString() + " The person's ID is : " +   this.id.ToString();
        }
    }
}
