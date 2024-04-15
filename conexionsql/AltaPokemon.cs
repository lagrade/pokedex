using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classdominio;
using Negocio;
using System.Configuration;
namespace conexionsql

{
    public partial class AltaPokemon : Form
    {
        //se crea un atributo de pokemon vacio
        private Pokemon pokemon = null;

        private OpenFileDialog archivo = null;
        public AltaPokemon()
        {
            InitializeComponent();
        }
        //se le asigna al pokemon vacio el pokemon pasado por parametro, cuando se abre la ventana
        public AltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //el evento Click de boton aceptar sierve tanto para crear un pokemon nuevo
        //como para modificar uno. haciendo la validacion si no hay un pokemon cargado se crea.
        //si lo hay se modifica
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //crear el objeto pokemon
           // Pokemon poke = new Pokemon();
            //crear un objeto de pokemonnegocio
            PokemonsNegocio negocio = new PokemonsNegocio();
            try
            {
                //validacion para crear pokemon nuevo, si esta null , es que esta vacio 
                if (pokemon == null)
                    pokemon = new Pokemon();
                //cargarle los atributos
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtImagen.Text;
                //tipo y debilidad son objetos por lo que al selected Item del
                //combo box se le hace un casteo del tipo de objeto que es.
                pokemon.tipo = (Elemento)cbxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbxDebilidad.SelectedItem;

                //validacion para berificar si hay un pokemon cargado , para modificar
                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("modificado exitosamente");

                }
                else
                {
                    //invoco a la funcion agreagr que tiene la clase pokemonNegocio
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");

                }
                //guarda imagen si la levanto localemte
                //validar que haya una imagen cargada y que no sea un url
                if (archivo != null && !(txtImagen.Text.ToLower().Contains("http")))
                {
                    //en el App.config se agrega <appSettings> < add key = "img-folder" value = "C:\poke_app\"/>
                    //en las referencias de de la app se agrega System.configuration, y se agrega el using, para
                    //poder utilizar el ConfigurationManager que proporciona acceso a los archivos de la configuracion

                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["img-folder"] + archivo.SafeFileName);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        // en el load de la ventana de alta Pokemons, se carga las listas tipo y debilidad 
        // en cada combo box.
        private void AltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                //para poder modificar los combobox de tipo y debilidad
                cbxTipo.DataSource = elementoNegocio.listar();
                cbxTipo.ValueMember = "id";
                cbxTipo.DisplayMember = "Descripcion";

                cbxDebilidad.DataSource = elementoNegocio.listar();
                cbxDebilidad.ValueMember = "id";
                cbxDebilidad.DisplayMember = "Descripcion";

                   
                //para que ya aparezcan los datos del pokemon seleccionado en el formulario
                if(pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cbxTipo.SelectedValue = pokemon.tipo.id;
                    cbxDebilidad.SelectedValue = pokemon.tipo.id;


                }
                

            }
            catch ( Exception ex)
            {

                throw ex;
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxpokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxpokemon.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOiEN99uJPX37lOwqYmPy_xs5z8auvTFOANdR7jaxOuA-ItMB8MGPXO45zTpEbZJ_jnvw&usqp=CAU");
            }
        }
        //agregar una imgaen de una ubicacion local
        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            //openfiledialog abre un cuadro de dialogo que pide al usuario que seleccione un archivo
            archivo = new OpenFileDialog();
            //Filter estabelce los tipo de archivos se pueden seleccionar
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            //validar si se selecciono un archivo para mostralo
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //filename guarda la ruta del archivo
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                //en el App.config se agrega <appSettings> < add key = "img-folder" value = "C:\poke_app\"/>
                //en las referencias de de la app se agrega System.configuration, y se agrega el using, para
                //poder utilizar el ConfigurationManager que proporciona acceso a los archivos de la configuracion
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["img-folder"] + archivo.SafeFileName);
            }

        }
    }
}
