﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class ucNumpad : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        public static TextBoxBase CajaTexto { get; set; }

        public static int Limite { get; set; }

        private static ucNumpad _instancia;

        /// <summary>
        /// Retorna la instancia de ucNumpad
        /// </summary>
        public static ucNumpad Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ucNumpad();
                }
                return _instancia;
            }
        }

        /// <summary>
        /// Inicializa ucNumpad
        /// </summary>
        public ucNumpad()
        {
            log.Debug("Inicializando ucNumpad...");
            InitializeComponent();
            log.Debug("ucNumpad inicializado.");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            CajaTexto.Text = null;
            log.Debug("Texto limpiado.");
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            String s = CajaTexto.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
                log.Debug("Se borro un caracter.");
            }
            else
            {
                s = null;
            }
            CajaTexto.Text = s;
        }

        private void buttonNumero_Click(object sender, EventArgs e)
        {
            Button iButton = sender as Button;
            CajaTexto.Text += iButton.Text;
        }
    }
}
