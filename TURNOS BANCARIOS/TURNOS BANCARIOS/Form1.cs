using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TURNOS_BANCARIOS
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         this.KeyPreview = true; //Activa la funcion para detectar si se presiona una tecla.
         this.KeyUp += Form1_KeyDown; //Ejecutara el evento KeyDown del Form.
      }


      private void timer1_Tick(object sender, EventArgs e)
      {
         this.Opacity += .2;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         timer1.Start();
      }

      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
         }
      }
   }
}
