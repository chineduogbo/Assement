using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.ModelLayer.Model
{

    public class Country
    {
        public int Id { get; set; }
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
    }


}
