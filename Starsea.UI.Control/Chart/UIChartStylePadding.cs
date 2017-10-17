using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.UIControl.Chart
{
    public class UIChartStylePadding : DevComponents.DotNetBar.Charts.Style.Padding
    {
        public UIChartStylePadding()
        {

        }

        public void SetPdding(int Top, int Bottom, int Left, int Right)
        {
            this.Top = Top;
            this.Bottom = Bottom;
            this.Left = Left;
            this.Right = Right;
        }
    }
}
