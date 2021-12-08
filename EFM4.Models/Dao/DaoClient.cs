using EFM4.Models.Domain;
using EFM4.Models.Entity;
using System.Collections.Generic;

namespace EFM4.Models.Dao {
    /// <summary>
    /// Operaciones de acceso a datos para Clientes
    /// </summary>
    public class DaoClient {
        private readonly DatabaseOperations _db;

        public DaoClient() {
            _db = new DatabaseOperations();
        }

        /// <summary>
        /// Obtiene el listado de todos los clientes
        /// </summary>
        /// <returns>Listado de clientes</returns>
        public List<Client> GetAll() {
            List<Client> data = new List<Client>();
            string query = "select id, name, surname from Client;";
            List<object[]> rawClients = _db.GetData(query);
            foreach (object[] client in rawClients) {
                if (client[0] is int id && client[1] is string name && client[2] is string surname) {
                    data.Add(new Client(id, name, surname));
                }
            }
            return data;
        }

        /// <summary>
        /// Agrega un nuevo registro de cliente
        /// </summary>
        /// <param name="data">Datos del cliente</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Insert(Client data) {
            string sql = "insert into Client(id, name, surname) values(@id, @name, @surname);";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", data.Id },
                { "@name", data.Name },
                { "@surname", data.Surname }
            };
            return _db.ExecuteQuery(sql, parameters);
        }

        /// <summary>
        /// Actualiza un registro de cliente
        /// </summary>
        /// <param name="data">Datos del cliente</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Update(Client data) {
            string sql = "update Client set name = @name, surname = @surname where id = @id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", data.Id },
                { "@name", data.Name },
                { "@surname", data.Surname }
            };
            return _db.ExecuteQuery(sql, parameters);
        }

        /// <summary>
        /// Elimina un registro de cliente
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Delete(int id) {
            string sql = "delete from Client where id = @id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", id }
            };
            return _db.ExecuteQuery(sql, parameters);
        }
    }
}
