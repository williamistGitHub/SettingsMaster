using System;
using System.Windows.Forms;

namespace SettingsMaster
{
    public partial class Form1 : Form
    {
        private SettingsPage[] pages =
        {
            new SettingsPage("Cursor", new Setting[] {
                //new SettingLabel("Cursor Settings", true),
                new SettingPadding(10),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("App Starting = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Arrow = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Crosshair = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Hand = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Help = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("IBeam = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("No = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("North-West Pen = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Person = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Pin = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("SizeAll = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("SizeNESW = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("SizeNS = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("SizeNWSE = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("SizeWE = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("UpArrow = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingHorizontalFlow(new Setting[] {
                    new SettingLabel("Wait = "),
                    new SettingButton("C:\Users\149455\potato.cur")
                }),
                new SettingPadding(10),
                new SettingLabel("Cursor Size"),
                new SettingLabel("Cursor Speed"),
                new SettingLabel("Cursor Trail")
            }),
            new SettingsPage("Display", new Setting[] {
                new SettingLabel("Desktop Icons Size"),
                new SettingLabel("Taskbar Size"),
                new SettingLabel("Everything Size"),
                new SettingLabel("Desktop Background")
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
