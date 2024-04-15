using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classdominio;
using Negocio;

namespace conexionsql
{
    public partial class Form1 : Form

    {
        //crear la lista como un atributo, para que siempre este cargada con los datos de la bd y la
        //pueda utilizar en todas las instancias necesarias
        private List<Pokemon> listapokemon;
        public Form1()
        {
            InitializeComponent();
            Text = "Pokedex";
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboxCampo.Items.Add("Numero");
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Descripcion");


        }
        //se crea la carga como un metodo para poder invocarlo en el evento Load y en agregar
        //para actualizar la lista
        private void cargar()
        {
            PokemonsNegocio negocio = new PokemonsNegocio();
            try
            {
                listapokemon = negocio.listar();
                dgwpokemon.DataSource = listapokemon;
                ocultarColumnas();

                cargarImagen(listapokemon[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgwpokemon.Columns ["UrlImagen"].Visible = false;
            dgwpokemon.Columns ["Id"].Visible = false;

        }

            

        private void dgwpokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgwpokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgwpokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);

            }
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
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            AltaPokemon alta = new AltaPokemon();
            alta.ShowDialog();
            //llamar al metodo cargar para actualizar la lista cuando se agrega un pokemon nuevo
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Para obtener el pokemon seleccionado para modificar
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgwpokemon.CurrentRow.DataBoundItem;
            
            //despues de hacer la sobrecarga del constructor para que reciba por parametro 
            //un pokemon.se le pasa el pokemon seleccionado por parametro.
            AltaPokemon modificar = new AltaPokemon( seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btneliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar (bool logico = false)
        {

            PokemonsNegocio negocio = new PokemonsNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("¿De verdad queres eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgwpokemon.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);

                    else
                        negocio.eliminar(seleccionado.Id);
                    cargar();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        //filtro avanzado, se cuarda las variables de campo, criterio y filtro que se mandan como 
        //parametro en el metodo filtrar de PokemonNegocio.
         private void btnbuscar_Click(object sender, EventArgs e)
         {
            PokemonsNegocio negocio = new PokemonsNegocio();
            try
            {
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtfiltroavanzado.Text;
                dgwpokemon.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

         }
        
        //filtro rapido desde el txt filtro
        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listafiltrada;
            string filtro = txtfiltro.Text;

            if (filtro.Length >= 2)
            {
                listafiltrada = listapokemon.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.tipo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {

                listafiltrada = listapokemon;
            }

            dgwpokemon.DataSource = null;
            dgwpokemon.DataSource = listafiltrada;
            ocultarColumnas();
        }
        
        //cargar los combobox con las opciones para filtrar
        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboxCampo.SelectedItem.ToString();
            if (opcion =="Numero")
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor a");
                cboxCriterio.Items.Add("Menor a"); 
                cboxCriterio.Items.Add("Igual a");
            }
            else
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Comienza con ");
                cboxCriterio.Items.Add("Termina con ");
                cboxCriterio.Items.Add("Contiene ");
            }
        }
    }
}
