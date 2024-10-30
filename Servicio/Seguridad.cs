using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Seguridad
    {
        //Métodos de encriptación y desencriptación que utiliza algoritmos de hashing MD5 y TripleDES
        public static string EncriptarMD5(string texto)
        {
            string hash = "hash de encriptado"; //Key de encriptado
            byte[] data = Encoding.UTF8.GetBytes(texto);

            MD5 md5 = MD5.Create(); //Algoritmo de hasheo
            TripleDES tripledes = TripleDES.Create(); //Algoritmo de encriptación/cifrado

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash)); //Set de la key del TDES usando el hash del md5
            tripledes.Mode = CipherMode.ECB; //Configuración del modo de cifrado ECB

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length); //Datos encriptados
            return Convert.ToBase64String(resultado);
        }

        public static string DesencriptarMD5(string textoEnc)
        {
            string hash = "hash de encriptado";
            byte[] data = Convert.FromBase64String(textoEnc);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
