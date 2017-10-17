using DevComponents.DotNetBar.Charts.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
   public class UIChartStyleThickness:Thickness
    {
        public UIChartStyleThickness() {

        }

        public void SetThickness(int Top,int Bottom,int Left,int Right) {
            this.Top = Top;
            this.Bottom = Bottom;
            this.Left = Left;
            this.Right = Right;
        }
    }
}
