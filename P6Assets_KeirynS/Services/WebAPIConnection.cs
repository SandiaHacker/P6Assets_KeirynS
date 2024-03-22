using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Assets_KeirynS.Services
{
    public static class WebAPIConnection
    {
        //acá definimos la ruta raíz del URL del servicio web (API Resst)
        //a esta raíz, que llamaremos PREFIJO, se le debe adjuntar 
        //el resto de la ruta URL, que llamaremos SUFIJO, para cada 
        //endpoint que vayamos a usar.

        //Además, es importante indicar que normalmente los APIs
        //trabajan en 2 veresiones: Pruebas y Producción

        public static string ProductionURLPrefrix = "http://192.168.18.9:45455/api/";

        public static string TestingURLPrefix = "http://192.168.18.9:45455/api/";

        //además de la raíz URL acá vamos a indicar cual es la AP Key que deberiamos
        //usar para consumir los endpoints

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "KeirynSP6ApiKey12342234";
        
       


    }
}
