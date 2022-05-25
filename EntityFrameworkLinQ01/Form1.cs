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
            // CONSULTA DE ALUMNOS Y NOTAS

            /*using(var db = new ModelEjercicio())
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
            }*/

            // CONSULTA DE DEPARTAMENTOS, PROVINCIAS Y DISTRITOS

            /*using (var db = new ModelEjercicio())
            {
                DataTable table = CreaGrilla(new string[] { "Departamento", "Provincia", "Distrito" });

                var query = from depa in db.departamentos select depa;

                foreach (var depa in query)
                {
                    table.Rows.Add(depa.departamento, "", "");

                    foreach (var prov in depa.provincias)
                    {
                        table.Rows.Add("", prov.provincia, "");

                        foreach(var dist in prov.distritos)
                        {
                            table.Rows.Add("", "", dist.distrito);
                        }
                    }
                }

                dataGridView1.DataSource = table;
            }*/

            // CONSULTA DE NOTAS Y ALUMNOS

            /*using(var db = new ModelEjercicio())
            {
                DataTable table = CreaGrilla(new string[] { "Alumno", "Nota" });

                var query = from n in db.notas select n;
                
                foreach(var n in query)
                {
                    table.Rows.Add(n.alumnos2.nombre, n.nota);                    
                }

                dataGridView1.DataSource = table;
            }*/

            // CONSULTA DE DISTRITOS, PROVINCIAS Y DEPARTAMENTOS

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Departamento", "Provincia", "Distrito" });

            //    var query = from n in db.distritos select n;

            //    foreach (var n in query)
            //    {
            //        table.Rows.Add(n.provincias.departamentos.departamento, n.provincias.provincia, n.distrito);
            //    }

            //    dataGridView1.DataSource = table;
            //}

            // CONSULTA DE ALUMNOS Y NOTAS USANDO JOIN

            //using(var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Alumno", "Nota" });

            //    var query = from a in db.alumnos2
            //                join n in db.notas on a.idalumno equals n.idalumno
            //                select new
            //                {
            //                    nombre = a.nombre,
            //                    nota = n.nota
            //                };

            //    foreach(var fil in query)
            //    {
            //        table.Rows.Add(fil.nombre, fil.nota);
            //    }

            //    dataGridView1.DataSource = table;
            //}

            // CONSULTA DE DEPARTAMENTOS Y PROVINCIAS

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Departamentos", "Provincias", "Distritos" });

            //    var query = from a in db.departamentos
            //                join n in db.provincias on a.iddepartamento equals n.iddepartamento
            //                join d in db.distritos on n.idprovincia equals d.idprovincia
            //                select new
            //                {
            //                    nombre = a.departamento,
            //                    nota = n.provincia,
            //                    dis = d.distrito
            //                };

            //    foreach (var fil in query)
            //    {
            //        table.Rows.Add(fil.nombre, fil.nota, fil.dis);
            //    }

            //    dataGridView1.DataSource = table;

            //}

            // CONSULTA DE ALUMNOS CON SUS PROMEDIOS, CANTIDAD DE NOTAS, SUMA, MAXIMA Y MINIMA NOTA

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Alumno", "Promedio", "Count", "Sum", "Max", "Min" });

            //    var query = from n in db.notas 
            //                group n by n.alumnos2.nombre into grupo
            //                select new {
            //                    alumno = grupo.Key,
            //                    promedio = grupo.Average(x => x.nota),
            //                    count = grupo.Count(),
            //                    sum = grupo.Sum(x => x.nota),
            //                    max = grupo.Max(x => x.nota),
            //                    min = grupo.Min(x => x.nota)
            //                };

            //    foreach (var fil in query)
            //    {
            //        table.Rows.Add(fil.alumno, fil.promedio.ToString("#0.00"), fil.count, fil.sum, fil.max, fil.min);
            //    }

            //    dataGridView1.DataSource = table;

            //}

            // CONSULTA DE ALUMNOS CON SUS PROMEDIOS, CANTIDAD DE NOTAS, SUMA, MAXIMA Y MINIMA NOTA (JOIN)

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Alumno", "Promedio", "Count", "Sum", "Max", "Min" });

            //    var query = from a in db.alumnos2
            //                join n in db.notas on a.idalumno equals n.idalumno
            //                group n by n.alumnos2.nombre into grupo
            //                select new
            //                {
            //                    alumno = grupo.Key,
            //                    promedio = grupo.Average(x => x.nota),
            //                    count = grupo.Count(),
            //                    sum = grupo.Sum(x => x.nota),
            //                    max = grupo.Max(x => x.nota),
            //                    min = grupo.Min(x => x.nota)
            //                };

            //    foreach (var fil in query)
            //    {
            //        table.Rows.Add(fil.alumno, fil.promedio.ToString("#0.00"), fil.count, fil.sum, fil.max, fil.min);
            //    }

            //    dataGridView1.DataSource = table;

            //}

            // CONSULTA DE DEPARTAMENTOS CON SU CANTIDAD DE PROVINCIAS (JOIN)

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Departamento", "Count" });

            //    var query = from a in db.departamentos
            //                join n in db.provincias on a.iddepartamento equals n.iddepartamento
            //                join d in db.distritos on n.idprovincia equals d.idprovincia
            //                group d by n.departamentos.departamento into grupo
            //                select new
            //                {
            //                    departamento = grupo.Key,
            //                    count = grupo.Count()
            //                };

            //    foreach (var fil in query)
            //    {
            //        table.Rows.Add(fil.departamento, fil.count);
            //    }

            //    dataGridView1.DataSource = table;

            //}

            // CONSULTA DE DEPARTAMENTOS CON SU CANTIDAD DE PROVINCIAS Y DISTRITOS (JOIN)

            //using (var db = new ModelEjercicio())
            //{
            //    DataTable table = CreaGrilla(new string[] { "Departamento", "Total Prov.", "Total Dist." });

            //    var query = from depa in db.departamentos
            //                select new
            //                {
            //                    departamento = depa.departamento,
            //                    provincias = (from prov in db.provincias.Where(p => p.iddepartamento == depa.iddepartamento) 
            //                                  select prov.idprovincia).ToList().Count,
            //                    distritos = (from dist in db.distritos where depa.provincias.Contains(dist.provincias)
            //                                 select dist).ToList().Count
            //                };

            //    foreach (var fil in query)
            //    {
            //        table.Rows.Add(fil.departamento, fil.provincias, fil.distritos);
            //    }

            //    dataGridView1.DataSource = table;

            //}

            // PAGINACION
            
            using(var db = new ModelEjercicio())
            {
                DataTable table = CreaGrilla(new string[] { "ID", "Departamento" });

                var query = (from depa in db.departamentos
                             orderby depa.departamento
                             select depa).Skip(20).Take(5); // 5, 5/10, 5/15, 5/20

                foreach(var fil in query)
                {
                    table.Rows.Add(fil.iddepartamento, fil.departamento);
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
