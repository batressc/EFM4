using EFM4.Models.Domain;
using EFM4.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFM4.Models.Dao {
    public class DaoProduct {
        private readonly DatabaseOperations _db;

        public DaoProduct() {
            _db = new DatabaseOperations();
        }

        /// <summary>
        /// Obtiene el listado de todos los productos
        /// </summary>
        /// <returns>Listado de productos</returns>
        public List<Product> GetAll() {
            List<Product> data = new List<Product>();
            string query = "select id, name, category, unitPrice from Product;";
            List<object[]> rawProducts = _db.GetData(query);
            foreach (object[] product in rawProducts) {
                if (product[0] is string id && product[1] is string name && product[2] is string category && product[3] is decimal unitPrice) {
                    data.Add(new Product(id, name, category, unitPrice));
                }
            }
            return data;
        }

        /// <summary>
        /// Agrega un nuevo registro de producto
        /// </summary>
        /// <param name="data">Datos del producto</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Insert(Product data) {
            string sql = "insert into Product(id, name, category, unitPrice) values(@id, @name, @category, @unitPrice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", data.Id },
                { "@name", data.Name },
                { "@category", data.Category },
                { "@unitPrice", data.UnitPrice }
            };
            return _db.ExecuteQuery(sql, parameters);
        }

        /// <summary>
        /// Actualiza un registro de producto
        /// </summary>
        /// <param name="data">Datos del producto</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Update(Product data) {
            string sql = "update Product set name = @name, category = @category, unitPrice = @unitPrice where id = @id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", data.Id },
                { "@name", data.Name },
                { "@category", data.Category },
                { "@unitPrice", data.UnitPrice }
            };
            return _db.ExecuteQuery(sql, parameters);
        }

        /// <summary>
        /// Elimina un registro de producto
        /// </summary>
        /// <param name="id">Identificador del producto</param>
        /// <returns>Indicador de éxito o fallo de la operación</returns>
        public bool Delete(string id) {
            string sql = "delete from Product where id = @id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                { "@id", id }
            };
            return _db.ExecuteQuery(sql, parameters);
        }
    }
}
