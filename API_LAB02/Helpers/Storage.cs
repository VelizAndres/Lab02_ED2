using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LAB02.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }
    
        //public static mTree MoviesTree = new mTree();
    }
}
