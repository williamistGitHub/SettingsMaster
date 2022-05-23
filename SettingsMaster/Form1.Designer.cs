
namespace SettingsMaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 15;
            this.categoriesListBox.Location = new System.Drawing.Point(3, 47);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(157, 424);
            this.categoriesListBox.TabIndex = 0;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Settings:";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.categoriesListBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.textBox1);
            this.mainSplitContainer.Panel1.Controls.Add(this.label1);
            this.mainSplitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.AutoScroll = true;
            this.mainSplitContainer.Panel2.Controls.Add(this.button1);
            this.mainSplitContainer.Panel2.Controls.Add(this.comboBox2);
            this.mainSplitContainer.Panel2.Controls.Add(this.label4);
            this.mainSplitContainer.Panel2.Controls.Add(this.label3);
            this.mainSplitContainer.Panel2.Controls.Add(this.comboBox1);
            this.mainSplitContainer.Panel2.Controls.Add(this.label2);
            this.mainSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSplitContainer.Size = new System.Drawing.Size(669, 477);
            this.mainSplitContainer.SplitterDistance = 167;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 23);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "1920 x 1080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Display Resolution:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100%",
            "150%",
            "200%"});
            this.comboBox1.Location = new System.Drawing.Point(92, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "150%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display Zoom:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SettingsMaster.Properties.Resources.cursor1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(45, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 144);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 501);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "Form1";
            this.Text = "SettingsMaster v0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

