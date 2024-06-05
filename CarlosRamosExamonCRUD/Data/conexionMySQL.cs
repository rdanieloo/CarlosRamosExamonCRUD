using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


using CarlosRamosExamonCRUD.Data.Modelos;

namespace CarlosRamosExamonCRUD.Data
{
    internal class conexionMySQL
    {
        string connectionString = "server=localhost;database=carlosramos_examenfinalprogra;user=root;password=Ram0s.24CC19";
        private MySqlConnection connection;


        //constructor
        public conexionMySQL()
        {
            connection = new MySqlConnection(connectionString);


        }

        //Probamos conexion
        public bool PruebaConexion()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public void Insertar(string Nombre, string SKU, string Proveedor, string Categoria, decimal Costo, decimal Precio_de_venta, DateTime Fecha_de_registro, int Disponible, byte Imagen)

        {
            try
            {
                string query = "INSERT INTO productos (Nombre, SKU, Proveedor, Categoria, Costo, Precio_de_venta, Fecha_de_registro, Disponible, Imagen) VALUES (@Nombre, @SKU, @Proveedor, @Categoria, @Costo, @Precio_de_venta, @Fecha_de_registro, @Disponible, Imagen)";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@SKU", SKU);
                cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@Costo", Costo);
                cmd.Parameters.AddWithValue("@Precio_de_venta", Precio_de_venta);
                cmd.Parameters.AddWithValue("@Fecha_de_registro", Fecha_de_registro);
                cmd.Parameters.AddWithValue("@Disponible", Disponible);
                cmd.Parameters.AddWithValue("@Imagen", Imagen);


                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);

                MessageBox.Show("Error al agregar el registro: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }


        }




        //Codigo nuevo

        //Usamos la clase Productos
        // Insertamos con un objeto de la clase Productos

        public void Insertar(Productos usr)

        {

            try
            {
                string query = "INSERT INTO productos (Nombre, SKU, Proveedor, Categoria, Costo, Precio_de_venta, Fecha_de_registro, Disponible, Imagen) VALUES (@Nombre, @SKU, @Proveedor, @Categoria, @Costo, @Precio_de_venta, @Fecha_de_registro, @Disponible, @Imagen)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", usr.Nombre);
                cmd.Parameters.AddWithValue("@SKU", usr.SKU);
                cmd.Parameters.AddWithValue("@Proveedor", usr.Proveedor);
                cmd.Parameters.AddWithValue("@Categoria", usr.Categoria);
                cmd.Parameters.AddWithValue("@Costo", usr.CostoProducto);
                cmd.Parameters.AddWithValue("@Precio_de_venta", usr.PrecioVenta);
                cmd.Parameters.AddWithValue("@Fecha_de_registro", usr.FechaRegistro);
                cmd.Parameters.AddWithValue("@Disponible", usr.Disponible);
                cmd.Parameters.AddWithValue("@Imagen", usr.Imagen);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        //Metodo para leer Productos
        public List<Productos> LeerProductos()
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Productos producto = new Productos();
                    producto.Id = Convert.ToInt32(reader["Id"]);
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.SKU = reader["SKU"].ToString();
                    producto.Proveedor = reader["Proveedor"].ToString();
                    producto.Categoria = reader["Categoria"].ToString();
                    producto.CostoProducto = Convert.ToDecimal(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["Precio_de_venta"]);
                    producto.FechaRegistro = Convert.ToDateTime(reader["Fecha_de_registro"]);
                    producto.Disponible = Convert.ToInt32(reader["Disponible"]);


                    // Verificamos si la columna de imagen tiene un valor nulo
                    if (reader["Imagen"] != DBNull.Value)
                    {
                        producto.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        // Si la columna de imagen es nula, en este caso le asignamos un valor por defecto 

                        producto.Imagen = ObtenerImagenPorDefecto();
                    }

                    productos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;
        }


        //Metodo para Actualizar Productos
        public void ActualizarProducto(Productos producto)
        {
            try
            {
                string query = "UPDATE productos SET Nombre = @Nombre, SKU = @SKU, Proveedor = @Proveedor, Categoria = @Categoria, Costo = @Costo, Precio_de_venta = @Precio_de_venta, Fecha_de_registro = @Fecha_de_registro, Disponible = @Disponible, Imagen = @Imagen WHERE Id = @Id";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@SKU", producto.SKU);
                cmd.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                cmd.Parameters.AddWithValue("@Costo", producto.CostoProducto);
                cmd.Parameters.AddWithValue("@Precio_de_venta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Fecha_de_registro", producto.FechaRegistro);
                cmd.Parameters.AddWithValue("@Disponible", producto.Disponible);
                cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                cmd.Parameters.AddWithValue("@Id", producto.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al actualizar el registro:( " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }


        public void Eliminar(int id)
        {
            try
            {
                string query = "DELETE FROM productos WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto eliminado correctamente :D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al eliminar el producto :(" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }





        public List<Productos> BuscarProductoPorId(int id)
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                string query = "SELECT * FROM productos WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Productos producto = new Productos();
                    producto.Id = Convert.ToInt32(reader["Id"]);
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.SKU = reader["SKU"].ToString();
                    producto.Proveedor = reader["Proveedor"].ToString();
                    producto.Categoria = reader["Categoria"].ToString();
                    producto.CostoProducto = Convert.ToDecimal(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["Precio_de_venta"]);
                    producto.FechaRegistro = Convert.ToDateTime(reader["Fecha_de_registro"]);
                    producto.Disponible = Convert.ToInt32(reader["Disponible"]);

                    // Verificamos si la columna de imagen contiene un valor nulo
                    if (reader["Imagen"] != DBNull.Value)
                    {
                        producto.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        // Si la columna de imagen es nula, podemos asignarle una imagen por defecto
                        producto.Imagen = ObtenerImagenPorDefecto();
                    }
                    productos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto por ID: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;
        }

        // Metodo para obtener una imagen por defecto 
        private byte[] ObtenerImagenPorDefecto()
        {

            return null;
        }




        // Metodo para leer Productos dentro de un rango de fechas de Month Calender
        public List<Productos> LeerProductos(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                string query = "SELECT * FROM productos WHERE Fecha_de_registro BETWEEN @FechaInicio AND @FechaFin";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Productos producto = new Productos();
                    producto.Id = Convert.ToInt32(reader["Id"]);
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.SKU = reader["SKU"].ToString();
                    producto.Proveedor = reader["Proveedor"].ToString();
                    producto.Categoria = reader["Categoria"].ToString();
                    producto.CostoProducto = Convert.ToDecimal(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["Precio_de_venta"]);
                    producto.FechaRegistro = Convert.ToDateTime(reader["Fecha_de_registro"]);
                    producto.Disponible = Convert.ToInt32(reader["Disponible"]);


                    // Verificamos si la columna de imagen contiene un valor nulo
                    if (reader["Imagen"] != DBNull.Value)
                    {
                        producto.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {

                        producto.Imagen = ObtenerImagenPorDefecto();
                    }
                    productos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Error al leer los datos :( " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;
        }


        internal List<Productos> ObtenerProductosPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                // Llamar al método LeerProductos pasando las fechas de inicio y fin
                productos = LeerProductos(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Error al obtener los productos por rango de fechas :( " + ex.Message);
            }
            return productos;
        }




    }
}


    
    














