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
   public partial class Filtro1 : Form
   {

      private Menu menuPrincipal;
      private bool tarjeta = false;
     

      public Filtro1(Menu menu)
      {
         InitializeComponent();
         this.menuPrincipal = menu;
      }

      private void btnTarjeta_Click(object sender, EventArgs e)
      {
         tarjeta = true;
         menuPrincipal.AbrirFormHijo(new Filtro2(menuPrincipal, tarjeta));
         this.Close();
      }

      private void btnSinTarjeta_Click(object sender, EventArgs e)
      {
         menuPrincipal.AbrirFormHijo(new Filtro2(menuPrincipal, tarjeta));
         this.Close();
      }
   }
}
