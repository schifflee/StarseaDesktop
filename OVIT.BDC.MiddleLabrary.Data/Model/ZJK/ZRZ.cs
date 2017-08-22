using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVIT.BDC.MiddleLabrary.Data.Model.ZJK
{
    public class ZRZ
    {

        //幢编码  
        [Key]
        public string ZBM { get; set; }
        //幢号  
        public string ZH { get; set; }
        //项目名称  
        public string XMMC { get; set; }
        //建筑物名称  
        public string JZWMC { get; set; }
        //竣工日期 
        public string JGRQ { get; set; }
        //建筑物高度 
        public string JZWGD { get; set; }
        //幢占地面积  
        public string ZZDMJ { get; set; }
        //幢用地面积 
        public string ZYDMJ { get; set; }
        //预测建筑面积  
        public string YCJZMJ { get; set; }
        //实测建筑面积  
        public string SCJZMJ { get; set; }
        //总层数  public 
        string ZCS { get; set; }
        //地上层数  
        public string DSCS { get; set; }
        //地下层数 
        public string DXCS { get; set; }
        //地下深度  
        public string DXSD { get; set; }
        //规划用途  
        public string GHYT { get; set; }
        //房屋结构  
        public string FWJG { get; set; }
        //总套数  
        public string ZTS { get; set; }
        //建筑物基本用途  
        public string JZWJBYT { get; set; }
        //备注  
        public string BZ { get; set; }
        //交易状态  
        public string JYZT { get; set; }
        //不动产单元号  
        public string BDCDYH { get; set; }
        //自然幢号  
        public string ZRZH { get; set; }
        //幢坐落  
        public string ZZL { get; set; }
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
