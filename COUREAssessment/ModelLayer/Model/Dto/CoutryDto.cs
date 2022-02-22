using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.ModelLayer.Model.Dto
{
    public class CoutryDto
    {
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
        public List<CountryDetailDto> countryDetails { get; set; }
    }
    public class CountryDetailDto
    {
        public string @operator { get; set; }
        public string operatorCode { get; set; }
    }
}
