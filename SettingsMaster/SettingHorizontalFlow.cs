using System.Windows.Forms;
using System.Drawing;

namespace SettingsMaster
{
    class SettingHorizontalFlow : Setting
    {
        Setting[] controls;

        public SettingHorizontalFlow(Setting[] controls)
        {
            this.controls = controls;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Location = new Point(0, startY);
            flowPanel.Width = controlParent.Width;
            flowPanel.Height = 0;
            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanel.AutoSize = true;
            //flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanel.AutoScroll = false;
            flowPanel.Parent = controlParent;
            flowPanel.Refresh();
            foreach (var control in controls)
            {
                control.CreateControls(0, flowPanel);
            }
            flowPanel.Refresh();
            return flowPanel.Height;
        }
    }
}
