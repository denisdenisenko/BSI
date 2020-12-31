using System;
using System.Collections.Generic;
using System.Text;

namespace BSI
{
    class Woman : Person
    {
        private int id;
        private String name;
        private String lastName;
        public Woman( String n, String ln ,int i) : base (n, ln)
        {
            
            this.id = i;
        }
    }
}
