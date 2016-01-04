using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Xml;
using System.Net;

namespace VehicleLibrary
{
    public class Geolocator
    {
        public Geolocator()
        {
        }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Add { get; set; }

        public void GeoCode()
        {

            StreamReader sr = null;

            string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" +
            this.Add + "&sensor=true");

            WebClient wc = new WebClient();
            try
            {
                sr = new StreamReader(wc.OpenRead(url));
            }
            catch (Exception ex)
            {
                throw new Exception("The Error Occured" + ex.Message);
            }

            try
            {
                XmlTextReader xmlReader = new XmlTextReader(sr);
                bool latread = false;
                bool longread = false;

                while (xmlReader.Read())
                {
                    xmlReader.MoveToElement();
                    switch (xmlReader.Name)
                    {
                        case "lat":

                            if (!latread)
                            {
                                xmlReader.Read();
                                this.Latitude = xmlReader.Value.ToString();
                                latread = true;

                            }
                            break;
                        case "lng":
                            if (!longread)
                            {
                                xmlReader.Read();
                                this.Longitude = xmlReader.Value.ToString();
                                longread = true;
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured" + ex.Message);
            }
        }
    }
}
