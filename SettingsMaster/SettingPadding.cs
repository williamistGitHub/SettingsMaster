using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingPadding : Setting
    {
        private int padding;

        public SettingPadding(int padding = 5) {
            this.padding = padding;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            return padding;
        }
    }
}
