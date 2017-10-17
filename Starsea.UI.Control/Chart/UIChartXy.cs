using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
    public class UIChartXy : ChartXy
    {
        public UIChartXy()
        {
            UIChartStyleBackground background1 = new UIChartStyleBackground();
            background1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            AxisX.ChartAxisVisualStyle.AlternateBackground = background1;

            AxisX.MajorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.Gainsboro;
            AxisX.MinorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.WhiteSmoke;
            AxisX.MinorTickmarks.TickmarkCount = 0;


            AsixTitle asixTitle1 = new DevComponents.DotNetBar.Charts.AsixTitle();
            //asixTitle1.Name = null;
            asixTitle1.Text = "日期(YYYY-MM-DD),最近100天";
            AxisX.Title = asixTitle1;

            AxisX.UseAlternateBackground = true;

            AxisY.AxisAlignment = DevComponents.DotNetBar.Charts.AxisAlignment.Far;
            AxisY.AxisMargins = 30;
            AxisY.MajorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.Gainsboro;
            AxisY.MajorTickmarks.LabelVisualStyle.TextColor = System.Drawing.Color.Navy;
            AxisY.MajorTickmarks.LabelVisualStyle.TextFormat = "";
            AxisY.MinorGridLines.GridLinesVisualStyle.LineColor = System.Drawing.Color.WhiteSmoke;

            DevComponents.DotNetBar.Charts.AsixTitle asixTitle2 = new DevComponents.DotNetBar.Charts.AsixTitle();
            asixTitle2.ChartTitleVisualStyle.Alignment = DevComponents.DotNetBar.Charts.Style.Alignment.TopCenter;
            asixTitle2.ChartTitleVisualStyle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            asixTitle2.ChartTitleVisualStyle.TextColor = System.Drawing.Color.Navy;
            //asixTitle2.Name = null;
            asixTitle2.Text = "报文数 (个)";
            AxisY.Title = asixTitle2;

            BarLabelPosition = DevComponents.DotNetBar.Charts.BarLabelPosition.Far;

            ChartCrosshair.CrosshairLabelMode = DevComponents.DotNetBar.Charts.CrosshairLabelMode.EachSeries;
            UIChartStyleBackground background2 = new UIChartStyleBackground();
            background2.Color1 = System.Drawing.Color.White;
            ChartCrosshair.CrosshairVisualStyle.Background = background2;
            ChartCrosshair.HighlightPoints = true;
            ChartCrosshair.ShowCrosshairLabels = true;
            ChartCrosshair.ShowValueXLabels = true;
            ChartCrosshair.ShowValueXLine = true;
            ChartCrosshair.ShowValueYLabels = true;
            ChartCrosshair.ShowValueYLine = true;
           // ChartCrosshair.Visible = false;



            UIChartStyleBackground background3 = new UIChartStyleBackground();
            background3.Color1 = System.Drawing.Color.Yellow;
            ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Background = background3;
            ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Size = new System.Drawing.Size(15, 15);
            ChartSeriesVisualStyle.MarkerHighlightVisualStyle.Type = DevComponents.DotNetBar.Charts.PointMarkerType.Ellipse;

            UIChartStyleBackground background4 = new UIChartStyleBackground();
            background4.Color1 = System.Drawing.Color.White;
            ChartVisualStyle.Background = background4;

     

            UIChartStyleBorderColor borderColor1 = new UIChartStyleBorderColor();
            borderColor1.SetColor(System.Drawing.Color.DimGray, System.Drawing.Color.DimGray, System.Drawing.Color.DimGray, System.Drawing.Color.DimGray);
            ChartVisualStyle.BorderColor = borderColor1;

        
            UIChartStyleThickness thickness1 = new UIChartStyleThickness();
            thickness1.SetThickness(1, 1, 1, 1);
            ChartVisualStyle.BorderThickness = thickness1;

            DevComponents.DotNetBar.Charts.Style.Padding padding1 = new DevComponents.DotNetBar.Charts.Style.Padding();
            padding1.Bottom = 6;
            padding1.Left = 6;
            padding1.Right = 6;
            padding1.Top = 6;
            ChartVisualStyle.Padding = padding1;

            UIChartStyleBackground background5 = new UIChartStyleBackground();
            background5.Color1 = System.Drawing.Color.White;
            ContainerVisualStyles.Default.Background = background5;
         

            UIChartStyleBorderColor borderColor2 = new UIChartStyleBorderColor();
            borderColor2.SetColor(System.Drawing.Color.DimGray, System.Drawing.Color.DimGray, System.Drawing.Color.DimGray, System.Drawing.Color.DimGray);
            ContainerVisualStyles.Default.BorderColor = borderColor2;

          
            UIChartStyleThickness thickness2 = new UIChartStyleThickness();
            thickness2.SetThickness(1, 1, 1, 1);
            ContainerVisualStyles.Default.BorderThickness = thickness2;

            ContainerVisualStyles.Default.DropShadow.Enabled = DevComponents.DotNetBar.Charts.Style.Tbool.True;
                       
            UIChartStylePadding padding2 = new UIChartStylePadding();
            padding2.SetPdding(6, 6, 6, 6);
            ContainerVisualStyles.Default.Padding = padding2;

            UIChartStyleBackground background6 = new UIChartStyleBackground();
            DataLabelVisualStyle.Background = background6;

            background6.Color1 = System.Drawing.Color.Transparent;
            DataLabelVisualStyle.BorderPattern = DevComponents.DotNetBar.Charts.Style.LinePattern.None;
            DataLabelVisualStyle.ConnectorLineStyle.MinLength = 4;
            DataLabelVisualStyle.DrawConnector = DevComponents.DotNetBar.Charts.Style.Tbool.False;
            DataLabelVisualStyle.RotateDegrees = DevComponents.DotNetBar.Charts.Style.RotateDegrees.None;
            Legend.Alignment = DevComponents.DotNetBar.Charts.Style.Alignment.TopLeft;
            Legend.AlignVerticalItems = true;

            UIChartStyleBackground background7 = new UIChartStyleBackground();
            background7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            Legend.ChartLegendVisualStyles.Default.Background = background7;

        
            UIChartStyleBorderColor borderColor3 = new UIChartStyleBorderColor();
            borderColor3.SetColor(System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black);

            Legend.ChartLegendVisualStyles.Default.BorderColor = borderColor3;         

            UIChartStyleThickness thickness3 = new UIChartStyleThickness();
            thickness3.SetThickness(1, 1, 1, 1);
            Legend.ChartLegendVisualStyles.Default.BorderThickness = thickness3;
            Legend.ChartLegendVisualStyles.Default.DropShadow.Enabled = DevComponents.DotNetBar.Charts.Style.Tbool.True;

           
            UIChartStylePadding padding3 = new UIChartStylePadding();
            padding3.SetPdding(8, 8, 8, 8);
            Legend.ChartLegendVisualStyles.Default.Margin = padding3;
                       
            UIChartStylePadding padding4 = new UIChartStylePadding();
            padding3.SetPdding(4, 4, 4,4);
            Legend.ChartLegendVisualStyles.Default.Padding = padding4;

            Legend.Direction = DevComponents.DotNetBar.Charts.Direction.TopToBottom;
            Legend.MaxHorizontalPct = 75;
            Legend.Placement = DevComponents.DotNetBar.Charts.Placement.Inside;
            Legend.ShowCheckBoxes = true;
            // Name = "ChartXy1";
            PointLabelDisplayMode = DevComponents.DotNetBar.Charts.PointLabelDisplayMode.AllSeriesPoints;


          

        }

        public void AddTitle(UIChartTitle title) {
            this.Titles.Add(title);
        }

        public void SetAsixTitleText(string x, string y) {
            this.AxisX.Title.Text = x;
            this.AxisY.Title.Text = y;
        }

        public void AddChartSeries(UIChartSeries series) {
            ChartSeries.Add(series);
        }
    }
}
