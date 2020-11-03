
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SegundoParcial.Entidades;
using SegundoParcial.BLL;
using SegundoParcial.DAL;

namespace SegundoParcial.UI.Registros
{
    /// <summary>
    /// Interaction logic for registroProyectos.xaml
    /// </summary>
    public partial class rProyectos : Window
    {
        Proyectos Proyecto = new Proyectos();
        public rProyectos()
        {
            InitializeComponent();
            Contexto contexto = new Contexto();
            InitializeComponent();
            this.DataContext = Proyecto;
            TipoTareaComboBox.SelectedValuePath = "TipoId";
            TipoTareaComboBox.DisplayMemberPath = "TipoTarea";
            TipoTareaComboBox.ItemsSource = contexto.Tipos.Where(p => true).ToList();
        }

         private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = Proyecto;
        }

        private void Limpiar()
        {
            this.Proyecto = new Proyectos();
            this.DataContext = Proyecto;
        }

        private bool Validar()
        {
            bool Validado = true;
            if (ProyectoIdTextBox.Text.Length < 0)
            {
                Validado = false;
                MessageBox.Show("Es menor a 0", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            

            return Validado;
        }

        private bool ValidarAgregar()
        {
            bool Validado = true;
            if (Convert.ToInt32(MinutosTextBox.Text)<5)
            {
                Validado = false;
                MessageBox.Show("Debe haber al menas mas de 5 minutos", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (RequerimientosTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Debe haber Requeriminetos", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            

            return Validado;
        }


        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectosBLL.Buscar(Proyecto.ProyectoId);

            if (encontrado != null)
            {
                Proyecto = encontrado;
                Cargar();
                MessageBox.Show("Proyecto Encontrado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Este Proyecto no fue encontrado.\n\nAsegurese que existe o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();

                ProyectoIdTextBox.Text = "";
                ProyectoIdTextBox.Focus();
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Contexto context = new Contexto();
            Tipos Tipo = context.Tipos.Find(Convert.ToInt32(TipoTareaComboBox.SelectedValue.ToString()));

            if(!ValidarAgregar())
                return;

            var Fila = new TareasDetalle
            {
                
                
                TareaId = Tipo.TipoId,
                TipoTarea= Tipo.TipoTarea,
                Requerimientos = (RequerimientosTextBox.Text.ToString()),
                Tiempo = Convert.ToInt32(MinutosTextBox.Text.ToString()),
                
            };
            Proyecto.TiempoTotal += Fila.Tiempo;
            this.Proyecto.Detalles.Add(Fila);
            Cargar();
            Calcular();

            TipoTareaComboBox.SelectedIndex = -1;
            RequerimientosTextBox.Clear();
            MinutosTextBox.Clear();
            //TiempoTotalTextBox.Text=Proyecto.Detalles.
        }

        public void Calcular()
        {
            int num = 0;
            foreach (var item in Proyecto.Detalles)
            {
                num += item.Tiempo;
            }
            Proyecto.TiempoTotal = num;

        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            
            if(DetalleDataGrid.SelectedIndex<=0)
            {
                if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
                {
                    Proyecto.Detalles.RemoveAt(DetalleDataGrid.SelectedIndex);
                    Cargar();
                    Calcular();
                }
            }
            else{
                if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
                {
                    TareasDetalle td = new TareasDetalle();
                    td = Proyecto.Detalles.Last(); 
                    Proyecto.Detalles.Remove(td);
                    Cargar();
                    Calcular();
                }
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = ProyectosBLL.Guardar(Proyecto);
                if (paso)
                {
                    Calcular();
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                int num = 0;
                Int32.TryParse(ProyectoIdTextBox.Text, out num);
                if (ProyectosBLL.Eliminar(num))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
    }
}