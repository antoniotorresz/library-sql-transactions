﻿using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_sql_transactions
{
    public partial class Form1 : Form
    {
        private List<string> autores = new List<string>();
        private List<string> pags = new List<string>();
        public Form1()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarLibros();
            ListarAutores();

        }

        private void ListarAutores()
        {
            dgvaut.DataSource = ControladorAutores.ListarAutores();
            dgvaut.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvaut.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvaut.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvaut.AllowUserToResizeColumns = false;
            dgvaut.AllowUserToResizeRows = false;
        }

        private void ListarLibros()
        {
            dgvlib.DataSource = ControladorLibros.ListarLibros();
            dgvlib.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvlib.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvlib.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvlib.AllowUserToResizeColumns = false;
            dgvlib.AllowUserToResizeRows = false;
        }

        private void LlenarCombo()
        {

            DataTable dt = ControladorAutores.ListarNombreAutores();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbAutores.Items.Add(dt.Rows[i]["nombre"]);
            }

        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                autores.Add(Convert.ToString(cmbAutores.Text));
                pags.Add(Convert.ToString(npags.Text));
                CargarLista();

                npags.Text = "";
                cmbAutores.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void LimpiarCampos()
        {
            tbTitulo.Text = "";
            tbEdit.Text = "";
            tbISBN.Text = "";
            tbPais.Text = "";
            tvUrl.Text = "";
            this.autores.Clear();
            this.pags.Clear();
            CargarLista();
        }

        private void CargarLista()
        {
            listView1.Clear();
            listView2.Clear();
            foreach (string nombre in this.autores)
            {
                listView1.Items.Add(nombre);
            }

            foreach (string n in this.pags)
            {
                listView2.Items.Add(n);
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {

            string mensaje = ControladorLibros.InsertarLibroAutor(Convert.ToString(tbTitulo.Text), Convert.ToString(tbEdit.Text),
                Convert.ToDateTime(dateTimePicker1.Value), Convert.ToString(tbPais.Text), Convert.ToString(tbISBN.Text), Convert.ToString(tvUrl.Text)
                , this.autores, this.pags);

            MessageBox.Show(mensaje);
            
            LimpiarCampos();
            ListarLibros();
        }
    }
}
