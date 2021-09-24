using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instancia de la clase Profesor
            Professor professor = new Professor();
            professor.setProfesorId(1);
            professor.setTitulo("Tecnico en Ingles");

            //Mostrar datos de Porfesor
            MessageBox.Show(professor.getProfesorId() + professor.getTitulo());
        }
    }
}
