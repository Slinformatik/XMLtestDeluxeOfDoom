using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLtestDeluxeOfDoom
{
    internal class Actors : List<Actor>
    {
        public static Actors CreateActors(XmlNode xml)
        {
            Actors res = new Actors();
            foreach (XmlNode element in xml)            
                res.Add(new Actor(element.InnerXml.Trim()));  
            return res;
        }
    }
}
