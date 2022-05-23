using System;
using System.Windows.Forms;

namespace SettingsMaster
{
    class SettingButton : Setting
    {
        string buttonText;
        Action onClickCallback;

        public SettingButton(string buttonText, Action onClickCallback = null)
        {
            this.buttonText = buttonText;
            this.onClickCallback = onClickCallback;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(0, startY);
            button.Text = buttonText;
            if (onClickCallback != null)
                button.Click += delegate (object sender, EventArgs e) { onClickCallback(); };
            button.Parent = controlParent;
            button.AutoSize = true;
            button.Refresh();
            return button.Height;
        }

    }
}
