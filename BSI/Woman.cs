using System;
using System.Collections.Generic;
using System.Text;

namespace BSI
{
    class Woman : Person
    {
        private int id;
   
        public Woman( String n, String ln ,int i) : base (n, ln)
        {
            
            this.id = i;
        }

        /*public override bool Equals(object obj)
        {
            return this.id == ((Woman)obj).id;
        }*/

        public override bool Equals(object obj)

        {
            if (!(obj is Woman)) 
            {
                return false;
            }
            return base.Equals(obj)  && this.id == ((Woman)obj).id;
        }
    }
}
