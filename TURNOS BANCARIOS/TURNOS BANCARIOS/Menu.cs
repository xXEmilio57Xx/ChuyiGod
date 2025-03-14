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
   public partial class Menu : Form
   {
      public Menu()
      {
         InitializeComponent();
         AbrirFormHijo(new Filtro1(this));
      }

      private void Menu_FormClosed(object sender, FormClosedEventArgs e)
      {
        Application.Exit();
      }


      public void AbrirFormHijo(object formhijo)//Codigo para Abrir forms hijos en el Form Menu
      {
         if (this.panelContenedor.Controls.Count > 0)
            this.panelContenedor.Controls.RemoveAt(0);

         Form fh = formhijo as Form;
         fh.TopLevel = false;
         fh.Dock = DockStyle.Fill;
         this.panelContenedor.Controls.Add(fh);
         this.panelContenedor.Tag = fh;
         fh.Show();
      }


   }
}
