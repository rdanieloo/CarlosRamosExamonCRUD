using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosRamosExamonCRUD.Data;
using static Mysqlx.Notice.Frame.Types;
using CarlosRamosExamonCRUD.Data.Modelos;
using static System.Net.Mime.MediaTypeNames;
using System.IO; // Agregamos esta lianea para usar la clase archivo

namespace CarlosRamosExamonCRUD
{
    public partial class Form1 : Form
    {
        //Instancia Clscone de la clase conexionMySQL, maneja la conexion con nuestra base de datos y las operaciones CRUD
        conexionMySQL Clscone = new conexionMySQL();

        Productos usr = new Productos();

        // Variable para almacenar los bytes de la imagen seleccionada
        private byte[] imagenBytes;


        public Form1()
        {
            InitializeComponent();
        }

        // private void botonGrabar_Click(object sender, EventArgs e)
        // {
        //   try
        //    {
        //     Clscone.Insertar(textBoxNombre.Text, textBoxSKU.Text, textBoxProveedor.Text, textBoxCategoria.Text, decimal.Parse(maskedTextBoxCosto.Text), decimal.Parse(maskedTextBoxPrecioVenta.Text), dateTimePickerFechaRegistro, (int)numericUpDownSTOK.Value);


        //      MessageBox.Show("Registro agregado correctamente");


        //  }
        //   catch (Exception ex)
        //    {
        //        MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);
        //  }

        // }



        private void botonInsertar_Click_1(object sender, EventArgs e)
        {
            //Grabacion con modelo Productos

            //Agregarlos de forma correcta

            //Llamamos a la función ValidarCampos para asegurararnos de que todos los campos contienen datos válidos antes de avanzar

            if (ValidarCampos())
            {

                //Utilizamos un Try Catch donde intenta capturar los datos del formulario y llamamos al metodo Insert, en este caso de Clscone
                try
                {
                    usr.Nombre = textBoxNombre.Text;
                    usr.SKU = textBoxSKU.Text;
                    usr.Proveedor = textBoxProveedor.Text;
                    usr.Categoria = textBoxCategoria.Text;
                    usr.CostoProducto = decimal.Parse(maskedTextBoxCosto.Text);
                    usr.PrecioVenta = decimal.Parse(maskedTextBoxPrecioVenta.Text);
                    usr.FechaRegistro = dateTimePickerFechaRegistro.Value;
                    usr.Disponible = (int)numericUpDownSTOK.Value;

                    // Asignamos imagen seleccionada
                    usr.Imagen = imagenBytes;

                    Clscone.Insertar(usr);
                    //Mensaje de que se realizo correctamente el Registro
                    MessageBox.Show("Registro agregado correctamente");
                }
                catch (Exception ex)
                {
                    //Mensaje de que hay un error al agregar un Registro
                    MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);
                }
            }

        }

        //La funcion Validar Campos nos ayuda a que el usuario ingrese datos correctamente
        //Mostramos un mensaje si ingresa un dato incorrecto

        private bool ValidarCampos()
        {
            // Nombre
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Nombre, por favor :D");
                return false;
            }

            // SKU
            if (string.IsNullOrWhiteSpace(textBoxSKU.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo SKU, por favor :D");
                return false;
            }

            // Proveedor
            if (string.IsNullOrWhiteSpace(textBoxProveedor.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta un Proveedor, por favor :D");
                return false;
            }

            // Categoría
            if (string.IsNullOrWhiteSpace(textBoxCategoria.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta una Categoría, por favor :D");
                return false;
            }

            //Costo
            if (string.IsNullOrWhiteSpace(maskedTextBoxCosto.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Costo, por favor :D");
                return false;
            }

            // Precio de Venta
            if (string.IsNullOrWhiteSpace(maskedTextBoxPrecioVenta.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Precio de Venta, por favor :D");
                return false;
            }

            //FechaRegistro
            if (dateTimePickerFechaRegistro.Value == DateTime.MinValue)
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPor favor, puedes seleccionar una fecha valida :D");
                return false;
            }


            if (numericUpDownSTOK.Value < 0)
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nLa cantidad disponible no puede ser negativa.");
                return false;
            }

            return true;
        }

        private void botonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el OpenFileDialog para que el usuario pueda seleccionar una imagen

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lee los datos binarios de la imagen seleccionada

                    imagenBytes = File.ReadAllBytes(openFileDialog.FileName);

                    // Mostramos la imagen en pictureBox
                    pictureBoxImagen.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                    // Mostramos mensaje de éxito
                    MessageBox.Show("Imagen seleccionada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al seleccionar la imagen: " + ex.Message);
            }

        }

