using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TURNOS_BANCARIOS
{
    class csTurnos
    {
        public static List<string> turnoEjecutivoTarjeta = new List<string>();
        public static List<string> turnoEjecutivoSinTarjeta = new List<string>();
        public static List<string> turnoCajaTarjeta = new List<string>();
        public static List<string> turnoCajaSinTarjeta = new List<string>();

        public static int turnoCaja = 1;
        public static int turnoEjecutivo = 1;

        public static bool TieneTarjeta { get; set; }
        //true = caja, false = ejecutivo
        public static bool TipoServicio { get; set; }

        int contadorCaja = 0, contadorEjecutivo = 0;
        public void LlenarListas()
        {
            try
            {
                if(TieneTarjeta == true)
                {
                    if(TipoServicio == true)
                    {
                        //caja
                        turnoCajaTarjeta.Add("A" + turnoCaja);
                        turnoCaja++;
                    }
                    else
                    {
                        //ejecutivo
                        turnoEjecutivoTarjeta.Add("B" + turnoEjecutivo);
                        turnoEjecutivo++;
                    }
                }
                else
                {
                    if(TipoServicio == true)
                    {
                        //caja
                        turnoCajaSinTarjeta.Add("C" + turnoCaja);
                        turnoCaja++;
                    }
                    else
                    {
                        //ejecutivo
                        turnoEjecutivoSinTarjeta.Add("D" + turnoEjecutivo);
                        turnoEjecutivo++;
                    }
                }

                contadorCaja++;contadorEjecutivo++;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AcomodarLista(List<string> lista, DataGridView dg)
        {
            try
            {
                dg.Rows.Clear();  // Limpiar las filas existentes

                // Asegurarse de que el DataGridView tenga exactamente 5 columnas
                while (dg.Columns.Count < 5)
                {
                    dg.Columns.Add("Columna_" + dg.Columns.Count, "Columna " + (dg.Columns.Count + 1));
                }

                // Limitar el tamaño de la lista a 5 elementos (si es necesario)
                var listaLimitada = lista.Take(5).ToList();

                // Agregar una fila vacía para colocar los datos
                dg.Rows.Add();

                // Colocar los elementos de la lista en las celdas de la fila
                for (int i = 0; i < listaLimitada.Count; i++)
                {
                    dg.Rows[0].Cells[i].Value = listaLimitada[i]; // Asignar el valor de la lista a la celda correspondiente
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Posiblemente la cola ya esta llena", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
