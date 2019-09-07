using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemadbs.DAL
{
    public class DataContexFactory
    {
        private static SistemaFormDataContext dataContext;
        public static SistemaFormDataContext DataContext
        {
            get
            {
                if(dataContext == null)
                    dataContext = new SistemaFormDataContext();
                    return dataContext;
                
            }
        }
   
    }
}
