using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporteria
{
    public partial class menu_reporteria : Form
    {
        public menu_reporteria()
        {
            InitializeComponent();
        }

        //Luis David Reyes Mijangos 0901-15-3121 02/03/2022
        private void button2_Click(object sender, EventArgs e)
        {
                //aqui es donde hacemos el llamado para poder visualizar la interfaz del administrador
                 Inicio administrador = new Inicio(); //primero creamos un nuevo objeto del form Inicio
                 administrador.MdiParent = this; // aqui establecemos el formulario MDI
                 administrador.Show(); //aqui producimos un evento
        }
        //Luis David Reyes Mijangos 0901-15-3121 02/03/2022
        private void button1_Click(object sender, EventArgs e)
        {
                //aqui es don hacemos el llamado para poder visualizar la interfaz del usuario
                reporteria_usuario usuario = new reporteria_usuario(); //primero creamos un nuevo objeto del form Inicio
            usuario.MdiParent = this;  // aqui establecemos el formulario MDI
            usuario.Show();  //aqui producimos un evento
        }
    }
}
