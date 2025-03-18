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
   public partial class Operacion : Form
   {
      private Menu menuPrincipal;

      public Operacion(Menu menu)
      {
         InitializeComponent();
         timer1.Start();
         menuPrincipal = menu;
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         this.Opacity += .2;
      }
        csTurnos csTurnos = new csTurnos();
      private void btnEjecutivo_Click(object sender, EventArgs e)
      {
            csTurnos.TipoServicio = false;
         menuPrincipal.AbrirFormHijo(new Turnos(menuPrincipal));
         this.Close();
      }

      private void btnCajas_Click(object sender, EventArgs e)
      {
            csTurnos.TipoServicio = true;
            menuPrincipal.AbrirFormHijo(new Turnos(menuPrincipal));
            this.Close();
      }

        private void Filtro2_Load(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {

        }
    }
}
