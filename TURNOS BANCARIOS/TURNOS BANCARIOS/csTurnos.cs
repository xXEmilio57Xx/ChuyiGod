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

        public static int turno_Caja_tarjeta = 1;
        public static int turno_Caja_sin_tarjeta = 1;
        public static int turno_Ejecutivo_tarjeta = 1;
        public static int turno_Ejecutivo_sin_tarjeta = 1;

        public static bool TieneTarjeta { get; set; }  // true: tiene tarjeta
        public static bool TipoServicio { get; set; }  // true: caja, false: ejecutivo

        int contadorCaja = 0, contadorEjecutivo = 0;

        public void LlenarListas()
        {
            try
            {
                string nuevoTurno = "";

                if (TieneTarjeta)
                {
                    if (TipoServicio)
                    {
                        nuevoTurno = "A" + turno_Caja_tarjeta++;
                        turnoCajaTarjeta.Add(nuevoTurno);
                    }
                    else
                    {
                        nuevoTurno = "B" + turno_Ejecutivo_tarjeta++;
                        turnoEjecutivoTarjeta.Add(nuevoTurno);
                    }
                }
                else
                {
                    if (TipoServicio)
                    {
                        nuevoTurno = "C" + turno_Caja_sin_tarjeta++;
                        turnoCajaSinTarjeta.Add(nuevoTurno);
                    }
                    else
                    {
                        nuevoTurno = "D" + turno_Ejecutivo_sin_tarjeta++;
                        turnoEjecutivoSinTarjeta.Add(nuevoTurno);
                    }
                }

                // Controlar límite de 5 turnos por tipo de servicio combinando ambas listas
                var totalCaja = turnoCajaTarjeta.Concat(turnoCajaSinTarjeta).ToList();
                if (totalCaja.Count > 5)
                {
                    // Eliminar del inicio (el más antiguo)
                    string primer = totalCaja[0];
                    if (turnoCajaTarjeta.Contains(primer))
                        turnoCajaTarjeta.Remove(primer);
                    else if (turnoCajaSinTarjeta.Contains(primer))
                        turnoCajaSinTarjeta.Remove(primer);
                }

                var totalEjecutivo = turnoEjecutivoTarjeta.Concat(turnoEjecutivoSinTarjeta).ToList();
                if (totalEjecutivo.Count > 5)
                {
                    string primer = totalEjecutivo[0];
                    if (turnoEjecutivoTarjeta.Contains(primer))
                        turnoEjecutivoTarjeta.Remove(primer);
                    else if (turnoEjecutivoSinTarjeta.Contains(primer))
                        turnoEjecutivoSinTarjeta.Remove(primer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void InsertarConDesplazamiento(List<string> lista, string turno)
        {
            if (lista.Count >= 5)
            {
                lista.RemoveAt(0); // Elimina el más antiguo
            }

            lista.Add(turno); // Agrega el nuevo al final
        }

        public void AcomodarLista(List<string> lista, DataGridView dg)
        {
            try
            {
                dg.Rows.Clear();

                while (dg.Columns.Count < 5)
                    dg.Columns.Add("Columna_" + dg.Columns.Count, "Columna " + (dg.Columns.Count + 1));

                var listaLimitada = lista.Take(5).ToList();

                dg.Rows.Add();

                for (int i = 0; i < listaLimitada.Count; i++)
                {
                    dg.Rows[0].Cells[i].Value = listaLimitada[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Posiblemente la cola ya está llena", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
