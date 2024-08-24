using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace P6Assets_KeirynS.Models
{
    public class UserRole
    {
        //cuando queremos comunicarnos con el API hay dos formas más usadas

        //1. Con las librerias nativas de .NET

        //2. O usando herramientas de tereceros

        //En lo personal he encontrado más facil y eficiente el uso de
        //RestSharp

        public RestRequest? Request { get; set; }

        public int UserRoleId { get; set; }

        public string UserRoleDescription { get; set; } = null!;

        //FUNCIONES

        //cargar todos los roles de usuario

        public async Task<List<UserRole>> GetUserRolesAsync()
        {
            try
            {
                //tenemos que armar la ruta completa de consumo del API
                //para eso tenemos en WebAPIConnection la ruta base del API
                //y acá la completamos

                string RouterSurfix = string.Format("UserRoles");

                //armamos la ruta completa de consumo del API 

                string URL = Services.WebAPIConnection.ProductionURLPrefrix + RouterSurfix;
                //ahora tenemos la ruta completa lista 

                //configuramos el request 

                RestClient client = new RestClient(URL); //puente entre el API y la APP

                Request = new RestRequest(URL, Method.Get);

                //agregamos el método de seguridad, en este caso tenemos APIkey

                Request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);

                //ahora ejecutamos la llamada al API

                RestResponse response = await client.ExecuteAsync(Request);

                //validamos que todo haya salido bien

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //Si obtuvimos respuesta positiva desde el API 
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) 
            {
                string ErrorMsg = ex.Message;
                throw;
            }

        }

    }
}
