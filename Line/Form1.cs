
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Line
{
    public partial class Form1 : Form
    {
        bool verify;
        public void build_grafic(double x1, double x2, double n, double a)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            bool infinity_y = false;
            for (double i = x1; i <= x2; i += n)
            {
                double m = (double)(a / 2);
                double degree = (double)(i / a);
                double min_degree = -degree;

                x.Add(i);

               // var y_tmp = m * (Math.Exp(degree) + Math.Exp(min_degree));
                var y_tmp = Math.Sqrt((Math.Pow(a, 2) * Math.Pow(i, 2)- Math.Pow(i, 4)) / Math.Pow(a, 2));
                y.Add(y_tmp);
                //if (y_tmp < 1000000) { y.Add(y_tmp); }
                //else
                //{
                //    MessageBox.Show("Коэффициент a слишком маленький,попробуйте увеличить его значение");
                //    infinity_y = true;
                //    break;
                //}
            }
            if (infinity_y != true)
            {
                for (int i = 0; i < x.Count(); i++)
                {
                    grafic.Series["Series1"].Points.AddXY(x[i], y[i]);
                }
                for (int i = 0; i < x.Count(); i++)
                {
                    grafic.Series["Series1"].Points.AddXY(-x[i], y[i]);
                }
                table_result.RowCount = x.Count();
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < x.Count(); j++)
                    {
                        table_result.Rows[j].Cells[i].Value = x[j];
                        table_result.Rows[j].Cells[i + 1].Value = y[j].ToString("f3");
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            grafic.Series["Series1"].Points.AddXY(-5, 4.994);
            grafic.Series["Series1"].Points.AddXY(-4, 3.997);
            grafic.Series["Series1"].Points.AddXY(-3, 2.999);
            grafic.Series["Series1"].Points.AddXY(-2, 2);
            grafic.Series["Series1"].Points.AddXY(-1, 1);
            grafic.Series["Series1"].Points.AddXY(0, 0);
            grafic.Series["Series1"].Points.AddXY(1, 1);
            grafic.Series["Series1"].Points.AddXY(2, 2);
            grafic.Series["Series1"].Points.AddXY(3, 2.999);
            grafic.Series["Series1"].Points.AddXY(4, 3.997);
            grafic.Series["Series1"].Points.AddXY(5, 4.994);
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            foreach (var series in grafic.Series)
            {
                series.Points.Clear();
            }

            var strx1 = textBox_x1.Text;
            double x1;
            if (!double.TryParse(strx1, out x1))
            {
                MessageBox.Show("Введите число");
                return;
            }
            var strx2 = textBox_x2.Text;
            double x2;
            if (!double.TryParse(strx2, out x2))
            {
                MessageBox.Show("Введите число");
                return;
            }
            if (x1 >= x2)
            {
                MessageBox.Show("Верхняя граница должна быть больше нижней.");
                return;
            }
            var strn = textBox_n.Text;
            double n;
            if (!double.TryParse(strn, out n))
            {
                MessageBox.Show("Введите число");
                return;
            }
            if (n < 0.1)
            {
                MessageBox.Show("Шаг должен быть больше 0.");
                return;
            }
            var stra = textBox_a.Text;
            double a;
            if (!double.TryParse(stra, out a))
            {
                MessageBox.Show("Введите число");
                return;
            }
            if (a==0)
            {
                MessageBox.Show("Коэффициент не должен равняться 0");
                return;
            }
            build_grafic(x1, x2, n, a);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void grafic_Click(object sender, EventArgs e)
        {

        }
        private void textBox_x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void table_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void file_input_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dialog.FileName);
                if (ext != ".txt")
                {
                    MessageBox.Show("Файл должен быть с расширением txt");
                    return;
                }

                using (var dataStream = new StreamReader(dialog.FileName))
                {


                    double x1;
                    var str_x1 = dataStream.ReadLine();
                    try
                    {
                        x1 = double.Parse(str_x1);
                        textBox_x1.Text = str_x1;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("x1 должно быть числом.");
                        return;
                    }


                    double x2;
                    var str_x2 = dataStream.ReadLine();
                    try
                    {
                        x2 = double.Parse(str_x2);
                        textBox_x2.Text = str_x2;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("x2 должно быть числом.");
                        return;
                    }
                    if (x2 <= x1)
                    {
                        MessageBox.Show("Верхняя граница должна быть больше нижней.");
                        return;
                    }

                    double n;
                    var str_n = dataStream.ReadLine();
                    try
                    {
                        n = double.Parse(str_n);
                        textBox_n.Text = str_n;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("n должно быть числом.");
                        return;
                    }

                    double a;
                    var a_String = dataStream.ReadLine();

                    try
                    {
                        a = double.Parse(a_String);
                        textBox_a.Text = Convert.ToString(a);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("a должно быть числом.");
                        return;
                    }


                    if (n < 0.1)
                    {
                        MessageBox.Show("n должно быть больше 0.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Не удалось загрузить файл.");
            }
        }
    

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void file_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Test files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(textBox_x1.Text);
                    sw.WriteLine(textBox_x2.Text);
                    sw.WriteLine(textBox_a.Text);
                    sw.WriteLine(textBox_n.Text);
                    sw.Close();
                }
            }

        }



        private void save_result_Click(object sender, EventArgs e)
        {
            if (table_result.Rows.Count >0)
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "Test files|*.txt";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                    saveFile1.FileName.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                    {
                        try
                        {
                            for (int j = 0; j < table_result.Rows.Count; j++)
                            {
                                for (int i = 0; i < table_result.Rows[j].Cells.Count; i++)
                                {
                                    sw.Write(table_result.Rows[j].Cells[i].Value + "   ");
                                }
                                sw.WriteLine();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Ошибка при сохранении данных");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала нужно нажать Ok.");
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool change_state(bool ver)
        {
            string file_path = "check.txt";
            using (StreamWriter sw = new StreamWriter(file_path, false))
            {
                if (ver)
                {
                    try
                    {
                        sw.WriteLine("true");
                        ToolStripMenuItem.Text = "Показать";
                        sw.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Файл не открывается");
                        
                    }
                    return true;
                }
                else
                {
                    sw.WriteLine("false");
                    ToolStripMenuItem.Text = "Скрыть";
                    sw.Close();
                    return false;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ToolStripMenuItem.Text == "Скрыть")
            {
                ToolStripMenuItem.Checked= true;
                ToolStripMenuItem.Text = "Показать";
            }
            else if(ToolStripMenuItem.Text == "Показать")
            {
                ToolStripMenuItem.Checked = false;
                ToolStripMenuItem.Text = "Скрыть";
            }
            verify = ToolStripMenuItem.Checked;
            change_state(verify);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string file_path = "check.txt";
            bool check;
            //var filestream = File.OpenRead(file_path);
            using (var sr=new StreamReader(file_path))
            {
                
                var str_check = sr.ReadLine();
                try
                {
                    bool.TryParse(str_check, out verify);
                    check= verify;
                    sr.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Файл не читается.");
                    return;
                }
                if (check == false)
                {
                    ToolStripMenuItem.Text = "Скрыть";
                    MessageBox.Show("Латыпов Амир 414 группа Вариант 12\nПрактическая работа 3: Лемниската Жероно.");
                }
                else
                {
                    ToolStripMenuItem.Text = "Показать";
                }
            }

        }
    }
}
