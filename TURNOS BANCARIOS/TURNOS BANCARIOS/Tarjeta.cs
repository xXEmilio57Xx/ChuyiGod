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
   public partial class Tarjeta : Form
   {

      private Menu menuPrincipal;  

      public Tarjeta(Menu menu)
      {
         InitializeComponent();
         this.menuPrincipal = menu;
      }
        private csTurnos csTurnos = new csTurnos();
      private void btnTarjeta_Click(object sender, EventArgs e)
      {
         csTurnos.TieneTarjeta = true;
         menuPrincipal.AbrirFormHijo(new Operacion(menuPrincipal));
         this.Close();
      }

      private void btnSinTarjeta_Click(object sender, EventArgs e)
      {
            csTurnos.TieneTarjeta = false;
            menuPrincipal.AbrirFormHijo(new Operacion(menuPrincipal));
         this.Close();
      }

        private void Filtro1_Load(object sender, EventArgs e)
        {

        }
    }
}
