﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VsPrincipal : Form
    {
        public VsPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VsActividad act = new VsActividad(); act.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VsRegistrarCliente rgCliente = new VsRegistrarCliente();
            rgCliente.ShowDialog();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            VsMembresia act = new VsMembresia();
            act.Visible = true;
        }

    // FIN
    }
}
