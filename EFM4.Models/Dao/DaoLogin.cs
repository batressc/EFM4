using EFM4.Models.Domain;
using System.Collections.Generic;

namespace EFM4.Models.Dao {
    public class DaoLogin {
        private readonly DatabaseOperations _db;

        public DaoLogin() {
            _db = new DatabaseOperations();
        }

        /// <summary>
        /// Obtiene los bytes del valor MD5 de la contraseña de un usuario
        /// </summary>
        /// <returns>Bytes de la contraseña en MD5</returns>
        public byte[]? GetPasswordData(string username) {
            byte[]? data = default;
            string query = "select username, password from Login where username = @username;";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@username", username }
            };
            object[]? rawData = _db.GetFirstOrDefaultData(query, parameters);
            if (rawData != null && rawData[1] is byte[] password) {
                data = password;
            }
            return data;
        }
    }
}
