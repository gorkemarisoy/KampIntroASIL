using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Individual:Customer //Individual bir customer'dır.
    {
      //  public int Id { get; set; } ORTAK
      //  public string CustomerNo { get; set; } ORTAK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNo { get; set; } //matematiksel işlem yapmıyosan string yapmak mantıklı
    }
}
