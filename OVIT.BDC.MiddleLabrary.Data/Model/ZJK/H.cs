using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVIT.BDC.MiddleLabrary.Data.Model.ZJK
{
    public class H
    {
        //幢编码  
        public string ZBM { get; set; }
        //房屋编码（房屋ID）
        [Key]
        public string FWBM { get; set; }
        //幢号  
        public string ZH { get; set; }
        //逻辑幢号  
        public string LJZH { get; set; }
        //层号  
        public string CH { get; set; }
        //名义层  
        public string MYC { get; set; }
        //实际层  
        public string SJC { get; set; }
        //坐落  
        public string ZL { get; set; }
        //面积单位  
        public string MJDW { get; set; }
        //实际层数  
        public string SJCS { get; set; }
        //户号  
        public string HH { get; set; }
        //房号  
        public string FH { get; set; }
        //门牌号  
        public string MPH { get; set; }
        //室号部位  
        public string HSBW { get; set; }
        //户型  
        public string HX { get; set; }
        //户型结构  
        public string HXJG { get; set; }
        //房屋用途1  
        public string FWYT1 { get; set; }
        //房屋用途2  
        public string FWYT2 { get; set; }
        //房屋用途3  
        public string FWYT3 { get; set; }
        //预测建筑面积  
        public string YCJZMJ { get; set; }
        //预测套内建筑面积  
        public string YCTNJZMJ { get; set; }
        //预测分摊建筑面积  
        public string YCFTJZMJ { get; set; }
        //预测地下部分建筑面积  
        public string YCDXBFJZMJ { get; set; }
        //预测其它建筑面积  
        public string YCQTJZMJ { get; set; }
        //预测分摊系数  
        public string YCFTXS { get; set; }
        //实测建筑面积   
        public string SCJZMJ { get; set; }
        //实测套内建筑面积  
        public string SCTNJZMJ { get; set; }
        //实测分摊建筑面积  
        public string SCFTJZMJ { get; set; }
        //实测地下部分建筑面积  
        public string SCDXBFJZMJ { get; set; }
        //实测其它建筑面积  
        public string SCQTJZMJ { get; set; }
        //实测分摊系数  
        public string SCFTXS { get; set; }
        //共有土地面积  
        public string GYTDMJ { get; set; }
        //分摊土地面积  
        public string FTTDMJ { get; set; }
        //独用土地面积  
        public string DYTDMJ { get; set; }
        //房屋类型  
        public string FWLX { get; set; }
        //房屋性质  
        public string FWXZ { get; set; }
        //房产分户图  
        public string FCFHT { get; set; }
        //不动产单元号  
        public string BDCDYH { get; set; }
        //数据获取标识  
        public int SJHQBS { get; set; }
        //数据获取时间  
        public DateTime SJHQSJ { get; set; }
        //数据推送时间  
        public DateTime SJSCSJ { get; set; }
        //操作类型  
        public int CZLX { get; set; }

    }
}
