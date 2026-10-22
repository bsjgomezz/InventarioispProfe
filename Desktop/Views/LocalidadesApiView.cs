using Desktop.Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class LocalidadesApiView : Form
    {
        LocalidadesApiService localidadesService = new LocalidadesApiService();
        Localidad? localidadModificada;
        public LocalidadesApiView()
        {
            InitializeComponent();
            _=LoadLocalidades();
           // _= LoadProvincias();
        }

        private async Task LoadLocalidades()
        {
            var localidades = await localidadesService.GetAllAsync();
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;


            }
        }

        //private async void btnBuscarL_Click(object sender, EventArgs e)
        //{
        //    var localidades = await localidadesService.GetAllWithFilterAsync(txtBuscarL.Text);
        //    if (localidades != null)
        //    {
        //        dataGridLocalidades.DataSource = localidades;
        //    }
        //}


    }
}
