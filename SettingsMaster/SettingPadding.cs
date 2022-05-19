using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingPadding : Setting
    {
        public override int CreateControls(int startY, Panel controlParent)
        {
            return 5;
        }
    }
}
