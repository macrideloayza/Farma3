using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Farma.pe.Resources;
using Farma.pe.models;

using Newtonsoft.Json;
using Farma.pe.FarmaciaService;

namespace Farma.pe
{
    public partial class BuscarMedicamentos : PhoneApplicationPage
    {
        


        public BuscarMedicamentos()
        {
            InitializeComponent();
            try
            {
                listarMedicamentos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void listarMedicamentos()
        {

            try
            {
                FarmaciaService.Service1Client servicioFarma = new FarmaciaService.Service1Client();
                servicioFarma.listarMedicamentosCompleted += new EventHandler
                    <FarmaciaService.listarMedicamentosCompletedEventArgs>(Listar);
                servicioFarma.listarMedicamentosAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            /*try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/api/MEDICAMENTO/id=1");

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Buscar);
                wc.DownloadStringAsync(url);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/



            //servicioFarma.listarMedicamentosCompleted += new EventHandler
            //    <ser>(Listar);
            //proxy.ListarDatosAsync();
        }

         void Listar(object sender, listarMedicamentosCompletedEventArgs e)
        {
            if (e.Result.Count > 0)
            {
                lb.ItemsSource = e.Result;
            }
            else
            {
                MessageBox.Show("No se pudo recuperar datos");
            }
        }


    
    }
}