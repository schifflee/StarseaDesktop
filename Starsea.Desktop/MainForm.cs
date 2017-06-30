using DevComponents.DotNetBar;
using Starsea.Framework.Config;
using Starsea.Framework.Model.System;
using Starsea.Framework.Model.XML;
using Starsea.Helper;
using Starsea.UIControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starsea.Desktop
{
    public partial class MainForm : UIRibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            //加载系统菜单
            AddRibbonFromConfig();
            //加载系统面板
            AddBarManagerFromConfig();
            rc.SendToBack();
            //扫描插件文件夹
            ScannPlugins();
            //添加插件 菜单设置  对应事件
            SetPluginMenu();

            //初始化插件库


        }

        private void SetPluginMenu()
        {
            if (pluginInfoList != null && pluginInfoList.Count > 0)
            {
                foreach (PluginInfo pluginInfo in pluginInfoList)
                {
                    AddRibbonTab(pluginInfo.plugin.UI.Ribbon, "Plugin", pluginInfo.path);
                }

            }
        }

        private void ScannPlugins()
        {
            pluginInfoList = new List<PluginInfo>();
            string[] dirs = Directory.GetDirectories(PathConfig.PluginFolderPath);
            if (dirs != null && dirs.Length > 0)
            {
                foreach (string pluginFolder in dirs)
                {
                    string pluginXMLpath = pluginFolder + "\\Plugin.xml";
                    Plugin plugin = XmlClassHelper.LoadXML2Class<Plugin>(pluginXMLpath);
                    PluginInfo pluginfo = new PluginInfo();
                    pluginfo.path = pluginFolder;
                    pluginfo.plugin = plugin;
                    pluginInfoList.Add(pluginfo);
                }
            }

        }

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        UIRibbonControl rc;
        UIBarManager bm;
        List<PluginInfo> pluginInfoList;

        public delegate void buttonClick(object sender, EventArgs e);


        private void AddRibbonTab(Ribbon ribbon, string type, string pluginFloderPath)
        {
            string basePath = PathConfig.ImageFolderPath;
            if (type == "Plugin")
            {
                basePath = pluginFloderPath + "\\Resource\\Images\\";
            }

            //菜单选项卡
            List<RibbonTab> tablist = ribbon.TabList;
            if (tablist != null && tablist.Count > 0)
            {
                foreach (RibbonTab tab in tablist)
                {
                    UIRibbonTabItem tabitem1 = new UIRibbonTabItem();
                    tabitem1.Text = tab.TEXT;
                    rc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { tabitem1 });

                    //选项卡面板 
                    UIRibbonPanel rpanel1 = new UIRibbonPanel();
                    rpanel1.RibbonTabItem = tabitem1;
                    tabitem1.Panel = rpanel1;
                    rc.Controls.Add(rpanel1);

                    //面板按钮条
                    List<Framework.Model.XML.RibbonBar> barlist = tab.BarList;
                    if (barlist != null && barlist.Count > 0)
                    {
                        foreach (Framework.Model.XML.RibbonBar bar1 in barlist)
                        {
                            UIRibbonBar rBar1 = new UIRibbonBar();
                            rBar1.Text = bar1.TEXT;
                            rpanel1.Controls.Add(rBar1);

                            List<RibbonItem> itemlist = bar1.ItemList;
                            if (itemlist != null && itemlist.Count > 0)
                            {
                                foreach (RibbonItem item in itemlist)
                                {
                                    //按钮
                                    UIButtonItem buttonItem1 = new UIButtonItem();
                                    buttonItem1.Text = item.TEXT;
                                    buttonItem1.Image = System.Drawing.Image.FromFile(basePath + item.IMAGE);
                                    if (item.DLL != null && item.DLL != "")
                                    {
                                        Assembly assembly = ReflectionHelper.getAssembly(pluginFloderPath + "\\" + item.DLL);
                                        object obj = ReflectionHelper.CreateInstance(assembly, item.CLASS);
                                        BindingFlags myBindingFlags = BindingFlags.Public | BindingFlags.Instance;
                                        MethodInfo methodinfo = ReflectionHelper.GetMethod(obj, item.FUNC, myBindingFlags);

                                        //EventHandler _Click = (EventHandler)Delegate.CreateDelegate(typeof(EventHandler), methodinfo); 
                                        //buttonItem1.Click +=_Click;

                                        buttonItem1.Click += delegate (object sender, EventArgs e)
                                        {
                                            methodinfo.Invoke(obj, new object[] { null,null});
                                        };
                                    }
                                    rBar1.Items.AddRange(new BaseItem[] { buttonItem1 });

                                }
                            }

                        }
                    }

                }
            }
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {

        }

        private void AddRibbonFromConfig()
        {
            Ribbon ribbon = XmlClassHelper.LoadXML2Class<Ribbon>(PathConfig.RibbonConfigPath);

            rc = new UIRibbonControl();
            //rc.Dock = DockStyle.Top;
            this.Controls.Add(rc);

            //程序设置按钮
            UIApplicationButton ab = new UIApplicationButton();
            rc.Items.AddRange(new BaseItem[] { ab });

            //快速工具条 按钮
            UIButtonItem qbuttonitem1 = new UIButtonItem();
            qbuttonitem1.Image = null;
            UIButtonItem qbuttonitem2 = new UIButtonItem();
            UIButtonItem qbuttonitem3 = new UIButtonItem();
            rc.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { qbuttonitem1, qbuttonitem2, qbuttonitem3 });

            AddRibbonTab(ribbon, "", "");
            ////菜单选项卡
            //List<RibbonTab> tablist = ribbon.TabList;
            //if (tablist != null && tablist.Count > 0) {
            //    foreach (RibbonTab tab in tablist) {
            //        UIRibbonTabItem tabitem1 = new UIRibbonTabItem();
            //        tabitem1.Text = tab.TEXT;
            //        rc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { tabitem1 });

            //        //选项卡面板 
            //        UIRibbonPanel rpanel1 = new UIRibbonPanel();
            //        rpanel1.RibbonTabItem = tabitem1;
            //        tabitem1.Panel = rpanel1;
            //        rc.Controls.Add(rpanel1);

            //        //面板按钮条
            //        List<Framework.Model.XML.RibbonBar> barlist = tab.BarList;
            //        if (barlist != null && barlist.Count > 0) {
            //            foreach (Framework.Model.XML.RibbonBar bar1 in barlist) {
            //                UIRibbonBar rBar1 = new UIRibbonBar();
            //                rBar1.Text = bar1.TEXT;
            //                rpanel1.Controls.Add(rBar1);

            //                List<RibbonItem> itemlist = bar1.ItemList;
            //                if (itemlist != null && itemlist.Count > 0) {
            //                    foreach (RibbonItem item in itemlist) {
            //                        //按钮
            //                        UIButtonItem buttonItem1 = new UIButtonItem();
            //                        buttonItem1.Text = item.TEXT;
            //                        buttonItem1.Image = System.Drawing.Image.FromFile(PathConfig.ImageFolderPath + item.IMAGE);
            //                        buttonItem1.Click += new EventHandler(addDockToolItem_Click);
            //                        rBar1.Items.AddRange(new BaseItem[] { buttonItem1 });

            //                    }
            //                }

            //            }
            //        }

            //    }
            //}
            rc.SelectFirstVisibleRibbonTab();
        }


        private void AddBarManagerFromConfig()
        {
            DockWindow dockwindow = XmlClassHelper.LoadXML2Class<DockWindow>(PathConfig.DockWindowConfigPath);
            bm = new UIBarManager(this.components);
            bm.ParentForm = this;
            List<Framework.Model.XML.DockSite> docksitelist = dockwindow.DockSiteList;
            if (docksitelist != null && docksitelist.Count > 0)
            {
                foreach (Framework.Model.XML.DockSite docksite in docksitelist)
                {
                    UIDockSite uidocksite = new UIDockSite();
                    if (docksite.site == "Left")
                    {

                        uidocksite.Dock = DockStyle.Left;
                        bm.LeftDockSite = uidocksite;
                    }
                    if (docksite.site == "Right")
                    {

                        uidocksite.Dock = DockStyle.Right;
                        bm.RightDockSite = uidocksite;
                    }
                    if (docksite.site == "Fill")
                    {

                        uidocksite.Dock = DockStyle.Fill;
                        bm.FillDockSite = uidocksite;
                    }
                    if (docksite.site == "Top")
                    {

                        uidocksite.Dock = DockStyle.Top;
                        bm.TopDockSite = uidocksite;
                    }
                    if (docksite.site == "Bottom")
                    {

                        uidocksite.Dock = DockStyle.Bottom;
                        bm.BottomDockSite = uidocksite;
                    }
                    this.Controls.Add(uidocksite);

                    UIBar uibar = new UIBar();
                    uibar.Name = "DockBar";
                    uibar.Text = "窗体";
                    uibar.CloseSingleTab = docksite.Bar.CloseSingleTab;
                    if (docksite.Bar.GrabHandleStyle == "Caption")
                    {
                        uibar.GrabHandleStyle = eGrabHandleStyle.Caption;
                    }
                    uibar.AutoSyncBarCaption = docksite.Bar.AutoSyncBarCaption;
                    uibar.AlwaysDisplayDockTab = docksite.Bar.AlwaysDisplayDockTab;
                    uibar.CanCustomize = docksite.Bar.CanCustomize;
                    uibar.CanDockBottom = docksite.Bar.CanDockBottom;
                    uibar.CanDockDocument = docksite.Bar.CanDockDocument;
                    uibar.CanDockLeft = docksite.Bar.CanDockLeft;
                    uibar.CanDockRight = docksite.Bar.CanDockRight;
                    uibar.CanDockTop = docksite.Bar.CanDockTop;
                    uibar.CanUndock = docksite.Bar.CanUndock;
                    uibar.CanHide = docksite.Bar.CanHide;
                    uibar.Visible = docksite.Bar.Visible;
                    if (docksite.Bar.DockTabAlignment == "Left")
                    {
                        uibar.DockTabAlignment = eTabStripAlignment.Left;
                    }
                    if (docksite.Bar.DockTabAlignment == "Right")
                    {
                        uibar.DockTabAlignment = eTabStripAlignment.Right;
                    }
                    if (docksite.Bar.DockTabAlignment == "Top")
                    {
                        uibar.DockTabAlignment = eTabStripAlignment.Top;
                    }
                    if (docksite.Bar.DockTabAlignment == "Bottom")
                    {
                        uibar.DockTabAlignment = eTabStripAlignment.Bottom;
                    }

                    //选择tab
                    uibar.SelectedDockTab = docksite.Bar.SelectedDockTab;

                    uidocksite.Controls.Add(uibar);

                    uidocksite.DocumentDockContainer = new DocumentDockContainer(
                        new DocumentBaseContainer[] {
                                 (DocumentBaseContainer)(new DocumentBarContainer(uibar,300,400))
                                 }, eOrientation.Horizontal
                             );
                    uidocksite.Location = new System.Drawing.Point(0, 161);
                    uidocksite.Size = new System.Drawing.Size(docksite.Width, docksite.Height);



                }
            }
            //工具条
            List<Framework.Model.XML.DockSiteToolBar> docksitetoolbarlist = dockwindow.DockSiteToolBarList;
            if (docksitetoolbarlist != null && docksitetoolbarlist.Count > 0)
            {
                foreach (Framework.Model.XML.DockSiteToolBar docksitetoolbar in docksitetoolbarlist)
                {
                    UIDockSite uidocksite = new UIDockSite();
                    this.Controls.Add(uidocksite);
                    UIBar toolbar = new UIBar();
                    toolbar.LayoutType = eLayoutType.Toolbar;
                    toolbar.Name = "ToolBar";
                    toolbar.Dock = DockStyle.Bottom;
                    uidocksite.Controls.Add(toolbar);

                    toolbar.Visible = docksitetoolbar.Bar.Visible;
                    if (docksitetoolbar.site == "Left")
                    {

                        uidocksite.Dock = DockStyle.Left;
                        bm.ToolbarLeftDockSite = uidocksite;
                        toolbar.DockOrientation = eOrientation.Vertical;
                    }
                    if (docksitetoolbar.site == "Right")
                    {

                        uidocksite.Dock = DockStyle.Right;
                        bm.ToolbarRightDockSite = uidocksite;
                        toolbar.DockOrientation = eOrientation.Vertical;
                    }
                    if (docksitetoolbar.site == "Top")
                    {

                        uidocksite.Dock = DockStyle.Top;
                        bm.ToolbarTopDockSite = uidocksite;
                    }
                    if (docksitetoolbar.site == "Bottom")
                    {

                        uidocksite.Dock = DockStyle.Bottom;
                        bm.ToolbarBottomDockSite = uidocksite;
                    }


                }
            }
        }

        private void AddBarManager()
        {
            ///--------工作区布局
            UIBarManager bm = new UIBarManager(this.components);
            bm.ParentForm = this;
            // this.Controls.Add(bm);
            // bm.MdiSystemItemVisible = true;

            UIDockSite docksite_top = new UIDockSite();
            docksite_top.Dock = DockStyle.Top;
            UIDockSite docksite_doc = new UIDockSite();
            docksite_doc.Dock = DockStyle.Fill;

            UIDockSite docksite_left = new UIDockSite();
            docksite_left.Dock = DockStyle.Left;
            UIDockSite docksite_right = new UIDockSite();
            docksite_right.Dock = DockStyle.Right;
            UIDockSite docksite_bottom = new UIDockSite();
            docksite_bottom.Dock = DockStyle.Bottom;


            UIDockSite docksite_tool_top = new UIDockSite();
            docksite_tool_top.Dock = DockStyle.Fill;
            UIDockSite docksite_tool_left = new UIDockSite();
            docksite_tool_left.Dock = DockStyle.Left;
            UIDockSite docksite_tool_bottom = new UIDockSite();
            docksite_tool_bottom.Dock = DockStyle.Bottom;
            UIDockSite docksite_tool_right = new UIDockSite();
            docksite_tool_right.Dock = DockStyle.Right;

            this.Controls.Add(docksite_top);
            this.Controls.Add(docksite_doc);
            this.Controls.Add(docksite_left);
            this.Controls.Add(docksite_right);
            this.Controls.Add(docksite_bottom);

            this.Controls.Add(docksite_tool_top);
            this.Controls.Add(docksite_tool_left);
            this.Controls.Add(docksite_tool_bottom);
            this.Controls.Add(docksite_tool_right);


            bm.FillDockSite = docksite_doc;
            bm.TopDockSite = docksite_top;
            bm.LeftDockSite = docksite_left;
            bm.RightDockSite = docksite_right;
            bm.BottomDockSite = docksite_bottom;

            bm.ToolbarBottomDockSite = docksite_tool_bottom;
            bm.ToolbarLeftDockSite = docksite_tool_left;
            bm.ToolbarRightDockSite = docksite_tool_right;
            bm.ToolbarTopDockSite = docksite_tool_top;




            //左侧工作区
            UIBar dockbar_left = new UIBar();
            // dockbar_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dockbar_left.Text = "左侧工作区";
            docksite_left.Controls.Add(dockbar_left);
            //设置大小
            docksite_left.DocumentDockContainer = new DocumentDockContainer(
               new DocumentBaseContainer[] {
                    (DocumentBaseContainer)(new DocumentBarContainer(dockbar_left,300,400))
               }, eOrientation.Horizontal
               );
            docksite_left.Location = new System.Drawing.Point(0, 161);
            docksite_left.Size = new System.Drawing.Size(300, 400);

            UIPanelDockContainer pdc_left = new UIPanelDockContainer();
            UIPanelDockContainer pdc_left1 = new UIPanelDockContainer();
            UIPanelDockContainer pdc_left2 = new UIPanelDockContainer();
            dockbar_left.Controls.Add(pdc_left);
            dockbar_left.Controls.Add(pdc_left1);
            dockbar_left.Controls.Add(pdc_left2);
            UIDockContainerItem dci_left = new UIDockContainerItem();
            dci_left.Control = pdc_left;
            dci_left.Text = "dock left";
            UIDockContainerItem dci_left1 = new UIDockContainerItem();
            dci_left1.Control = pdc_left1;
            dci_left1.Text = "dock left1";
            UIDockContainerItem dci_left2 = new UIDockContainerItem();
            dci_left2.Control = pdc_left2;
            dci_left2.Text = "dock left2";
            dockbar_left.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci_left, dci_left1, dci_left2 });
            //选择tab       

            dockbar_left.SelectedDockTab = 0;


            MonthCalendar mc = new MonthCalendar();
            mc.AutoSize = true;
            mc.Location = new System.Drawing.Point(0, 0);
            mc.Size = new System.Drawing.Size(190, 200);
            pdc_left.Controls.Add(mc);




            //右侧工作区
            UIBar dockbar_right = new UIBar();
            dockbar_right.Text = "右侧工作区";
            docksite_right.Controls.Add(dockbar_right);
            //设置大小
            docksite_right.DocumentDockContainer = new DocumentDockContainer(
               new DocumentBaseContainer[] {
                    (DocumentBaseContainer)(new DocumentBarContainer(dockbar_right,300,400))
               }, eOrientation.Horizontal
               );
            docksite_right.Location = new System.Drawing.Point(0, 161);
            docksite_right.Size = new System.Drawing.Size(300, 400);

            UIPanelDockContainer pdc_right = new UIPanelDockContainer();
            UIPanelDockContainer pdc_right1 = new UIPanelDockContainer();
            UIPanelDockContainer pdc_right2 = new UIPanelDockContainer();
            dockbar_right.Controls.Add(pdc_right);
            dockbar_right.Controls.Add(pdc_right1);
            dockbar_right.Controls.Add(pdc_right2);
            UIDockContainerItem dci_right = new UIDockContainerItem();
            dci_right.Control = pdc_right;
            dci_right.Text = "dock right";
            UIDockContainerItem dci_right1 = new UIDockContainerItem();
            dci_right1.Control = pdc_right1;
            dci_right1.Text = "dock right1";
            UIDockContainerItem dci_right2 = new UIDockContainerItem();
            dci_right2.Control = pdc_right2;
            dci_right2.Text = "dock right2";
            dockbar_right.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci_right, dci_right1, dci_right2 });
            //选择tab       

            dockbar_right.SelectedDockTab = 1;



            //文档工作区
            UIBar dockbar_doc = new UIBar();
            dockbar_doc.Text = "右侧工作区";
            dockbar_doc.DockTabAlignment = eTabStripAlignment.Bottom;
            docksite_doc.Controls.Add(dockbar_doc);
            //设置大小
            docksite_doc.DocumentDockContainer = new DocumentDockContainer(
               new DocumentBaseContainer[] {
                    (DocumentBaseContainer)(new DocumentBarContainer(dockbar_doc,766,480))
               }, eOrientation.Horizontal
               );
            docksite_doc.Location = new System.Drawing.Point(0, 161);
            docksite_doc.Size = new System.Drawing.Size(766, 480);

            UIPanelDockContainer pdc_doc = new UIPanelDockContainer();
            UIPanelDockContainer pdc_doc1 = new UIPanelDockContainer();
            UIPanelDockContainer pdc_doc2 = new UIPanelDockContainer();
            dockbar_doc.Controls.Add(pdc_doc);
            dockbar_doc.Controls.Add(pdc_doc1);
            dockbar_doc.Controls.Add(pdc_doc2);
            UIDockContainerItem dci_doc = new UIDockContainerItem();
            dci_doc.Control = pdc_doc;
            dci_doc.Text = "dock doc";
            UIDockContainerItem dci_doc1 = new UIDockContainerItem();
            dci_doc1.Control = pdc_doc1;
            dci_doc1.Text = "dock doc1";
            UIDockContainerItem dci_doc2 = new UIDockContainerItem();
            dci_doc2.Control = pdc_doc2;
            dci_doc2.Text = "dock doc2";
            dockbar_doc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci_doc, dci_doc1, dci_doc2 });
            //选择tab       

            dockbar_doc.SelectedDockTab = 1;


            //底部工作区
            UIBar dockbar_bottom = new UIBar();
            dockbar_bottom.Text = "底部工作区";
            docksite_bottom.Controls.Add(dockbar_bottom);
            //设置大小
            docksite_bottom.DocumentDockContainer = new DocumentDockContainer(
               new DocumentBaseContainer[] {
                    (DocumentBaseContainer)(new DocumentBarContainer(dockbar_bottom,1366,160))
               }, eOrientation.Horizontal
               );
            // docksite_bottom.Location = new System.Drawing.Point(0, 640);
            docksite_bottom.Size = new System.Drawing.Size(1366, 160);

            UIPanelDockContainer pdc_bottom = new UIPanelDockContainer();
            UIPanelDockContainer pdc_bottom1 = new UIPanelDockContainer();
            UIPanelDockContainer pdc_bottom2 = new UIPanelDockContainer();
            dockbar_bottom.Controls.Add(pdc_bottom);
            dockbar_bottom.Controls.Add(pdc_bottom1);
            dockbar_bottom.Controls.Add(pdc_bottom2);
            UIDockContainerItem dci_bottom = new UIDockContainerItem();
            dci_bottom.Control = pdc_bottom;
            dci_bottom.Text = "dock bottom";
            UIDockContainerItem dci_bottom1 = new UIDockContainerItem();
            dci_bottom1.Control = pdc_bottom1;
            dci_bottom1.Text = "dock bottom1";
            UIDockContainerItem dci_bottom2 = new UIDockContainerItem();
            dci_bottom2.Control = pdc_bottom2;
            dci_bottom2.Text = "dock bottom2";
            dockbar_bottom.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci_bottom, dci_bottom1, dci_bottom2 });
            //选择tab       

            dockbar_bottom.SelectedDockTab = 1;


            //底部工具条
            UIBar dockbar_toolbottom = new UIBar();
            dockbar_toolbottom.LayoutType = eLayoutType.Toolbar;
            docksite_tool_bottom.Controls.Add(dockbar_toolbottom);
            UIButtonItem bi1 = new UIButtonItem();
            bi1.Text = "";
            UIButtonItem bi2 = new UIButtonItem();
            bi2.Text = "";
            UIButtonItem bi3 = new UIButtonItem();
            bi3.Text = "";

            dockbar_toolbottom.Items.AddRange(new BaseItem[] { bi1, bi2, bi3 });

        }

        private void loadDock_Click(object sender, EventArgs e)
        {
            UIBar uibar = bm.RightDockSite.Controls.Find("DockBar", true)[0] as UIBar;

            UIDockContainerItem dci = new UIDockContainerItem();
            uibar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { dci });
            UIPanelDockContainer pdc = new UIPanelDockContainer();
            uibar.Controls.Add(pdc);

            dci.Control = pdc;
            dci.Text = "选项卡111 ";
        }

        private void showDock_Click(object sender, EventArgs e)
        {
            UIBar uibar = bm.RightDockSite.Controls.Find("DockBar", true)[0] as UIBar;
            // UIBar uibar = bm.ToolbarLeftDockSite.Controls.Find("ToolBar", true)[0] as UIBar;

            if (uibar.Visible)
            {
                uibar.Visible = false;
            }
            else
            {
                uibar.Visible = true;
            }
        }



        private void addDockToolItem_Click(object sender, EventArgs e)
        {
            UIBar uibar = bm.ToolbarBottomDockSite.Controls.Find("ToolBar", true)[0] as UIBar;

            UIButtonItem button1 = new UIButtonItem();
            button1.Text = "helloToolBar";
            button1.Click += new EventHandler(loadDock_Click);

            uibar.Items.AddRange(new BaseItem[] { button1 });
        }


    }
}
