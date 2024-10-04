using control_elements_sena.Forms.Create;
using System;
using System.Data;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using control_elements_sena.Controllers;


namespace control_elements_sena
{
    public partial class Reportes : Form
    {
        public static string fechaInicial = null;
        public static string fechaFinal = null;
        public Reportes()
        {
            InitializeComponent();
        }

        async private void Reportes_Load(object sender, EventArgs e)
        {
            Session session = new Session();
            await session.DescifrarTokenAsync();
            if (!session.validToken)
            {
                MessageBox.Show("Su sesión expiró, inicie sesión nuevamente", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            LoadChartData();
          
        }

        private void LoadChartData()
        {
            var dataGraph = Controllers.Reportes.Reportes.ElementosEntrantesMes();
            if (dataGraph.Item2)
            {
                DataTable dataTable = dataGraph.Item1;

                // Limpiar el gráfico antes de añadir nuevos datos
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Configuración de la serie del gráfico
                Series series = new Series
                {
                    Name = "Cantidad",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = System.Drawing.Color.FromArgb(4, 50, 77) // Color especificado para las barras
                };
                chart.Series.Add(series);

                // Añadir los datos al gráfico
                foreach (DataRow row in dataTable.Rows)
                {
                    string marca = row["marca"].ToString();
                    string serie = row["serie"].ToString();
                    string identificacion = row["identificacion"].ToString();
                    string nombres = row["nombres"].ToString();
                    int cantidad = Convert.ToInt32(row["cantidad"]);

                    // Para mostrar la marca o serie en el eje X y la cantidad en el eje Y
                    series.Points.Add(new DataPoint
                    {
                        AxisLabel = $"{marca} ({serie})\n{identificacion}\n{nombres}",
                        YValues = new[] { (double)cantidad }
                    });
                }

                // Configuración adicional del gráfico
                chart.ChartAreas[0].AxisX.Title = "Elementos y Registros";
                chart.ChartAreas[0].AxisY.Title = "Cantidad de Entradas";
                chart.Titles.Add("Elementos que más entraron este mes");

                // Configuración para mostrar correctamente las etiquetas
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotar etiquetas
                chart.ChartAreas[0].AxisX.IsLabelAutoFit = true; // Auto-fit de etiquetas
                chart.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas
                chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8); // Ajustar tamaño de fuente
                chart.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; // Etiquetas escalonadas

                // Ocultar líneas y bordes no deseados
                chart.ChartAreas[0].AxisX.LineWidth = 0;
                chart.ChartAreas[0].AxisY.LineWidth = 0;
                chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chart.ChartAreas[0].AxisX.MinorGrid.LineWidth = 0;
                chart.ChartAreas[0].AxisY.MinorGrid.LineWidth = 0;
                chart.ChartAreas[0].BorderWidth = 0;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            bool condition = true;
            if (cmbType.Text == "Lista de Registros" && cmbFormat.Text == "Excel")
            {

                dataTable = Controllers.Registros.Registros.SeleccionarRegistros("1", "0").Item1;

            }
            else if (cmbType.Text == "Lista de Elementos" && cmbFormat.Text == "Excel")
            {
                dataTable = Controllers.Elementos.Elementos.SeleccionarElementos("1", "0").Item1;
            }
            else if (cmbType.Text == "Lista de Denuncias" && cmbFormat.Text == "Excel")
            {
                dataTable = Controllers.Denuncias.Denuncias.SeleccionarDenuncias("1").Item1;
            }
            else if (cmbType.Text == "Entradas Totales" && cmbFormat.Text == "Excel")
            {

                dataTable = Controllers.Entradas.Entradas.SeleccionarEntradas("1").Item1;

            }
            else if (cmbType.Text == "Entradas del Mes" && cmbFormat.Text == "Excel")
            {
                // Obtener la fecha actual
                DateTime now = DateTime.Now;

                // Primera fecha: primer día del mes
                DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);

                // Segunda fecha: último día del mes
                DateTime lastDayOfMonth = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));

                // Llamada al procedimiento almacenado
                dataTable = Controllers.Entradas.Entradas.SeleccionarEntradasFecha("SIN LIMITE", "3", firstDayOfMonth.ToString("yyyy-MM-dd"), lastDayOfMonth.ToString("yyyy-MM-dd")).Item1;

            }
            else if (cmbType.Text == "Entradas por Fecha" && cmbFormat.Text == "Excel")
            {
                if (fechaInicial != null && fechaFinal != null)
                {
                    dataTable = Controllers.Entradas.Entradas.SeleccionarEntradasFecha("SIN LIMITE", "3", fechaInicial, fechaFinal).Item1;
                    fechaInicial = null;
                    fechaFinal = null;
                }
                else
                {
                    MessageBox.Show("Selecciona un rango de fecha", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cmbType.Text == "Entradas de Hoy o Activas" && cmbFormat.Text == "Excel")
            {
                dataTable = Controllers.Entradas.Entradas.SeleccionarEntradas("0").Item1;
            }
            else if (cmbType.Text == "Denuncias Activas" && cmbFormat.Text == "Excel")
            {
                dataTable = Controllers.Denuncias.Denuncias.SeleccionarDenuncias("0").Item1;
            }

            // Ruta a la carpeta de documentos del usuario
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            // Asegurarse de que la carpeta existe
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (cmbFormat.Text == "Excel")
            {

                if (File.Exists(Path.Combine(directoryPath, $"{cmbType.Text}.xlsx")))
                {
                    if (MessageBox.Show("Si generas este reporte, reemplazará el que ya existe. ¿Estás seguro?", "Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                if (condition)
                {

                    // Definir la ruta completa del archivo
                    string filePath = Path.Combine(directoryPath, $"{cmbType.Text}.xlsx");

                    // Configurar EPPlus para uso no comercial
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    try
                    {
                        using (ExcelPackage excel = new ExcelPackage())
                        {
                            var worksheet = excel.Workbook.Worksheets.Add("Datos");

                            // Crear una fila de título en la primera fila (Fila 1)
                            string titulo = cmbType.Text;
                            worksheet.Cells["A1"].Value = titulo;

                            // Combinar celdas para el título (Combina de A1 hasta la última columna)
                            worksheet.Cells[1, 1, 1, dataTable.Columns.Count].Merge = true;

                            // Negrita y centrado del título
                            worksheet.Cells["A1"].Style.Font.Bold = true;
                            worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            worksheet.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                            // Colocar los nombres de las columnas y capitalizar la primera letra
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                string columnName = dataTable.Columns[i].ColumnName;
                                worksheet.Cells[2, i + 1].Value = char.ToUpper(columnName[0]) + columnName.Substring(1);
                            }

                            // Cargar los datos en la hoja de cálculo, comenzando desde la fila 3
                            worksheet.Cells["A3"].LoadFromDataTable(dataTable, false);

                            // Formatear como tabla con bordes y estilo
                            ExcelRange dataRange = worksheet.Cells[2, 1, dataTable.Rows.Count + 2, dataTable.Columns.Count];
                            var excelTable = worksheet.Tables.Add(dataRange, "DatosTabla");
                            excelTable.TableStyle = TableStyles.Light14; // Estilo de tabla predefinido con bordes

                            // Autoajustar el ancho de todas las columnas
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Guardar el archivo Excel
                            FileInfo excelFile = new FileInfo(filePath);
                            excel.SaveAs(excelFile);
                        }
                        MessageBox.Show("Reporte generado correctamente en el escritorio del equipo", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show($"No se pudo acceder a la ruta: {ex.Message}", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (cmbFormat.Text == "PDF")
            {

                if (File.Exists(Path.Combine(directoryPath, $"{cmbType.Text}.pdf")))
                {
                    if (MessageBox.Show("Si generas este reporte, reemplazará el que ya existe. ¿Estás seguro?", "Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                if (condition)
                {

                    string filePath = Path.Combine(directoryPath, $"{cmbType.Text}.pdf");

                }
            }
            else
            {
                MessageBox.Show("Elige un formato", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbType.Text == "Entradas por Fecha")
            {
                ReportsDates reportsDates = new ReportsDates();
                reportsDates.ShowDialog();
            }
        }
    }
}
