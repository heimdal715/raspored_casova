using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;


namespace raspored_casova.Models
{
    [XmlRoot("Raspored")]
    public class Raspored
    {
        [XmlElement("Rbr")]
        public int Rbr { get; set; }

        [XmlElement("DanUNedelji")]
        public string DanUNedelji { get; set; }

        [XmlElement("Predmet")]
        public string Predmet { get; set; }
    }
}
