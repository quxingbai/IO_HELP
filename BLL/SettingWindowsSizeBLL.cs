using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SETTING;

namespace BLL
{
    public class SettingWindowsSizeBLL
    {
        SettingWindowsSize sws = new SettingWindowsSize();
        public void RESIZE(int width, int height)
        {
            sws.RESIZE(width, height);
        }
    }
}
