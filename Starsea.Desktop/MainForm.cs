using DevComponents.DotNetBar;
using Starsea.Framework.Config;
using Starsea.Framework.Enum;
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

        UIRibbonControl rc;
        UIBarManager bm;
        List<PluginInfo> pluginInfoList;

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
            //加载插件组件
            SetPluginComponent();
        }

        private void SetPluginComponent()
        {
            if (pluginInfoList != null && pluginInfoList.Count > 0)
            {
                foreach (PluginInfo pluginfo in pluginInfoList)
                {
                    List<Framework.Model.XML.Component> comlist = new List<Framework.Model.XML.Component>();
                    comlist = pluginfo.plugin.Components.ComponentList;
                    if (comlist != null && comlist.Count > 0)
                    {
                        foreach (Framework.Model.XML.Component item in comlist)
                            if (item.Dll != null && item.Dll != "")
                            {
                                Assembly assembly = ReflectionHelper.getAssembly(pluginfo.path + "\\" + item.Dll);
                                object obj = ReflectionHelper.CreateInstance(assembly, item.Class);
                                BindingFlags myBindingFlags = BindingFlags.Public | BindingFlags.Instance;
                                MethodInfo methodinfo = ReflectionHelper.GetMethod(obj, item.Func, myBindingFlags);
                                if (item.Site == "left")
                                {
                                    methodinfo.Invoke(obj, new object[] { bm.LeftDockSite, item.Text });
                                }
                                else if (item.Site == "fill")
                                {
                                    methodinfo.Invoke(obj, new object[] { bm.FillDockSite, item.Text });
                                }
                                else if (item.Site == "right")
                                {
                                    methodinfo.Invoke(obj, new object[] { bm.RightDockSite, item.Text });
                                }
                                else if (item.Site == "bottom")
                                {
                                    methodinfo.Invoke(obj, new object[] { bm.BottomDockSite, item.Text });
                                }

                            }
                    }
                }
            }
        }

        private void SetPluginMenu()
        {
            if (pluginInfoList != null && pluginInfoList.Count > 0)
            {
                foreach (PluginInfo pluginInfo in pluginInfoList)
                {
                    AddRibbonTab(pluginInfo.plugin.UI.Ribbon, "Plugin", pluginInfo.path);
                }

                rc.SelectFirstVisibleRibbonTab();

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
                    if (!System.IO.File.Exists(pluginXMLpath))
                    {
                        continue;
                    }
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
                                        if (item.FUNC != "")
                                        {
                                            MethodInfo methodinfo = ReflectionHelper.GetMethod(obj, item.FUNC, myBindingFlags);

                                            //EventHandler _Click = (EventHandler)Delegate.CreateDelegate(typeof(EventHandler), methodinfo); 
                                            //buttonItem1.Click +=_Click;

                                            buttonItem1.Click += delegate (object sender, EventArgs e)
                                            {
                                                if (item.WINDOWTYPE == RibbonItemWindowType.FillDock)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { bm.FillDockSite, item.TEXT });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.LeftDock)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { bm.LeftDockSite, item.TEXT });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.RightDock)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { bm.RightDockSite, item.TEXT });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.TopDock)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { bm.TopDockSite, item.TEXT });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.BottomDock)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { bm.BottomDockSite, item.TEXT });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.Alert)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.Message)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { });
                                                }
                                                else if (item.WINDOWTYPE == RibbonItemWindowType.Confim)
                                                {
                                                    methodinfo.Invoke(obj, new object[] { });
                                                }

                                            };
                                        }
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
            if (ribbon.ApplicationButton != null && ribbon.ApplicationButton.VISIBLE)
            {
                UIApplicationButton ab = new UIApplicationButton();
                ab.Text = ribbon.ApplicationButton.TEXT;
                rc.Items.AddRange(new BaseItem[] { ab });
            }

            //快速工具条 按钮           
            if (ribbon.QuickToolBar != null && ribbon.QuickToolBar.ItemList.Count > 0)
            {
                foreach (RibbonItem item in ribbon.QuickToolBar.ItemList)
                {
                    UIButtonItem quicktoolbutton = new UIButtonItem();
                    quicktoolbutton.Image = null;
                    quicktoolbutton.Tooltip = item.TEXT;
                    rc.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { quicktoolbutton });
                }

            }

            AddRibbonTab(ribbon, "", "");

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
                    uibar.Stretch = true;
                    uibar.TabNavigation = true;
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
                                 (DocumentBaseContainer)(new DocumentBarContainer(uibar,docksite.X,docksite.Y))
                                 }, eOrientation.Horizontal
                             );
                    // uidocksite.Location = new System.Drawing.Point(0, 161);
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
                        // toolbar.DockOrientation = eOrientation.Vertical;
                    }
                    if (docksitetoolbar.site == "Right")
                    {

                        uidocksite.Dock = DockStyle.Right;
                        bm.ToolbarRightDockSite = uidocksite;
                        // toolbar.DockOrientation = eOrientation.Vertical;
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

    }
}
