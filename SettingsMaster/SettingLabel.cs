using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingLabel : Setting
    {
        private string labelText;

        public SettingLabel(string labelText)
        {
            this.labelText = labelText;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            Label labelControl = new Label();
            labelControl.Text = labelText;
            labelControl.Location = new System.Drawing.Point(0, startY);
            labelControl.Parent = controlParent;
            labelControl.AutoSize = true;
            labelControl.Refresh();
            return labelControl.Height;
        }
    }
}
