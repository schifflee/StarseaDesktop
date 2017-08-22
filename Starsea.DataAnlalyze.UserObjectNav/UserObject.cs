using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starsea.DataAnalyze.DB;

namespace Starsea.DataAnlalyze.UserObjectNav
{
    public partial class UserObject : UserControl
    {
        public UserObject()
        {
            InitializeComponent();

            loadTree();
        }

        private void loadUserObject(string username) {
            using (DataAnalyzeContext context = new DataAnalyzeContext())
            {
                var query = from table in context.DA_DBA_TABLES
                            where table.OWNER == username.ToUpper()
                            orderby table.TABLE_NAME
                            select new
                            {
                                OWNER = table.OWNER,
                                TABLE_NAME = table.TABLE_NAME,

                            };

                this.advTree1.Nodes.Clear();
                foreach (var table in query)
                {
                    this.advTree1.Nodes.Add(new DevComponents.AdvTree.Node("(" + table.OWNER + ")"+table.TABLE_NAME));
                }
            }
        }

        private void loadTree()
        {
            using (DataAnalyzeContext context = new DataAnalyzeContext())
            {
                var queryuser = from user in context.DA_DBA_USERS
                                orderby user.USERNAME
                                select new
                                {
                                    USERNAME = user.USERNAME
                                };

                foreach (var user in queryuser) {
                    
                    this.comboBoxEx1.Items.Add(user.USERNAME);

                }
                this.comboBoxEx1.SelectedIndex = 0;

                loadUserObject("egov_ym");

               // loadUserObject(this.comboBoxEx1.SelectedItem.ToString());

            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUserObject(this.comboBoxEx1.SelectedItem.ToString());
        }
    }
}
