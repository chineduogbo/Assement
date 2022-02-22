using COUREAssessment.ModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.DataLayer
{
    public class Data
    {
      public List<Country> countries = new List<Country>() { new() { Id = 1,countryCode = "234",countryIso = "NG",name= "Nigeria"},
        new (){ Id=2,countryCode="233",countryIso="GH",name="Ghana"},
        new (){ Id=3,countryCode="229",countryIso="Benin Republic",name="BN"},
        new (){ Id=4,countryCode="225",countryIso="Côte d'Ivoire",name="CIV"}};
        public List<CountryDetail> countryDetails = new List<CountryDetail>()
        {
            new(){Id=1,CountryId=1,@operator ="MTN Nigeria",operatorCode ="MTN NG"},
            new(){Id=2,CountryId=1,@operator ="Airtel Nigeria",operatorCode ="ANG"},
            new(){Id=3,CountryId=1,@operator ="9 Mobile Nigeria",operatorCode ="ETN"},
            new(){Id=4,CountryId=1,@operator ="Globacom Nigeria",operatorCode ="GLO NG"},
            new(){Id=5,CountryId=2,@operator ="Vodafone Ghana",operatorCode ="Vodafone GH"},
            new(){Id=6,CountryId=2,@operator ="MTN Ghana",operatorCode ="MTN Ghana"},
            new(){Id=7,CountryId=2,@operator ="Tigo Ghana",operatorCode ="Tigo Ghana"},
            new(){Id=8,CountryId=3,@operator ="MTN Benin",operatorCode ="MTN Benin"},
            new(){Id=9,CountryId=3,@operator ="Moov Benin",operatorCode ="Moov Benin"},
            new(){Id=10,CountryId=4,@operator ="MTN Côte d'Ivoire",operatorCode ="MTN CIV"}};
    }
}
