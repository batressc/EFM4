using System.Security.Cryptography;
using System.Text;

namespace EFM4.Models.Domain {
    public class MD5Helper {
        /// <summary>
        /// Genera un arreglo de bytes con la clave MD5 correspondiente a la contraseña
        /// </summary>
        /// <param name="password">Contraseña a generar su MD5</param>
        /// <returns>Arreglo de bytes de clave MD5</returns>
        public byte[] GenerateMD5(string password) {
            byte[] binaryPassword = Encoding.UTF8.GetBytes(password);
            MD5 cypher = MD5.Create();
            return cypher.ComputeHash(binaryPassword);
        }

        /// <summary>
        /// Valida si los datos de dos hashes MD5 son iguales
        /// </summary>
        /// <param name="input">Hash de entrada</param>
        /// <param name="model">Hash contra el cual verificar</param>
        /// <returns>Indica si los hashes son iguales o no</returns>
        public bool ValidateHashes(byte[] input, byte[] model) {
            if (input.Length != model.Length) return false;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] != model[i]) return false;
            }
            return true;
        }
    }
}
