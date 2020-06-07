using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia13.DTO.Requests
{
    public class Zamowienie_WyrobRequest
    {
        public int Ilosc { get; set; }
        public string Wyrob { get; set; }
        [StringLength(300, ErrorMessage = "Uwagi nie mogą przekroczyć 300 znaków")]
        public string Uwagi { get; set; }
    }
}
