
using DotNetEnv;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Forms;


namespace Desktop.Services
{
    public class LocalidadesApiService
    {
        HttpClient httpClient;
        
        JsonSerializerOptions options;
        public LocalidadesApiService()
        {
            httpClient = SettingHttpClient();
            options = SettingJsonSerializer();
        }
        public async Task<List<Localidad>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las localidades: " + response.ReasonPhrase);
                    return null;
                }
                var json = await response.Content.ReadAsStringAsync();
                var localidades = JsonSerializer.Deserialize<List<Localidad>>(json, options);
                return localidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las localidades desde la Api: " + ex.Message);
                return null;

            }
        }

        public async Task<List<Localidad>?> GetAllDeletedsAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("deleteds");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las localidades eliminadas: " + response.ReasonPhrase);
                    return null;
                }
                var json = await response.Content.ReadAsStringAsync();
                var localidades = JsonSerializer.Deserialize<List<Localidad>>(json, options);
                return localidades;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las localidades eliminadas desde la Api: " + ex.Message);
                return null;

            }
        }

        public async Task<List<Localidad>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                var response = await httpClient.GetAsync($"?filtro={filter}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las localidades: " + response.ReasonPhrase);
                    return null;
                    
                }
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var localidades = JsonSerializer.Deserialize<List<Localidad>>(json, options);
                    return localidades;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las localidades desde la Api: " + ex.Message);
                return null;

            }
           
        }

           

        public async Task<bool> AddLocalidadAsync(Localidad localidad)
        {
            try
            {
                //Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                options = SettingJsonSerializer();

                var json = JsonSerializer.Serialize(localidad, options);
                var localidadJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("", localidadJson);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al crear la Localidad: " + response.ReasonPhrase);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la Localidad desde la Api: " + ex.Message);
                return false;
            }
                

        }

        public async Task<bool> DeleteLocalidadAsync(int id)
        {
            try
            {
                
                var response = await httpClient.DeleteAsync(id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al eliminar la Localidad: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la Localidad desde la Api: " + ex.Message);
                return false;
            }
            
        }

        public async Task<bool> RestoreLocalidadAsync(int id)
        {
            try
            {
                
                var response = await httpClient.PutAsync("restore/" + id, null);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al restaurar la Localidad eliminada: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la Localidad desde la Api: " + ex.Message);
                return false;
            }
        }
        public async Task<bool> UpdateLocalidadAsync(Localidad localidad)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(localidad, options);
                var localidadJson = new StringContent(json, Encoding.UTF8, "application/json");
                string idlocalidad = localidad.Id.ToString();
                var response = await httpClient.PutAsync(idlocalidad, localidadJson);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al actualizar la Localidad: " + response.ReasonPhrase);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la Localidad desde la Api: " + ex.Message);
                return false;

            }
        }

        private HttpClient SettingHttpClient()
        {
            Env.Load("../../../");
            //var urlApi = Environment.GetEnvironmentVariable("URLAPI");
            var urlApi = Environment.GetEnvironmentVariable("URLAPILOCAL");
            //instanciamos el httpClient y lo configuramos para poder utilizarlo en cada uno de los métodos
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlApi+"localidades/");
            //agregamos apikey de la url
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

        private JsonSerializerOptions SettingJsonSerializer()
        {
            return new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
            };
        }

    }
}