        private byte[] ConvertirImagenAByteArray(System.Drawing.Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void MostrarDatosDelProducto(Productos producto)
        {
            // Mostramos los datos del producto en los controles correspondientes
            textBoxNombre.Text = producto.Nombre;
            textBoxSKU.Text = producto.SKU;
            textBoxProveedor.Text = producto.Proveedor;
            textBoxCategoria.Text = producto.Categoria;
            maskedTextBoxCosto.Text = producto.CostoProducto.ToString();
            maskedTextBoxPrecioVenta.Text = producto.PrecioVenta.ToString();
            dateTimePickerFechaRegistro.Value = producto.FechaRegistro;
            numericUpDownSTOK.Value = producto.Disponible;

            // Verificamos si el producto tiene una imagen
            if (producto.Imagen != null)
            {
                // Mostramos la imagen del producto en el pictureBoxImagen
                MemoryStream ms = new MemoryStream(producto.Imagen);
                pictureBoxImagen.Image = System.Drawing.Image.FromStream(ms);
            }
            else
            {
                // Limpiamos el pictureBoxImagen 
                pictureBoxImagen.Image = null;
            }

        }




        private void botonBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos el ID del producto ingresado por el usuario
            if (int.TryParse(textBoxID.Text, out int id))
            {
                // Llamamos al metodo para buscar el producto por ID
                List<Productos> productosEncontrados = Clscone.BuscarProductoPorId(id);

                // Verificamos si encontramos productos
                if (productosEncontrados.Count > 0)
                {
                    // Mostramos los datos del primer producto encontrado
                    var productoEncontrado = productosEncontrados[0];

                    // Asignamos los datos del producto al formulario
                    MostrarDatosDelProducto(productoEncontrado);
                }
                else
                {
                    // Si no se encontraron productos con el ID, mostramos un mensaje
                    MessageBox.Show("Oops!!! \nNo se encontraron productos con el ID :(");
                }
            }
            else
            {
                // Si el usuario no ingresa un ID válido, mostramos un mensaje
                MessageBox.Show("Ingrese un ID válido, por favor :D");
            }


        }

        private void botonLeer_Click(object sender, EventArgs e)
        {
            try
            {
                List<Productos> productos = Clscone.LeerProductos();
                dataGridViewProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }


        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha ingresado un ID válido
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                // Obtenemos el ID ingresado por el usuario
                int id = int.Parse(textBoxID.Text);

                // Buscamos el producto por su ID
                List<Productos> productosEncontrados = Clscone.BuscarProductoPorId(id);

                // Verificamos si se encontró algún producto con el ID especificado
                if (productosEncontrados.Count > 0)
                {
                    // Mostramos el primer producto encontrado 
                    Productos producto = productosEncontrados[0];

                    // Actualizamos los datos del producto con los valores de los controles del formulario
                    producto.Nombre = textBoxNombre.Text;
                    producto.SKU = textBoxSKU.Text;
                    producto.Proveedor = textBoxProveedor.Text;
                    producto.Categoria = textBoxCategoria.Text;
                    producto.CostoProducto = decimal.Parse(maskedTextBoxCosto.Text);
                    producto.PrecioVenta = decimal.Parse(maskedTextBoxPrecioVenta.Text);
                    producto.FechaRegistro = dateTimePickerFechaRegistro.Value;
                    producto.Disponible = (int)numericUpDownSTOK.Value;

                    // Si se seleccionamos una imagen, lo cual actualizarla
                    if (imagenBytes != null)
                    {
                        producto.Imagen = imagenBytes;
                    }

                    // Llamamos al metoodo en la clase conexionMySQL para actualizar el producto
                    Clscone.ActualizarProducto(producto);

                    MessageBox.Show("Datos actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el ID :(");
                }
            }
            else
            {
                MessageBox.Show("Ingresar un ID valido, por favor");
            }


        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text) && int.TryParse(textBoxID.Text, out int id))
            {
                Clscone.Eliminar(id);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para eliminar el producto.");
            }


        }



        private void maskedTextBoxCosto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonPruebaConexion_Click(object sender, EventArgs e)
        {
            // Creamos una instancia de la clase conexionMySQL
            conexionMySQL Clscone = new conexionMySQL();


            bool conexionExitosa = Clscone.PruebaConexion();


            if (conexionExitosa)
            {
                MessageBox.Show("Conexion Exitosa!! :D ");
            }
            else
            {
                MessageBox.Show("Oopss :(\nNo existe conexion");
            }


        }

        private void monthCalendarSeleccion_DateChanged(object sender, DateRangeEventArgs e)
        {
          

        }

        // Evento Click del botón de búsqueda
        private void botonBuscarPorFechas_Click(object sender, EventArgs e)
        {

            // Obtenemos las fechas seleccionadas por el usuario en el MonthCalendar
            DateTime fechaInicio = monthCalendarSeleccion.SelectionStart;
            DateTime fechaFin = monthCalendarSeleccion.SelectionEnd;

            // Llamaamos al método de la clase conexionMySQL para obtener los productos dentro del rango de fechas
            List<Productos> productos = Clscone.LeerProductos(fechaInicio, fechaFin);

            // Mostraamos los productos en el DataGridView
            dataGridViewProductos.DataSource = productos;

        }
        // MEetodo para realizar la consulta por rango de fechas
        private void RealizarConsultaPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<Productos> productos = Clscone.ObtenerProductosPorRangoDeFechas(fechaInicio, fechaFin);
                // Aquí puedemos mostrar los productos en un DataGridView 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta por rango de fechas: " + ex.Message);
            }
        }

        // Evento del botón para realizar la consulta por rango de fechas
        private void botonConsultarPorFechas_Click(object sender, EventArgs e)
        {
            // Obtenemos las fechas seleccionadas por el usuario en el MonthCalendar
            DateTime fechaInicio = monthCalendarSeleccion.SelectionStart;
            DateTime fechaFin = monthCalendarSeleccion.SelectionEnd;

            // Llamamos al método para realizar la consulta por rango de fechas
            RealizarConsultaPorRangoDeFechas(fechaInicio, fechaFin);
        }
    }


}



