using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
   public class UIChartTitle:ChartTitle
    {
        public UIChartTitle() {
            ChartTitleVisualStyle.Alignment = DevComponents.DotNetBar.Charts.Style.Alignment.MiddleCenter;
            ChartTitleVisualStyle.Font = new System.Drawing.Font("Georgia", 16F);

            DevComponents.DotNetBar.Charts.Style.Padding padding5 = new DevComponents.DotNetBar.Charts.Style.Padding();
            padding5.Bottom = 8;
            padding5.Left = 8;
            padding5.Right = 8;
            padding5.Top = 8;

            ChartTitleVisualStyle.Padding = padding5;
            ChartTitleVisualStyle.TextColor = System.Drawing.Color.Navy;
            //Name = "Title1";
            Text = "每日上报情况";
            XyAlignment = DevComponents.DotNetBar.Charts.XyAlignment.Top;

        }
    }
}
