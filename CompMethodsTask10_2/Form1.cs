using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompMethodsTask10_2
{
    public partial class Form1 : Form
    {
        Method RK;
        public Form1()
        {
            InitializeComponent();
            /*cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Амплитуда колебаний?",
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Время"
            });*/
            cartesianChart1.Zoom = ZoomingOptions.Xy;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RK = new Method();
            Point start = new Point(0, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox8.Text));
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double h_st = Convert.ToDouble(textBox4.Text);
            double eps = Convert.ToDouble(textBox5.Text);
            double k = Convert.ToDouble(textBox6.Text);
            int maxsteps = Convert.ToInt32(textBox7.Text);
            double xbord = Convert.ToDouble(textBox9.Text);

            RK.Init(start, a, b, maxsteps, h_st, eps, k,xbord, 0, 0);
            RK.Start();
            List<InfoTable> data = RK.GetMetodInfos();
            dataGridView1.RowCount = data.Count;
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = data[i].integr_step;
                dataGridView1[2, i].Value = data[i].point.X;
                dataGridView1[3, i].Value = data[i].point.V1;
                dataGridView1[4, i].Value = data[i].point.V2;
                dataGridView1[5, i].Value = "(" + data[i].half_V.V1 + ", " + data[i].half_V.V2 + " )";
                double dVH1 = data[i].point.V1 - data[i].half_V.V1;
                double dVH2 = data[i].point.V2 - data[i].half_V.V2;
                dataGridView1[6, i].Value = "(" + dVH1 + "," + dVH2 + " )";
                dataGridView1[7, i].Value = "(" + data[i].point.V1 + ", " + data[i].point.V2 + " )";
                dataGridView1[8, i].Value = data[i].S;
                dataGridView1[9, i].Value = data[i].err_loc;
                dataGridView1[10, i].Value = "(" + data[i].corr_V + ", " + data[i].corr_V2 + " )";
                dataGridView1[11, i].Value = data[i].plus_corr_Step;
                dataGridView1[12, i].Value = data[i].minus_corr_Step;

            }
            /*
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Численное решение",
                Values = new ChartValues<ObservablePoint>(RK
.GetPoints()
.Select(_ => new ObservablePoint(_.V1, _.V2))),
                PointGeometrySize = 5
            });
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            //cartesianChart1.Series.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "V'",
                });
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "V"
                });
                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Фазовый портрет",
                    Values = new ChartValues<ObservablePoint>(RK
.GetPoints()
.Select(_ => new ObservablePoint(_.V1, _.V2))),
                    PointGeometrySize = 5
                });
            }
            if (comboBox1.SelectedIndex == 1)
            {
                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "V1",
                });
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "X"
                });
                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Численное решение",
                    Values = new ChartValues<ObservablePoint>(RK
.GetPoints()
.Select(_ => new ObservablePoint(_.X, _.V1))),
                    PointGeometrySize = 5
                });
            }
            if (comboBox1.SelectedIndex == 2)
            {
                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "V2",
                });
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "X"
                });
                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Численное решение",
                    Values = new ChartValues<ObservablePoint>(RK
.GetPoints()
.Select(_ => new ObservablePoint(_.X, _.V2))),
                    PointGeometrySize = 5
                });
            }
        }
    }
}
