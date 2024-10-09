using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form2___Lect_Escr_de_archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbNombres.Leave+= checkNombres;
            tbApellidos.Leave+=checkApellidos;
            tbEdad.Leave+=checkEdad;
            tbEstatura.Leave+=checkEstatura;
            tbTelefono.Leave+=checkTelefono;
        }

        private bool isValidInt(string str)
        {
            int resultado;
            return int.TryParse(str, out resultado);
        }
        private bool isValidFloat(string str)
        {
            decimal resultado;
            return decimal.TryParse(str, out resultado);
        }
        private bool isValidTenDigitNum(string str)
        {
            long resultado;
            return long.TryParse(str, out resultado) && str.Length ==10;
        }
        private bool isValidText(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z\s]+$");
        }
        private void checkEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidInt(textBox.Text))
                {
                    MessageBox.Show("Ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }
        private void checkEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidFloat(textBox.Text))
                {
                    MessageBox.Show("Introduzca un valor decimal valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }
        private void checkNombres(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidText(textBox.Text))
                {
                    MessageBox.Show("Introduzca un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }
        private void checkTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidTenDigitNum(textBox.Text))
                {
                    MessageBox.Show("Introduzca un numero valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }
        private void checkApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidText(textBox.Text))
                {
                    MessageBox.Show("Introduzca un apellido valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos;
            int edad;
            float estatura;
            long telefono;
            
            edad = int.Parse(tbEdad.Text);
            estatura = float.Parse(tbEstatura.Text);
            telefono = long.Parse(tbTelefono.Text);
            nombres = tbNombres.Text;
            apellidos = tbApellidos.Text;

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono} \r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGenero: {genero}";

            string rutaArchivo = "C:\\Users\\eduso\\Desktop\\P.A\\C# PA\\datos.txt";
            File.WriteAllText(rutaArchivo, datos);

            bool ArchivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void bBorrar_Click(object sender, EventArgs e)
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}