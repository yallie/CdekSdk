﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CdekApi.DataContracts
{
    /// <summary>
    /// Represents source or destination location.
    /// EN: https://api-docs.cdek.ru/63347458.html
    /// RU: https://api-docs.cdek.ru/63345519.html
    /// </summary>
    [DataContract]
    public class Location
    {
        [DataMember(Name = "code")]
        public int CityCode { get; set; } // as returned by GetCities method

        [DataMember(Name = "postal_code")]
        public string PostalCode { get; set; } // 344017

        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; } // "RU"

        [DataMember(Name = "city")]
        public string City { get; set; } // "Москва"

        [DataMember(Name = "address")]
        public string Address { get; set; }
    }
}
