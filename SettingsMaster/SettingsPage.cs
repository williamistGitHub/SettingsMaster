using System.Drawing;
using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingsPage
    {

        private string pageTitle;

        private Label pageTitleLabel;

        private Setting[] controls;

        public SettingsPage(string pageTitle, Setting[] settingsControls)
        {
            this.pageTitle = pageTitle;
            controls = settingsControls;
            pageTitleLabel = new Label();
            pageTitleLabel.Text = pageTitle;
            pageTitleLabel.Font = new Font(pageTitleLabel.Font.FontFamily, 27.75f, FontStyle.Bold);
            pageTitleLabel.Location = new Point(0, 0);
            pageTitleLabel.Height = 55;
            pageTitleLabel.TextAlign = ContentAlignment.TopCenter;
            pageTitleLabel.AutoEllipsis = true;
            pageTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        public void DisplaySettingsPage(Panel pagePanel)
        {
            pageTitleLabel.Width = pagePanel.Width;
            pageTitleLabel.Parent = pagePanel;
            int controlY = pageTitleLabel.Height + 4;
            foreach (var control in controls)
            {
                controlY += control.CreateControls(controlY, pagePanel);
            }
        }

        public void AddSelfToSidebar(ListBox sidebarListBox) {
            sidebarListBox.Items.Add(pageTitle);
        }

    }
}
