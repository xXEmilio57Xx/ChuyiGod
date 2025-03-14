using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TURNOS_BANCARIOS
{
   public partial class Filtro2 : Form
   {
      private Menu menuPrincipal;
      bool tarjeta = false;
      bool cajas = false;
      string tipo = "";
      public Filtro2(Menu menu, bool tarjeta)
      {
         InitializeComponent();
         timer1.Start();
         menuPrincipal = menu;
         this.tarjeta = tarjeta;
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         this.Opacity += .2;
      }

      private void TipoCliente( bool tarjeta, bool cajas)
      {
         if (tarjeta)
            if (cajas) tipo = "A";
            else tipo = "B";
         else
            if (cajas) tipo = "C";
         else tipo = "D";
      }

      private void btnEjecutivo_Click(object sender, EventArgs e)
      {
         TipoCliente(this.tarjeta, this.cajas);
         menuPrincipal.AbrirFormHijo(new Turnos(menuPrincipal, tipo));
         this.Close();
      }

      private void btnCajas_Click(object sender, EventArgs e)
      {
         cajas = true;
         TipoCliente(this.tarjeta, this.cajas);
         menuPrincipal.AbrirFormHijo(new Turnos(menuPrincipal, tipo));
         this.Close();
      }
   }
}
