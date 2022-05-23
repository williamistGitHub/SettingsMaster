using System;
using System.Windows.Forms;

namespace SettingsMaster
{
    public partial class Form1 : Form
    {
        private SettingsPage[] pages =
        {
            new SettingsPage("Cursor Settings", new Setting[] {
                new SettingLabel("Choose a cursor:"),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingImageButton(Properties.Resources.cursor1, 0.2f),
                    new SettingImageButton(Properties.Resources.apple1, 0.2f)
                }),
                new SettingLabel("Or upload a custom one:"),
                new SettingButton("Upload Cursor File (*.cur)")
            })
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategoriesList();
            categoriesListBox.SelectedIndex = 0; // Make sure the first item is selected.

            // display first page
            RebuildPageControls();
        }

        private void PopulateCategoriesList()
        {
            foreach (var page in pages) {
                page.AddSelfToSidebar(categoriesListBox);
            }

            /*categoriesListBox.Items.Add("Mouse Settings");
            categoriesListBox.Items.Add("Display Settings");
            categoriesListBox.Items.Add("Taskbar Settings");*/
        }

        private void RebuildPageControls()
        {
            mainSplitContainer.Panel2.Controls.Clear();
            pages[categoriesListBox.SelectedIndex].DisplaySettingsPage(mainSplitContainer.Panel2);
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebuildPageControls();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RebuildPageControls();
        }
    }
}
