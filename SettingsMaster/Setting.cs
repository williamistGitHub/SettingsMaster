using System.Windows.Forms;

namespace SettingsMaster
{
    abstract class Setting
    {
        public abstract int CreateControls(int startY, Panel controlParent);
    }
}
