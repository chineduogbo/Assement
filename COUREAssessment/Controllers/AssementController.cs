using COUREAssessment.DataLayer;
using COUREAssessment.ModelLayer;
using COUREAssessment.ModelLayer.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssementController : ControllerBase
    {
        [HttpGet]
        public CoutryDto GetCountryDetails(string PhoneNumber)
        {
            CoutryDto model = null;
            Data data = new Data();
            string phonenocountrycode = PhoneNumber.Substring(0, 3);
            var countries = data.countries.ToList().Where(x => x.countryCode.Contains(phonenocountrycode)).FirstOrDefault();
            if (countries?.Id > 0)
            {
                model = new CoutryDto();
                model.countryCode = countries.countryCode;
                model.countryIso = countries.countryIso;
                model.name = countries.name;
               model.countryDetails = data.countryDetails.Where(x => x.CountryId == countries.Id).Select(x => new CountryDetailDto() { @operator = x.@operator, operatorCode = x.operatorCode }).ToList();
            }
            return model;
        }
        [HttpPost]
        public int SumArray([FromBody] int[] numbers )
        {
            int TotalNumber = 0;
            foreach(var items in numbers)
            {
               
                if (Utility.IsEven(items))
                    TotalNumber += 1;
                else
                    TotalNumber += 3;
                if (Utility.Contains8(items))
                    TotalNumber += 5;
            }
            return TotalNumber;
        }
      
   }
}
