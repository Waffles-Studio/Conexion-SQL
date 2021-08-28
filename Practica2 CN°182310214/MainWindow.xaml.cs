using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
namespace Practica2_CN_182310214
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Cadena;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void click(object sender, MouseButtonEventArgs e)//click dar de alta clientes
        {
            SqlConnection con = Conexion.cadena(CC.Text);
            string message;
            string caption;
            if (true)
            {con = Conexion.cadena(CC.Text);

            }
            
           
            if (con != null )
            {
                SqlCommand com = new SqlCommand("spNuevoCliente", con); //Nombre del sp
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = TBCN.Text;
                com.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 50).Value = TBCE.Text;
                com.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 10).Value = TBCT.Text;
                com.Parameters.Add("@Saldo", System.Data.SqlDbType.Int).Value = int.Parse(TBCS.Text);
                com.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 50).Value = TBCD.Text;

                com.ExecuteNonQuery();
                message = "Cliente registrado. ";
                caption = "Datos Válidos";


                TBCN.Text = "";
                TBCE.Text = "";
                TBCT.Text = "";
                TBCS.Text = "";
                TBCD.Text = "";
            
            }
            else
            {

            }
        }

        private void AddPeliculas(object sender, MouseButtonEventArgs e)
        {
            string message;
            string caption;

            SqlConnection con = Conexion.cadena(CC.Text);

            if (con != null)
            {
                SqlCommand com = new SqlCommand("spNuevaPelicula", con); //Nombre del sp
                com.CommandType = System.Data.CommandType.StoredProcedure;


                com.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = TBPN.Text;
                com.Parameters.Add("@Genero", System.Data.SqlDbType.VarChar, 50).Value = TBPG.Text;
                com.Parameters.Add("@Precio", System.Data.SqlDbType.Int).Value = int.Parse(TBPP.Text);

                com.ExecuteNonQuery();
                message = "Pelicula registrada. ";
                caption = "Datos Válidos";


                TBPN.Text = "";
                TBPG.Text = "";
                TBPP.Text = "";
             
            }
            else
            { }

            }

        private void AddRenta(object sender, MouseButtonEventArgs e)
        {

            string message;
            string caption;

            SqlConnection con = Conexion.cadena(CC.Text);



            if (con != null)
            {
                SqlCommand com = new SqlCommand("spNuevaRenta", con); //Nombre del sp
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.Add("@idpelicula", System.Data.SqlDbType.Int).Value = int.Parse(TBRCP.Text);
                com.Parameters.Add("@idcliente", System.Data.SqlDbType.Int).Value = int.Parse(TBRCC.Text);
                com.Parameters.Add("@domicilio", System.Data.SqlDbType.VarChar, 50).Value = TBRD.Text;
                com.Parameters.Add("@precio", System.Data.SqlDbType.Int).Value = int.Parse(TBRP.Text);

                com.ExecuteNonQuery();
                message = "Renta registrada. ";
                caption = "Datos Válidos";


                TBRCC.Text = "";
                TBRCP.Text = "";
                TBRP.Text = "";
                TBRD.Text = "";

            }
            else
            {

            }
        }

        private void CC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
