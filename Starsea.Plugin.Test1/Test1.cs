using System;
using System.Windows.Forms;

namespace Starsea.Plugin.Test1
{
    public class Test1
    {
        public void funcTest1(object sender, EventArgs e)
        {
            MessageBox.Show("test1");

            //using (QuickDevEntities context = new QuickDevEntities()) {
            //    var query = from account in context.BASE_ACCOUNT
            //                select new
            //                {
            //                    a = account.ACCOUNT,
            //                    b = account.PASSWORD


            //                };
            //    foreach (var item in query) {
            //        string msg = string.Format("account:{0},password:{1}", item.a,item.b);
            //        MessageBox.Show(msg);
            //    }

        //}

        }

        public void funcTest2(object sender, EventArgs e)
        {
            MessageBox.Show("test2");
        }

        public void funcTest3(object sender, EventArgs e)
        {
            MessageBox.Show("test3");
        }

        public void funcTest4(object sender, EventArgs e)
        {
            MessageBox.Show("test4");
        }
    }
}
