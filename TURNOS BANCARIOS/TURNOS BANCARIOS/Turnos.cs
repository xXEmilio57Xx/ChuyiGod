using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TURNOS_BANCARIOS
{
   public partial class Turnos : Form
   {
      private Menu menuPrincipal;
        csTurnos csTurnos = new csTurnos();
        List<string> caja = new List<string>();
        List<string> ejecutivo = new List<string>();
      public Turnos(Menu menu)
      {
         InitializeComponent();
         this.menuPrincipal = menu;
      }


      private void btnNuevoTurno_Click(object sender, EventArgs e)
      {
         menuPrincipal.AbrirFormHijo(new Tarjeta(menuPrincipal));
         this.Hide();
      }


        private void Turnos_Load(object sender, EventArgs e)
        {
            csTurnos.LlenarListas();

            var tempCaja = csTurnos.turnoCajaTarjeta.Concat(csTurnos.turnoCajaSinTarjeta).ToList();
            var tempEjecutivo = csTurnos.turnoEjecutivoTarjeta.Concat(csTurnos.turnoEjecutivoSinTarjeta).ToList();

            csTurnos.AcomodarLista(tempCaja, dg_caja);
            csTurnos.AcomodarLista(tempEjecutivo, dg_ejecutivo);

            dg_caja.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            dg_ejecutivo.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
        }

    }
}
