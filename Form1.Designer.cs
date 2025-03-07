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
            btnGenerate = new Button();
            listBoxItems = new ListBox();
            btnClear = new Button();
            gBoxSettings = new GroupBox();
            label3 = new Label();
            chkPotions = new CheckBox();
            chkMisc = new CheckBox();
            chkArmor = new CheckBox();
            chkWeapons = new CheckBox();
            label2 = new Label();
            nudNumItems = new NumericUpDown();
            gBoxResults = new GroupBox();
            gBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumItems).BeginInit();
            gBoxResults.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(688, 33);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(92, 30);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 19;
            listBoxItems.Location = new Point(10, 22);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(770, 289);
            listBoxItems.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(10, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // gBoxSettings
            // 
            gBoxSettings.Controls.Add(label3);
            gBoxSettings.Controls.Add(chkPotions);
            gBoxSettings.Controls.Add(chkMisc);
            gBoxSettings.Controls.Add(chkArmor);
            gBoxSettings.Controls.Add(chkWeapons);
            gBoxSettings.Controls.Add(label2);
            gBoxSettings.Controls.Add(nudNumItems);
            gBoxSettings.Controls.Add(btnGenerate);
            gBoxSettings.Location = new Point(2, 2);
            gBoxSettings.Name = "gBoxSettings";
            gBoxSettings.Size = new Size(786, 71);
            gBoxSettings.TabIndex = 4;
            gBoxSettings.TabStop = false;
            gBoxSettings.Text = "Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 7;
            label3.Text = "Number of Items";
            // 
            // chkPotions
            // 
            chkPotions.AutoSize = true;
            chkPotions.Checked = true;
            chkPotions.CheckState = CheckState.Checked;
            chkPotions.Location = new Point(369, 40);
            chkPotions.Name = "chkPotions";
            chkPotions.Size = new Size(66, 19);
            chkPotions.TabIndex = 6;
            chkPotions.Text = "Potions";
            chkPotions.UseVisualStyleBackColor = true;
            chkPotions.CheckedChanged += chkPotions_CheckedChanged;
            // 
            // chkMisc
            // 
            chkMisc.AutoSize = true;
            chkMisc.Checked = true;
            chkMisc.CheckState = CheckState.Checked;
            chkMisc.Location = new Point(280, 41);
            chkMisc.Name = "chkMisc";
            chkMisc.Size = new Size(83, 19);
            chkMisc.TabIndex = 5;
            chkMisc.Text = "Misc Items";
            chkMisc.UseVisualStyleBackColor = true;
            // 
            // chkArmor
            // 
            chkArmor.AutoSize = true;
            chkArmor.Checked = true;
            chkArmor.CheckState = CheckState.Checked;
            chkArmor.Location = new Point(214, 41);
            chkArmor.Name = "chkArmor";
            chkArmor.Size = new Size(60, 19);
            chkArmor.TabIndex = 4;
            chkArmor.Text = "Armor";
            chkArmor.UseVisualStyleBackColor = true;
            // 
            // chkWeapons
            // 
            chkWeapons.AutoSize = true;
            chkWeapons.Checked = true;
            chkWeapons.CheckState = CheckState.Checked;
            chkWeapons.Location = new Point(133, 41);
            chkWeapons.Name = "chkWeapons";
            chkWeapons.Size = new Size(75, 19);
            chkWeapons.TabIndex = 3;
            chkWeapons.Text = "Weapons";
            chkWeapons.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Item Types";
            // 
            // nudNumItems
            // 
            nudNumItems.Location = new Point(34, 40);
            nudNumItems.Name = "nudNumItems";
            nudNumItems.Size = new Size(46, 23);
            nudNumItems.TabIndex = 0;
            nudNumItems.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gBoxResults
            // 
            gBoxResults.Controls.Add(listBoxItems);
            gBoxResults.Controls.Add(btnClear);
            gBoxResults.Location = new Point(2, 79);
            gBoxResults.Name = "gBoxResults";
            gBoxResults.Size = new Size(786, 348);
            gBoxResults.TabIndex = 5;
            gBoxResults.TabStop = false;
            gBoxResults.Text = "Generated Items:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 434);
            Controls.Add(gBoxResults);
            Controls.Add(gBoxSettings);
            Name = "Form1";
            Text = "Magical Item Generator";
            Load += Form1_Load;
            gBoxSettings.ResumeLayout(false);
            gBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumItems).EndInit();
            gBoxResults.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
