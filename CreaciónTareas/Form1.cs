﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CreaciónTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblResultado.Rows.Clear();
            GenerarFilasResultado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InsertaRegistrosPrueba();
            InsertaCategoriaTareas();
        }

        private void GenerarFilasResultado()
        {
            try
            {
                int totalFilas = tblComponentes.Rows.Count;
                for (int i = 0; i < totalFilas; i++)//recorremos componentes
                {
                    if (tblComponentes.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    string IndexLvl1Value = (i + 1).ToString("D2");  //Permite llevar el numeral del componente: "01 Componente"


                    tblResultado.Rows.Add(GenerarTextoTitulo1(i, IndexLvl1Value), "");

                    for (int j = 0; j < tblCategoryTask.Rows.Count; j++)//recorremos las categorías de las tareas
                    {
                        if (tblCategoryTask.Rows[j].Cells[0].Value == null)//nos saltamos la categoría si no tiene la primer columna con check
                            continue;
                        if (tblCategoryTask.Rows[j].Cells[0].Value.ToString() != "1")
                            continue;

                        string contadorCheckedItems = j.ToString("D2"); //Almacena el indice de la tarea para el componente actual: "01.01 Entendimiento"
                        var row = tblCategoryTask.Rows[j];

                        float time;
                        if (tblComponentes.Rows[i].Cells[1].Value == null)
                        {
                            time = 0;
                        }
                        else
                        {
                            time = CalculaTiemposPorTarea(
                                float.Parse(tblComponentes.Rows[i].Cells[1].Value.ToString() != "" ? tblComponentes.Rows[i].Cells[1].Value.ToString() : "0"),
                                float.Parse(row.Cells[2].FormattedValue.ToString() != "" ? row.Cells[2].FormattedValue.ToString() : "0"));
                        }



                        tblResultado.Rows.Add("",
                                            GenerarTextoTitulo2(row.Cells[1].FormattedValue.ToString(),
                                            IndexLvl1Value,
                                            contadorCheckedItems),
                                            time <= 0 ? "" : time.ToString());
                    }
                }

                lblcantidadFilas.Text = tblResultado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        /// <summary>
        /// Árma la estructura del título en el primer nivel (nombre del componente)
        /// </summary>
        /// <param name="indexFilaComponente"></param>
        /// <param name="IndexLvl1Value"></param>
        /// <returns></returns>
        private string GenerarTextoTitulo1(int indexFilaComponente, string IndexLvl1Value)
        {
            string Nombre = tblComponentes.Rows[indexFilaComponente].Cells[0].Value.ToString();
            string resultado = string.Format("{0} {1}: {2} {3}", txtTipo.Text, txtID.Text, IndexLvl1Value, Nombre);
            return resultado;
        }

        /// <summary>
        /// Árma la estructura del título nivel 2 (Nivel de la tarea con tiempos)
        /// </summary>
        /// <param name="TextoTarea"></param>
        /// <param name="IndexLvl1Value"></param>
        /// <param name="contadorCheckedItems"></param>
        /// <returns></returns>
        private string GenerarTextoTitulo2(string TextoTarea, string IndexLvl1Value, string contadorCheckedItems)
        {
            string resultado = string.Format("{0} {1}: Task {2}.{3} {4}", txtTipo.Text, txtID.Text, IndexLvl1Value, contadorCheckedItems, TextoTarea);
            return resultado;
        }

        /// <summary>
        /// Para armar las pruebas rápidamente metemos datos temporales
        /// </summary>
        private void InsertaRegistrosPrueba()
        {
            for (int i = 0; i < 5; i++)
            {
                tblComponentes.Rows.Add("AngularComponent" + i.ToString(), "1");
            }
        }

        private void InsertaCategoriaTareas()
        {
            tblCategoryTask.Rows.Add(1, "Entendimiento", 10);
            tblCategoryTask.Rows.Add(1, "Elaboración de código", 65);
            tblCategoryTask.Rows.Add(1, "Elaboración de pruebas unitarias", 15);
            tblCategoryTask.Rows.Add(1, "Review", 10);
            tblCategoryTask.Rows.Add(0, "PeerReview", 0);
            tblCategoryTask.Rows.Add(0, "Pruebas", 0);
            tblCategoryTask.Rows.Add(0, "Posmortem", 0);

        }

        /// <summary>
        /// Permite pegar tablas copiadas en excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (tblComponentes.RowCount > 0)
                    tblComponentes.Rows.Clear();

                if (tblComponentes.ColumnCount > 0)
                    tblComponentes.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            tblComponentes.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    tblComponentes.Rows.Add();
                    int myRowIndex = tblComponentes.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = tblComponentes.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblComponentes.Rows.Clear();
        }

        private float CalculaTiemposPorTarea(float total, float percentage)
        {
            float result = 0;
            if (percentage > 0)
            {
                float percentageValue = percentage / 100;
                result = total * percentageValue;
            }
            return result;
        }
    }
}
