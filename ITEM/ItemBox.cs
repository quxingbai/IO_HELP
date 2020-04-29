using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEM
{
    /// <summary>
    /// 在个是给系统插件添加自创参数用的被继承类
    /// </summary>
    public interface ItemBox
    {
        /// <summary>
        /// 父窗体的绘图画面
        /// </summary>
        Graphics SuperGraphics { get; set; }

    }
    
}
