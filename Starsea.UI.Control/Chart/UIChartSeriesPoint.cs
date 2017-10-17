using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
    public class UIChartSeriesPoint: SeriesPoint
    {
        public UIChartSeriesPoint() {


        }

        public UIChartSeriesPoint(Object xValue, Object[] yValue) {
            this.ValueX = xValue;
            this.ValueY = yValue;
        }
    }
}
