using Starsea.DB;
using Starsea.Framework.Extension;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starsea.Plugin.Test2
{
    public class Test2
    {
        public void funcTest1(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                // db.Database.CreateIfNotExists();

                db.BASE_ACCOUNT.Add(new BASE_ACCOUNT()
                {
                    ACCOUNT = "star",
                    AGE = 12,
                    PASSWORD = "123456",
                    SEX = "男",
                    ID = "abc"

                });
                int ans = db.SaveChanges();
                MessageBox.Show("提交记录:" + ans);
            }
        }

        public void funcTest2(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                var query = db.BASE_ACCOUNT.Where(s => s.ACCOUNT == "star");

                foreach (var ba in query)
                {
                    var password = ba.ACCOUNT;
                    MessageBox.Show("账号密码为:" + password);
                }

                var query2 = db.BASE_ACCOUNT.ToList();

                MessageBox.Show("账号年龄为:" + query2.FirstOrDefault().AGE);
            }
        }

        public void funcTest3(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                string sql = "select * from base_account where account=@par1";
                var query = db.Database.SqlQuery<BASE_ACCOUNT>(sql, new SqlParameter("@par1", "star"));

                MessageBox.Show("账号密码:" + query.ToList().FirstOrDefault().PASSWORD);
            }
        }

        public void funcTest4(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                var query = db.BASE_ACCOUNT.ToList();
                var mo = query.First();
                mo.PERSONNAME = "test personname";

                MessageBox.Show(string.Format("历史值{0}, 当前值{1}", db.Entry(mo).Property(c => c.PERSONNAME).OriginalValue, db.Entry(mo).Property(c => c.PERSONNAME).CurrentValue));
                MessageBox.Show("reload前状态:" + db.Entry(mo).State.ToString());
                db.Entry(mo).Reload();
                MessageBox.Show("reload后状态:" + db.Entry(mo).State.ToString());

            }
        }

        public void funcTest5(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                var query = db.BASE_ACCOUNT.ToList();
                var mo = query.First();

                MessageBox.Show("修改数据库");

                MessageBox.Show(string.Format("历史值{0}, 当前值{1}", db.Entry(mo).Property(c => c.PERSONNAME).OriginalValue, db.Entry(mo).Property(c => c.PERSONNAME).CurrentValue));
                MessageBox.Show("reload前状态:" + db.Entry(mo).State.ToString());
                db.Entry(mo).Reload();
                MessageBox.Show("reload后状态:" + db.Entry(mo).State.ToString());

            }
        }

        public void funcTest6(object sender, EventArgs e)
        {
            using (Model3 db = new Model3())
            {
                var query = db.BASE_ACCOUNT.ToList();
                var mo = query.First();

                var vali= db.Entry(mo).GetValidationResult().ValidationErrors;
                
                foreach (var error in vali) {
                    MessageBox.Show("模型数据验证:" + error.ErrorMessage);
                }

                var clolVali = db.Entry(mo).Property(c => c.PERSONNAME).GetValidationErrors();
                foreach (var error1 in clolVali)
                {
                    MessageBox.Show("字段模型数据验证:" + error1.ErrorMessage);
                }
              
            }
        }

        public void funcTest7(object sender, EventArgs e) {
            int money = 123456789;
            string mstr= money.FormatForMoney();
            MessageBox.Show("扩展属性:" + mstr);
        }

        public void funcTest8(object sender, EventArgs e)
        {
            
        }

        public void funcTest9(object sender, EventArgs e)
        {

        }

        public void funcTest10(object sender, EventArgs e)
        {

        }

        public void funcTest11(object sender, EventArgs e)
        {

        }

        public void funcTest12(object sender, EventArgs e)
        {

        }
    }
}
