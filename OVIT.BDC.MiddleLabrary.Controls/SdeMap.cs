using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesGDB;

namespace OVIT.BDC.MiddleLabrary.Controls
{
    public partial class SdeMap : UserControl
    {
        public SdeMap()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Engine);
            InitializeComponent();

            //  LoadMap();
           // LoadMxdMap();
        }

        private void LoadMxdMap()
        {
            string pFileName = @"F:\NEW_PLATFORM\代码\不动产房产中间库数据关联\Desktop\Plugins\MiddleLibrary\Resource\Files\Mxd\不动产.mxd";
            if (axMapControl1.CheckMxFile(pFileName)) //检查地图文档有效性
            {
                //将数据载入pMapDocument并与Map控件关联
                IMapDocument pMapDocument = new MapDocument();//using ESRI.ArcGIS.Carto;
                pMapDocument.Open(pFileName, "");
                //获取Map中激活的地图文档
                axMapControl1.Map = pMapDocument.ActiveView.FocusMap;
                axMapControl1.ActiveView.Refresh();
            }
            else
            {
                MessageBox.Show(pFileName + "是无效的地图文档!", "信息提示");
                return;
            }
        }

        private void LoadMap()
        {
            IWorkspace pWorkspace;
            pWorkspace = arcSDEWorkspaceOpen("192.168.7.147", "sde:oracle11g:jsbdcdj", "sde", "sa", "", "SDE.DEFAULT");

            //如果工作空间不为空则进行加载
            if (pWorkspace != null)
            {
                AddAllDataset(pWorkspace, this.axMapControl1);
            }
        }

        private void AddAllDataset(IWorkspace pWorkspace, AxMapControl mapControl)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();
            //判断数据集是否有数据
            while (pDataset != null)
            {
                if (pDataset is IFeatureDataset)  //要素数据集
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(pDataset.Name);
                    IEnumDataset pEnumDataset1 = pFeatureDataset.Subsets;
                    pEnumDataset1.Reset();
                    IGroupLayer pGroupLayer = new GroupLayerClass();
                    pGroupLayer.Name = pFeatureDataset.Name;
                    IDataset pDataset1 = pEnumDataset1.Next();
                    while (pDataset1 != null)
                    {
                        if (pDataset1 is IFeatureClass)  //要素类
                        {
                            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                            pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset1.Name);
                            if (pFeatureLayer.FeatureClass != null)
                            {
                                pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                                pGroupLayer.Add(pFeatureLayer);
                                mapControl.Map.AddLayer(pFeatureLayer);
                            }
                        }
                        pDataset1 = pEnumDataset1.Next();
                    }
                }
                else if (pDataset is IFeatureClass) //要素类
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);

                    pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                    mapControl.Map.AddLayer(pFeatureLayer);
                }
                //else if (pDataset is IRasterDataset) //栅格数据集
                //{
                //    IRasterWorkspaceEx pRasterWorkspace = (IRasterWorkspaceEx)pWorkspace;
                //    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pDataset.Name);
                //    //影像金字塔判断与创建
                //    IRasterPyramid3 pRasPyrmid;
                //    pRasPyrmid = pRasterDataset as IRasterPyramid3;
                //    if (pRasPyrmid != null)
                //    {
                //        if (!(pRasPyrmid.Present))
                //        {
                //            pRasPyrmid.Create(); //创建金字塔
                //        }
                //    }
                //    IRasterLayer pRasterLayer = new RasterLayerClass();
                //    pRasterLayer.CreateFromDataset(pRasterDataset);
                //    ILayer pLayer = pRasterLayer as ILayer;
                //    mapControl.AddLayer(pLayer, 0);
                //}
                pDataset = pEnumDataset.Next();
            }

            mapControl.ActiveView.Refresh();
            //同步鹰眼
           // SynchronizeEagleEye();
        }

        private IWorkspace arcSDEWorkspaceOpen(string server, string instance, string user, string password, string database, string version)
        {
            IWorkspace pWorkSpace = null;
            //创建和实例化数据集
            IPropertySet pPropertySet = new PropertySetClass();
            pPropertySet.SetProperty("SERVER", server);
            pPropertySet.SetProperty("INSTANCE", instance);
            pPropertySet.SetProperty("USER", user);
            pPropertySet.SetProperty("PASSWORD", password);
            pPropertySet.SetProperty("DATABASE", database);
            pPropertySet.SetProperty("VERSION", version);
            IWorkspaceFactory2 pWorkspaceFactory = new SdeWorkspaceFactoryClass();

            try
            {
                pWorkSpace = pWorkspaceFactory.Open(pPropertySet, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pWorkSpace;
        }


    }
}
