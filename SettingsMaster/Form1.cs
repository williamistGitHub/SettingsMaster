using System;
using System.Windows.Forms;

namespace SettingsMaster
{
    public partial class Form1 : Form
    {
        private SettingsPage[] pages =
        {
            new SettingsPage("Mouse Settings", new Setting[] {
                new SettingLabel("Test Label"),
                new SettingLabel("Label 2 :D")
            }),
            new SettingsPage("Display Settings", new Setting[] {
                new SettingLabel("page 2 :d"),
                new SettingLabel("wonder if this will work?")
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
            mainSplitContainer.Panel2.Controls.Clear();
            pages[0].DisplaySettingsPage(mainSplitContainer.Panel2);
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

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainSplitContainer.Panel2.Controls.Clear();
            pages[categoriesListBox.SelectedIndex].DisplaySettingsPage(mainSplitContainer.Panel2);
        }
    }
}
