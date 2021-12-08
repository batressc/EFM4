using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace EFM4.Models.Domain {
    /// <summary>
    /// Realiza las operaciones de bajo nivel de acceso a datos
    /// </summary>
    public class DatabaseOperations {
        private readonly SqlConnection _connection;

        public DatabaseOperations() {
            _connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=EFM4;User ID=sa;Password=<<ownPassword>>");
        }

        /// <summary>
        /// Ejecuta la sentencia SQL especificada sin parámetros y devuelve una lista de objetos
        /// </summary>
        /// <param name="query">Sentencia SQL a ejecutar</param>
        /// <param name="parameters">Parámetros de la sentencia SQL</param>
        /// <returns>Listado de objetos según el query</returns>
        public List<object[]> GetData(string query, Dictionary<string, object>? parameters = null) {
            List<object[]> data = new List<object[]>();
            if (!string.IsNullOrWhiteSpace(query)) {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection)) {
                    if (parameters != null) {
                        foreach (KeyValuePair<string, object> parameter in parameters) {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) {
                        object[] dataRow = new object[dataReader.FieldCount];
                        for (int i = 0; i < dataReader.FieldCount; i++) {
                            dataRow[i] = dataReader[i];
                        }
                        data.Add(dataRow);
                    }
                }
                if (_connection.State == ConnectionState.Open) {
                    _connection.Close();
                }
            }
            return data;
        }

        /// <summary>
        /// Ejecuta la sentencia SQL especificada sin parámetros y el primer dato obtenido
        /// </summary>
        /// <param name="query">Sentencia SQL a ejecutar</param>
        /// <param name="parameters">Parámetros de la sentencia SQL</param>
        /// <returns>Primer dato obtenido</returns>
        public object[]? GetFirstOrDefaultData(string query, Dictionary<string, object>? parameters = null) {
            object[]? data = default;
            if (!string.IsNullOrWhiteSpace(query)) {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection)) {
                    if (parameters != null) {
                        foreach (KeyValuePair<string, object> parameter in parameters) {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) {
                        data = new object[dataReader.FieldCount];
                        for (int i = 0; i < dataReader.FieldCount; i++) {
                            data[i] = dataReader[i];
                        }
                        break;
                    }
                }
                if (_connection.State == ConnectionState.Open) {
                    _connection.Close();
                }
            }
            return data;
        }

        /// <summary>
        /// Ejecuta la sentencia SQL especificada e indica si se realizó la operación de forma correcta
        /// </summary>
        /// <param name="sql">Sentencia SQL a utilizar</param>
        /// <param name="parameters">Parámetros de la sentencia SQL</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool ExecuteQuery(string sql, Dictionary<string, object>? parameters = null) {
            if (string.IsNullOrWhiteSpace(sql)) return false;
            bool result = false;
            _connection.Open();
            using (SqlCommand command = new SqlCommand(sql, _connection)) {
                if (parameters != null) {
                    foreach (KeyValuePair<string, object> parameter in parameters) {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                result = command.ExecuteNonQuery() > 0;
            }
            if (_connection.State == ConnectionState.Open) {
                _connection.Close();
            }
            return result;
        }
    }
}
