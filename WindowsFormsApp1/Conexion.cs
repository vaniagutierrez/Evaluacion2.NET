﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        public static SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio ; integrated security = true");

        public void conectar()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
