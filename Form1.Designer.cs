namespace Magical_Item_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGenerate = new Button();
            listBoxItems = new ListBox();
            btnClear = new Button();
            gBoxSettings = new GroupBox();
            nudNumItems = new NumericUpDown();
            label3 = new Label();
            chkPotions = new CheckBox();
            chkMisc = new CheckBox();
            chkArmor = new CheckBox();
            chkWeapons = new CheckBox();
            label2 = new Label();
            gBoxResults = new GroupBox();
            btnAbout = new Button();
            btnQuit = new Button();
            statusStrip = new StatusStrip();
            tooltipLabel = new ToolStripStatusLabel();
            gBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumItems).BeginInit();
            gBoxResults.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackgroundImage = (Image)resources.GetObject("btnGenerate.BackgroundImage");
            btnGenerate.BackgroundImageLayout = ImageLayout.Center;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(525, 11);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(256, 54);
            btnGenerate.TabIndex = 0;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            btnGenerate.MouseHover += btnGenerate_MouseHover;
            // 
            // listBoxItems
            // 
            listBoxItems.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 21;
            listBoxItems.Location = new Point(10, 22);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(770, 319);
            listBoxItems.TabIndex = 2;
            listBoxItems.SelectedIndexChanged += listBoxItems_SelectedIndexChanged;
            listBoxItems.DoubleClick += listBoxItems_DoubleClick;
            listBoxItems.MouseHover += listBoxItems_MouseHover;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(10, 347);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.MouseHover += btnClear_MouseHover;
            // 
            // gBoxSettings
            // 
            gBoxSettings.Controls.Add(nudNumItems);
            gBoxSettings.Controls.Add(label3);
            gBoxSettings.Controls.Add(chkPotions);
            gBoxSettings.Controls.Add(chkMisc);
            gBoxSettings.Controls.Add(chkArmor);
            gBoxSettings.Controls.Add(chkWeapons);
            gBoxSettings.Controls.Add(label2);
            gBoxSettings.Controls.Add(btnGenerate);
            gBoxSettings.Location = new Point(2, 2);
            gBoxSettings.Name = "gBoxSettings";
            gBoxSettings.Size = new Size(786, 71);
            gBoxSettings.TabIndex = 4;
            gBoxSettings.TabStop = false;
            gBoxSettings.Text = "Settings";
            gBoxSettings.Enter += gBoxSettings_Enter;
            gBoxSettings.MouseHover += gBoxSettings_MouseHover;
            // 
            // nudNumItems
            // 
            nudNumItems.Location = new Point(10, 37);
            nudNumItems.Name = "nudNumItems";
            nudNumItems.Size = new Size(46, 23);
            nudNumItems.TabIndex = 0;
            nudNumItems.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 46);
            label3.TabIndex = 7;
            label3.Text = "Number of Items";
            label3.MouseHover += label3_MouseHover;
            // 
            // chkPotions
            // 
            chkPotions.AutoSize = true;
            chkPotions.Checked = true;
            chkPotions.CheckState = CheckState.Checked;
            chkPotions.Location = new Point(403, 41);
            chkPotions.Name = "chkPotions";
            chkPotions.Size = new Size(66, 19);
            chkPotions.TabIndex = 6;
            chkPotions.Text = "Potions";
            chkPotions.UseVisualStyleBackColor = true;
            chkPotions.CheckedChanged += chkPotions_CheckedChanged;
            chkPotions.MouseHover += chkPotions_MouseHover;
            // 
            // chkMisc
            // 
            chkMisc.AutoSize = true;
            chkMisc.Checked = true;
            chkMisc.CheckState = CheckState.Checked;
            chkMisc.Location = new Point(314, 42);
            chkMisc.Name = "chkMisc";
            chkMisc.Size = new Size(83, 19);
            chkMisc.TabIndex = 5;
            chkMisc.Text = "Misc Items";
            chkMisc.UseVisualStyleBackColor = true;
            chkMisc.CheckedChanged += chkMisc_CheckedChanged_1;
            chkMisc.MouseHover += chkMisc_MouseHover;
            // 
            // chkArmor
            // 
            chkArmor.AutoSize = true;
            chkArmor.Checked = true;
            chkArmor.CheckState = CheckState.Checked;
            chkArmor.Location = new Point(248, 42);
            chkArmor.Name = "chkArmor";
            chkArmor.Size = new Size(60, 19);
            chkArmor.TabIndex = 4;
            chkArmor.Text = "Armor";
            chkArmor.UseVisualStyleBackColor = true;
            chkArmor.CheckedChanged += chkArmor_CheckedChanged_1;
            chkArmor.MouseHover += chkArmor_MouseHover;
            // 
            // chkWeapons
            // 
            chkWeapons.AutoSize = true;
            chkWeapons.Checked = true;
            chkWeapons.CheckState = CheckState.Checked;
            chkWeapons.Location = new Point(167, 42);
            chkWeapons.Name = "chkWeapons";
            chkWeapons.Size = new Size(75, 19);
            chkWeapons.TabIndex = 3;
            chkWeapons.Text = "Weapons";
            chkWeapons.UseVisualStyleBackColor = true;
            chkWeapons.CheckedChanged += chkWeapons_CheckedChanged_1;
            chkWeapons.MouseHover += chkWeapons_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Item Types";
            label2.Click += label2_Click;
            // 
            // gBoxResults
            // 
            gBoxResults.Controls.Add(btnAbout);
            gBoxResults.Controls.Add(btnQuit);
            gBoxResults.Controls.Add(listBoxItems);
            gBoxResults.Controls.Add(btnClear);
            gBoxResults.Location = new Point(2, 79);
            gBoxResults.Name = "gBoxResults";
            gBoxResults.Size = new Size(786, 379);
            gBoxResults.TabIndex = 5;
            gBoxResults.TabStop = false;
            gBoxResults.Text = "Generated Items:";
            gBoxResults.MouseHover += gBoxResults_MouseHover;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(624, 347);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(705, 347);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            btnQuit.MouseHover += btnQuit_MouseHover;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tooltipLabel });
            statusStrip.Location = new Point(0, 462);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(795, 22);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "Ready.";
            // 
            // tooltipLabel
            // 
            tooltipLabel.Name = "tooltipLabel";
            tooltipLabel.Size = new Size(39, 17);
            tooltipLabel.Text = "Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 484);
            Controls.Add(statusStrip);
            Controls.Add(gBoxResults);
            Controls.Add(gBoxSettings);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Magical Item Generator";
            Load += Form1_Load;
            MouseHover += Form1_MouseHover;
            gBoxSettings.ResumeLayout(false);
            gBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumItems).EndInit();
            gBoxResults.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private ListBox listBoxItems;
        private Button btnClear;
        private GroupBox gBoxSettings;
        private NumericUpDown nudNumItems;
        private Label label3;
        private CheckBox chkPotions;
        private CheckBox chkMisc;
        private CheckBox chkArmor;
        private CheckBox chkWeapons;
        private Label label2;
        private GroupBox gBoxResults;
        private Button btnQuit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tooltipLabel;
        private Button btnAbout;
    }
}
