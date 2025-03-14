using System;
using System.Windows.Forms;

namespace TURNOS_BANCARIOS
{
   public partial class Turnos : Form
   {
      private Menu menuPrincipal;
      private string tipo = "";
      private static int a = 1;
      private static int b = 1;
      private static int c = 1;
      private static int d = 1;

      static string[] cajas = new string[5];


      public Turnos(Menu menu, string tipo)
      {
         InitializeComponent();
         this.menuPrincipal = menu;
         this.tipo = tipo;
         GetTurno(cajas);
      }


      private void GetTurno(string[] arreglo)
      {
         for (int i = 0; i < 5; i++)
         {
            if (string.IsNullOrEmpty(arreglo[i]))
            {
               switch (tipo)
               {
                  case "A": arreglo[i] = tipo + a.ToString(); a++; break;
                  case "B": arreglo[i] = tipo + b.ToString(); b++; break;
                  case "C": arreglo[i] = tipo + c.ToString(); c++; break;
                  case "D": arreglo[i] = tipo + d.ToString(); d++; break;
               }

               break;
            }

         }
      }


      private void GuardarTurno(string[] arreglo)
      {

      }


      private void btnNuevoTurno_Click(object sender, EventArgs e)
      {
         menuPrincipal.AbrirFormHijo(new Filtro1(menuPrincipal));
         this.Hide();
      }
   }
}
