using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Farma.pe
{
    public class PushPinData
    {

       public GeoCoordinate Location { get; set; }
       public string Text { get; set; }
       public SolidColorBrush DisplayBrush { get; set; }

    }
}
