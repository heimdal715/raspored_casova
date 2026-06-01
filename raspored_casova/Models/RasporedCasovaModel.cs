using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
namespace raspored_casova.Models
{
    [XmlRoot("Rasporedi")]
    public class RasporedCasovaModel
    {
        [XmlElement("Raspored")]
        public List<Raspored> casovi {  get; set; }=new List<Raspored>();
    }
}
