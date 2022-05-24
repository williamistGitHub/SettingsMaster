using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingLabel : Setting
    {
        private string labelText;
        private bool isHeader;

        public SettingLabel(string labelText, bool isHeader)
        {
            this.labelText = labelText;
            this.isHeader = isHeader;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            Label labelControl = new Label();
            labelControl.Text = labelText;
            labelControl.Location = new System.Drawing.Point(0, startY);
            if (isHeader)
                labelControl.Font = new Font(labelControl.Font.FontFamily, 10f, FontStyle.Bold);
            labelControl.Parent = controlParent;
            labelControl.AutoSize = true;
            labelControl.Refresh();
            return labelControl.Height;
        }
    }
}
