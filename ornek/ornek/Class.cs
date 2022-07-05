using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List
{
    public class Class
    {
        public int Id { get; set; }
        public string katagori { get; set; }
        public string urunAdi { get; set; }
        public float Fiyat { get; set; }





        public int OrderBy { get; set; }

        internal static object orderby(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

       
    }
}
