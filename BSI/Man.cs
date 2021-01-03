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

        public int getID ()
        {
            return this.id;
        }

        public void setId(int newID) 
        {
            this.id = newID;
        }

        public override string ToString()
        {
            return base.ToString() + " The person's ID is : " +   this.id.ToString();
        }

        public override bool Equals(object obj)

        {
            if (!(obj is Man))
            {
                return false;
            }
            return base.Equals(obj) && this.id == ((Man)obj).id;
        }
    }
}
