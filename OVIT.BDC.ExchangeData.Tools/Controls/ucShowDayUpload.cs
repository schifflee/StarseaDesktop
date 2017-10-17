using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starsea.UIControl.Chart;

namespace OVIT.BDC.ExchangeData.Tools.Controls
{
    public partial class ucShowDayUpload : UserControl
    {
        public ucShowDayUpload()
        {
            InitializeComponent();

            loadChart();
        }

        private void loadChart()
        {
            UIChartBar vbar = new UIChartBar();
            this.panelEx1.Controls.Add(vbar);
            vbar.SetChartTitle("每天上报数量");
            vbar.SetAsixTitleText("xxx", "yyyy");


            UIChartSeries uiseries = new UIChartSeries();
            UIChartSeriesPoint point1 = new UIChartSeriesPoint("1", new object[] { 1 });
            UIChartSeriesPoint point1a = new UIChartSeriesPoint("1", new object[] {3 });
            UIChartSeriesPoint point2 = new UIChartSeriesPoint("2", new object[] { 2 });
            UIChartSeriesPoint point3 = new UIChartSeriesPoint("3", new object[] { 4 });
            UIChartSeriesPoint point4 = new UIChartSeriesPoint("4", new object[] {5 });
            UIChartSeriesPoint point5 = new UIChartSeriesPoint("5", new object[] { 6 });
            UIChartSeriesPoint point6 = new UIChartSeriesPoint("6", new object[] { 12 });
            UIChartSeriesPoint point7 = new UIChartSeriesPoint("7", new object[] {8 });
            UIChartSeriesPoint point8 = new UIChartSeriesPoint("8", new object[] { 10 });
            UIChartSeriesPoint point9 = new UIChartSeriesPoint("9", new object[] { 9 });
            UIChartSeriesPoint point10 = new UIChartSeriesPoint("10", new object[] { 13 });
            UIChartSeriesPoint point11 = new UIChartSeriesPoint("11", new object[] { 21 });
            uiseries.AddPoint(point1);
            uiseries.AddPoint(point1a);
            uiseries.AddPoint(point2);
            uiseries.AddPoint(point3);
            uiseries.AddPoint(point4);
            uiseries.AddPoint(point5);
            uiseries.AddPoint(point6);
            uiseries.AddPoint(point7);
            uiseries.AddPoint(point8);
            uiseries.AddPoint(point9);
            uiseries.AddPoint(point10);
            uiseries.AddPoint(point11);


            UIChartSeries uiseries1 = new UIChartSeries();
            UIChartSeriesPoint pointa1 = new UIChartSeriesPoint("1", new object[] { 12 });
            UIChartSeriesPoint pointa1a = new UIChartSeriesPoint("1", new object[] { 13 });
            UIChartSeriesPoint pointa2 = new UIChartSeriesPoint("2", new object[] { 21 });
            UIChartSeriesPoint pointa3 = new UIChartSeriesPoint("3", new object[] { 14 });
            UIChartSeriesPoint pointa4 = new UIChartSeriesPoint("4", new object[] { 15 });
            UIChartSeriesPoint pointa5 = new UIChartSeriesPoint("5", new object[] { 16 });
            UIChartSeriesPoint pointa6 = new UIChartSeriesPoint("6", new object[] { 12 });
            UIChartSeriesPoint pointa7 = new UIChartSeriesPoint("7", new object[] { 18 });
            UIChartSeriesPoint pointa8 = new UIChartSeriesPoint("8", new object[] { 10 });
            UIChartSeriesPoint pointa9 = new UIChartSeriesPoint("9", new object[] { 19 });
            UIChartSeriesPoint pointa10 = new UIChartSeriesPoint("10", new object[] { 23 });
            UIChartSeriesPoint pointa11 = new UIChartSeriesPoint("11", new object[] { 11 });
            uiseries1.AddPoint(pointa1);
            uiseries1.AddPoint(pointa1a);
            uiseries1.AddPoint(pointa2);
            uiseries1.AddPoint(pointa3);
            uiseries1.AddPoint(pointa4);
            uiseries1.AddPoint(pointa5);
            uiseries1.AddPoint(pointa6);
            uiseries1.AddPoint(pointa7);
            uiseries1.AddPoint(pointa8);
            uiseries1.AddPoint(pointa9);
            uiseries1.AddPoint(pointa10);
            uiseries1.AddPoint(pointa11);

            uiseries.SetLegendText("AAAA");
            uiseries.SetSeriesType_Line();
            vbar.AddChartSeries(uiseries);
            uiseries1.SetLegendText("bbb");
            uiseries1.SetSeriesType_Line();
            vbar.AddChartSeries(uiseries1);


        }
    }
}
