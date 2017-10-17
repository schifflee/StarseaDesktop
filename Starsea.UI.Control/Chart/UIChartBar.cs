using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Charts;

namespace Starsea.UIControl.Chart
{
    public partial class UIChartBar : ChartControl
    {
        public UIChartXy chartXy1;
        public UIChartBar()
        {

            chartXy1 = new UIChartXy();
           

            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));


            this.ChartPanel.ChartContainers.Add(chartXy1);
            this.ChartPanel.Legend.Visible = false;
            //this.ChartPanel.Name = "PrimaryPanel";

            UIChartStyleBackground background8 = new UIChartStyleBackground();
            UIChartStyleBackground background9 = new UIChartStyleBackground();
            UIChartStyleBackground background10 = new UIChartStyleBackground();
            UIChartStyleBackground background11 = new UIChartStyleBackground();
            UIChartStyleBackground background12 = new UIChartStyleBackground();
            UIChartStyleBackground background13 = new UIChartStyleBackground();
            UIChartStyleBackground background14 = new UIChartStyleBackground();
            UIChartStyleBackground background15 = new UIChartStyleBackground();
            background8.Color1 = System.Drawing.Color.AliceBlue;
            this.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background8;
            background9.Color1 = System.Drawing.Color.AliceBlue;
            this.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background9;
            background10.Color1 = System.Drawing.Color.White;
            this.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background10;
            background11.Color1 = System.Drawing.Color.White;
            this.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background11;
            background12.Color1 = System.Drawing.Color.AliceBlue;
            this.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background12;
            background13.Color1 = System.Drawing.Color.AliceBlue;
            this.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background13;
            background14.Color1 = System.Drawing.Color.White;
            this.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background14;
            background15.Color1 = System.Drawing.Color.White;
            this.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background15;

            this.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.Location = new System.Drawing.Point(3, 17);
            //this.Name = "chartControl1";
            this.Size = new System.Drawing.Size(790, 404);
            this.TabIndex = 0;
            this.Text = "Hello test vbar chart";
            // 
        }
        public void SetChartTitle(string title) {
            UIChartTitle charttitle = new UIChartTitle();
            charttitle.Text = title;
            chartXy1.AddTitle(charttitle);
            
        }

        public void SetAsixTitleText(string x, string y) {
            chartXy1.SetAsixTitleText(x, y);
        }

        public void AddChartSeries(UIChartSeries series) {
            chartXy1.AddChartSeries(series);
        }
    }
}
