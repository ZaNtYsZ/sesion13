using Registro.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            persons person = new persons();
            person.FirstName = txtNombre.Text;
            person.LastName = txtApellido.Text;
            person.Birthdate = dtpFechaNacimiento.Value;
            persons.Add(person);
            ShowPerson();
            clearFields();
        }

        private void ShowPersons()
        {
            lstPersonas DataSource = null;
            lstPersonas.DataSource = personas;
        }

        private void clearTb()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value= DateTime.Now;
            txtNombre.Focus();
        }
    }
}   
       
