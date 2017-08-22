using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OVIT.BDC.MiddleLabrary.Data.DB;
using DevComponents.AdvTree;

namespace OVIT.BDC.MiddleLabrary.Controls
{
    public partial class FCList : UserControl
    {
        public FCList()
        {
            InitializeComponent();

            loadAllFC();
        }

        private void loadAllFC()
        {
            using (ZjkContext zjk=new ZjkContext()) {
                var query = from zrz in zjk.ZRZ
                            where zrz.ZBM != null
                            select new
                            {
                                ZBM = zrz.ZBM
                            };

                foreach (var item in query) {
                    this.advTree1.Nodes.Add(new Node( item.ZBM));

                }
            }
        }
    }
}
