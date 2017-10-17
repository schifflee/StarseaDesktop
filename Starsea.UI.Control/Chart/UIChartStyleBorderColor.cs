using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
   public class UIChartStyleBorderColor: DevComponents.DotNetBar.Charts.Style.BorderColor
    {
        public UIChartStyleBorderColor() {

        }

        public void SetColor(Color Top, Color Bottom, Color Left, Color Right) {
            this.Top = Top;
            this.Bottom = Bottom;
            this.Left = Left;
            this.Right = Right;

        }
    }
}
