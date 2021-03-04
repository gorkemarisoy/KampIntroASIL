using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Corporate:Customer //bu olay inheritance yani miras denir. //Corporate bir customerdır.
        //classlar ya özellik tutar(prop) ya da operasyon tutar. ikisi aynı anda olmaz
        //Customer gerçek(Individual) yada tüzel(Corporate) olabilir.

        //SOLID 
    {
        //public int Id { get; set; } ORTAK
        //public string CustomerNo { get; set; } ORTAK
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
