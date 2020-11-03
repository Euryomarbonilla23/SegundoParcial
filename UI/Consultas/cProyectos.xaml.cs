
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SegundoParcial.BLL;
using SegundoParcial.DAL;
using SegundoParcial.Entidades;

namespace SegundoParcial.UI.Consultas
{
    /// <summary>
    /// Interaction logic for Consulta.xaml
    /// </summary>
    public partial class cProyectos : Window
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
             var listado = new List<Proyectos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        
                        listado = ProyectosBLL.GetList(e=>true);
                        break;
                    case 1:
                        int num = 0;
                        listado = ProyectosBLL.GetList(e => e.ProyectoId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                    case 2:
                        
                        listado = ProyectosBLL.GetList(e => e.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                  
                }

                
            }
            else
            {
                listado = ProyectosBLL.GetList(c => true);
            }

          
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
        
    }
    
}
