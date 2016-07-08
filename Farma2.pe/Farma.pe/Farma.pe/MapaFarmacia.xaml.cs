using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
using Microsoft.Phone.Maps.Toolkit;
using System.Device.Location;
using System.Windows.Media;
using System.Collections.ObjectModel;
using Farma.pe;

namespace Farma.pe
{
    public partial class MapaFarmacia : PhoneApplicationPage
    {
        public MapaFarmacia()
        {
            InitializeComponent();
            GeoCoordinate cordenada = new GeoCoordinate(-12.122274, -77.038395);

            MapaMain.Center = cordenada;
            MapaMain.ZoomLevel = 20;
            MapaMain.CartographicMode = Microsoft.Phone.Maps.Controls.MapCartographicMode.Hybrid;
            ObservableCollection<PushPinData> pushpinList = new ObservableCollection<PushPinData>();

          /*  
            PushPinData pushPin = new PushPinData();
            pushPin.Location = new GeoCoordinate(-12.122274, -77.038395);
            pushPin.Text = "Prueba";
            SolidColorBrush color = new SolidColorBrush(Colors.Red);
            pushpinList.Add(pushPin);


            MapaMain.Loaded += (s, e) =>
            {
                ObservableCollection<DependencyObject> children = MapExtensions.GetChildren(MapaMain);
                var pushPinLayer = children.FirstOrDefault(x => x.GetType() == typeof(MapItemsControl)) as MapItemsControl;
                pushPinLayer.ItemsSource = pushpinList;
            };*/
        }
    }
}