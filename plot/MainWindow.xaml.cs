using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
using System.Drawing;

namespace plot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Define the data
            double[,] data = new double[,]
            {
            { 1.0, 1.0 },
            { 2.0, 3.0 },
            { 3.0, 2.0 },
            { 4.0, 4.0 },
            { 5.0, 3.0 },
            { 6.0, 5.0 }
            };

            // Create a scatter plot series
            ScatterSeries series = new ScatterSeries();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                series.Points.Add(new ScatterPoint(data[i, 0], data[i, 1]));
            }

            // Create a new plot model and add the series to it
            PlotModel plotModel = new PlotModel();
            plotModel.Series.Add(series);

            // Set the plot model as the model for the plot view
            plotView.Model = plotModel;
        }
    }
    
}

