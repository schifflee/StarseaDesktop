using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
    public class UIChartSeries : ChartSeries
    {
        public UIChartSeries()
        {
            ChartLineAreaDisplayMode = DevComponents.DotNetBar.Charts.ChartLineAreaDisplayMode.DisplayLine;

            CrosshairHighlightPoints = DevComponents.DotNetBar.Charts.Style.Tbool.True;
            DataLabelVisualStyle.TextColor = System.Drawing.Color.RoyalBlue;
            DataLabelVisualStyle.TextFormat = "{Y:f2}";
            EmptyValues = null;
            LegendText = "";
            //Name = "Series1";


            //DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint1 = new DevComponents.DotNetBar.Charts.SeriesPoint();
            //seriesPoint1.ValueX = "2017-10-11";
            //seriesPoint1.ValueY = new object[] { (object)(1.356) };

            //SeriesPoints.Add(seriesPoint1);

            //SeriesType = DevComponents.DotNetBar.Charts.SeriesType.VerticalBar;
        }

        public void SetSeriesType_VerticalBar()
        {
            SeriesType = DevComponents.DotNetBar.Charts.SeriesType.VerticalBar;
        }

        public void SetSeriesType_Line()
        {
            SeriesType = DevComponents.DotNetBar.Charts.SeriesType.Line;
        }
        public void AddPoint(UIChartSeriesPoint point) {
            SeriesPoints.Add(point);
        }

        public void SetLegendText(string text) {
            LegendText = text;
        }
    }
}
