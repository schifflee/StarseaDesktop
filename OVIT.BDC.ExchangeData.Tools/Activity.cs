
using OVIT.BDC.ExchangeData.Tools.Controls;
using Starsea.Framework.UICore;
using Starsea.UIControl;
using System;
using System.Windows.Forms;

namespace OVIT.BDC.ExchangeData.Tools
{
    public class Activity
    {

        #region 报文数据统计
        public void ShowDayUpload(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowDayUpload showday = new ucShowDayUpload();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowWeekUpload(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowWeekUpload showday = new ucShowWeekUpload();
            dh.AddPanel(docksite, itemname, showday);


        }

        public void ShowMonthUpload(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowMonthUpload showday = new ucShowMonthUpload();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowYearUpload(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowYearUpload showday = new ucShowYearUpload();
            dh.AddPanel(docksite, itemname, showday);

        }
        #endregion

        public void ShowAllBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowAllBiz showday = new ucShowAllBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        #region 报文查询
        public void ShowAllLogBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowAllLogBiz showday = new ucShowAllLogBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowWaitCreateBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowWaitCreateBiz showday = new ucShowWaitCreateBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowWaitCheckBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowShowWaitCheckBiz showday = new ucShowShowWaitCheckBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowWaitUploadBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowWaitUploadBiz showday = new ucShowWaitUploadBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowWaitResponseBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowWaitResponseBiz showday = new ucShowWaitResponseBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        #endregion

        #region 问题报文查询
        public void ShowFailureCreateBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowFailureCreateBiz showday = new ucShowFailureCreateBiz();
            dh.AddPanel(docksite, itemname, showday);

        }


        public void ShowFailureCheckBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowFailureCheckBiz showday = new ucShowFailureCheckBiz();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ShowFailureUploadBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowFailureUploadBiz showday = new ucShowFailureUploadBiz();
            dh.AddPanel(docksite, itemname, showday);

        }


        public void ShowFailureResponseBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowFailureResponseBiz showday = new ucShowFailureResponseBiz();
            dh.AddPanel(docksite, itemname, showday);

        }


        public void ShowFailureHJBiz(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucShowFailureHJBiz showday = new ucShowFailureHJBiz();
            dh.AddPanel(docksite, itemname, showday);

        }
        #endregion




        #region 报文状态重置
        public void ResetCheckFailureStatus(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucResetCheckFailureStatus showday = new ucResetCheckFailureStatus();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ResetUploadFailureStatus(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucResetUploadFailureStatus showday = new ucResetUploadFailureStatus();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ResetResponeFailureStatus(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucResetResponeFailureStatus showday = new ucResetResponeFailureStatus();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void ResetHJFailureStatus(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucResetHJFailureStatus showday = new ucResetHJFailureStatus();
            dh.AddPanel(docksite, itemname, showday);

        }

        #endregion

        #region 其他
        public void HandleOtherCFSB(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucHandleOtherCFSB showday = new ucHandleOtherCFSB();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void HandleOtherCFJSGZ(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucHandleOtherCFJSGZ showday = new ucHandleOtherCFJSGZ();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void HandleOtherSBCFJLQC(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucHandleOtherSBCFJLQC showday = new ucHandleOtherSBCFJLQC();
            dh.AddPanel(docksite, itemname, showday);

        }

        public void HandleOtherHGSBFKBWCL(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucHandleOtherHGSBFKBWCL showday = new ucHandleOtherHGSBFKBWCL();
            dh.AddPanel(docksite, itemname, showday);

        }

        #endregion

        #region 配置

        public void ConfigYwTemplate(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucConfigYwTemplate showday = new ucConfigYwTemplate();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void ConfigBizColumnCheck(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucConfigBizColumnCheck showday = new ucConfigBizColumnCheck();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void CheckBizXml(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucCheckBizXml showday = new ucCheckBizXml();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void WsCheck(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucWsCheck showday = new ucWsCheck();
            dh.AddPanel(docksite, itemname, showday);

        }

        #endregion

        #region 服务管理
        public void ManageZBExportService(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucManageZBExportService showday = new ucManageZBExportService();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void ManageBizService(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucManageBizService showday = new ucManageBizService();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void ManageAutoWSService(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucManageAutoWSService showday = new ucManageAutoWSService();
            dh.AddPanel(docksite, itemname, showday);

        }
        public void ManageConfig(UIDockSite docksite, string itemname)
        {
            DockPanelHelper dh = new DockPanelHelper();
            ucManageConfig showday = new ucManageConfig();
            dh.AddPanel(docksite, itemname, showday);

        }


        #endregion

    }
}
