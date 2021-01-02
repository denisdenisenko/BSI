using System;
using System.Collections.Generic;
using System.Text;

namespace BSI
{
    class Singletone
    {
        private static Singletone instance;

        public  Singletone() {}

        public Singletone getInstance ()
        {
            if (instance == null) 
            {
                instance = new Singletone();

            }

            return instance;
        }

        

    }
}
