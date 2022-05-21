using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLinQ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new ModelEjercicio())
            {
                DataTable table = CreaGrilla(new string[] { "Alumno", "Nota" });

                var query = from a in db.alumnos2 select a;
                
                foreach(var alum in query)
                {
                    table.Rows.Add(alum.nombre, "");
                    
                    foreach(var n in alum.notas)
                    {
                        table.Rows.Add("", n.nota);
                    }
                }

                dataGridView1.DataSource = table;
            }
        }

        private DataTable CreaGrilla(string[] titulos)
        {
            DataTable tabla = new DataTable();

            foreach(string t in titulos)
            {
                tabla.Columns.Add(t, System.Type.GetType("System.String"));
            }
            return tabla;
        }
    }
}
