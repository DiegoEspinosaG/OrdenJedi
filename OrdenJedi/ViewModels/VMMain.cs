using OrdenJedi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenJedi.ViewModels
{
    internal class VMMain
    {


        public void InitMain(FrmMain frm)
        {
            try
            {
                using (OrdenJediEntities db = new OrdenJediEntities())
                {
                    var list = (from M in db.Miembros
                                join R in db.RelMiembrosPlanetas on M.MiembroID equals R.MiembroID
                                join N in db.Rangos on M.RangoID equals N.RangoID
                                join P in db.Planetas on R.PlanetaID equals P.PlanetaID
                                select new
                                {
                                    Jedi = M.Nombre + " " + M.Apellidos,
                                    Rango = N.Rango == "Maestro" ? "SI" : "No",
                                    Sistema = P.Planeta != null ? P.Planeta : "TEMPLO"

                                }).OrderBy(p => p.Jedi).ToList();

                    frm.DGVReport.DataSource = list;
                    frm.DGVReport.Columns["Jedi"].Visible = true;
                    frm.DGVReport.Columns["Jedi"].HeaderText = "Nombre Caballero";
                    frm.DGVReport.Columns["Rango"].Visible = true;
                    frm.DGVReport.Columns["Rango"].HeaderText = "Rango Maestro (SI/NO)";
                    frm.DGVReport.Columns["Sistema"].Visible = true;
                    frm.DGVReport.Columns["Sistema"].HeaderText = "Sistema Estelar en el que combate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción al cargar el reporte. {ex.Message}", "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
