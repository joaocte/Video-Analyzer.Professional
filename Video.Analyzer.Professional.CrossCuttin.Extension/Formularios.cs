using ClosedXML.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace Video.Analyzer.Professional.CrossCuttin.Extension
{
    public static class Formularios
    {
        public static void DesabilitaComponetes(this Control control, Type type)
        {
            var ctr = GetAll(control, type);
            foreach (var ct in ctr)
            {
                ct.Enabled = false;
            }
        }

        public static void ExportaExcel<T>(this DataGridView grid)
        {
            // Creating a Excel object.
            try
            {
                if (grid.Rows.Count > 0)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = new DataTable();
                        dt = grid.DataSource.ToDataTable<T>();
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "Animal");
                            wb.SaveAs(saveDialog.FileName);
                        }
                        MessageBox.Show("Salvo Com Sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Processamento " + ex.Message);
            }
        }

        public static void HabilitaComponetes(this Control control, Type type)
        {
            var ctr = GetAll(control, type);
            foreach (var ct in ctr)
            {
                ct.Enabled = true;
            }
        }

        public static void InitLayout(this DataGridView grid)
        {
            //base.InitLayout();

            //Cor de fundo das linhas
            grid.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(184, 204, 228);

            //Cor do texto
            grid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            //Cor de fundo das linhas alternadas
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 229, 241);

            //Cor do texto das linhas alternadas
            grid.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            //Cor de fundo da linha selecionada
            grid.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(78, 129, 189);

            //Cor do texto da linha selecionada
            grid.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

            //Cor de fundo do DataGridView (parte sem nenhuma informação)
            grid.BackgroundColor = System.Drawing.Color.FromArgb(220, 220, 220);

            //Gosto de deixar o modo de seleção como FullRowSelect, desta forma ao clicar em uma célula a linha inteira é marcada
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void LimpaComponentes(this Control control, Type type)
        {
            var ctr = GetAll(control, type);
            foreach (var ct in ctr)
            {
                ct.Text = string.Empty;
            }
        }

        public static bool RetornoComboBox(this ComboBox control, string texto)
        {
            return control != null && control.Text == texto;
        }

        public static DataTable ToDataTable<T>(this object t)
        {
            IEnumerable data = (IEnumerable)t;
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        private static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }
    }
}