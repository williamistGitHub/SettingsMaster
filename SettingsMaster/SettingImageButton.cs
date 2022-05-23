using System;
using System.Windows.Forms;
using System.Drawing;

namespace SettingsMaster
{
    class SettingImageButton : Setting
    {
        private Bitmap image;
        private float imageScale;
        private Action onClickCallback;

        public SettingImageButton(Bitmap image, float imageScale, Action onClickCallback = null)
        {
            this.image = image;
            this.imageScale = imageScale;
            this.onClickCallback = onClickCallback;
        }

        public override int CreateControls(int startY, Panel controlParent)
        {
            Button button = new Button();
            button.Location = new Point(0, startY);
            button.Text = "";
            if (onClickCallback != null)
                button.Click += delegate (object sender, EventArgs e) { onClickCallback(); };
            button.BackgroundImage = image;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Parent = controlParent;
            button.Size = new Size((int) (image.Width * imageScale), (int) (image.Height * imageScale));
            // make the button square
            if (button.Width > button.Height) // landscape image
                button.Height = button.Width;
            else // portrait image
                button.Width = button.Height;
            button.Refresh();
            return button.Height;
        }
    }
}
