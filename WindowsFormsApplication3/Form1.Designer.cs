namespace PoECrafter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ItemInfoTextBoxParsed = new System.Windows.Forms.TextBox();
            this.ItemInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.itemMod1 = new System.Windows.Forms.ComboBox();
            this.itemMod2 = new System.Windows.Forms.ComboBox();
            this.itemMod1Value = new System.Windows.Forms.NumericUpDown();
            this.itemMod2Value = new System.Windows.Forms.NumericUpDown();
            this.buttonTestItem = new System.Windows.Forms.Button();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.itemMod3Value = new System.Windows.Forms.NumericUpDown();
            this.itemMod3 = new System.Windows.Forms.ComboBox();
            this.itemMod4Value = new System.Windows.Forms.NumericUpDown();
            this.itemMod4 = new System.Windows.Forms.ComboBox();
            this.itemMod5Value = new System.Windows.Forms.NumericUpDown();
            this.itemMod5 = new System.Windows.Forms.ComboBox();
            this.itemMod6Value = new System.Windows.Forms.NumericUpDown();
            this.itemMod6 = new System.Windows.Forms.ComboBox();
            this.AffixType1 = new System.Windows.Forms.Label();
            this.AffixType2 = new System.Windows.Forms.Label();
            this.AffixType3 = new System.Windows.Forms.Label();
            this.AffixType4 = new System.Windows.Forms.Label();
            this.AffixType5 = new System.Windows.Forms.Label();
            this.AffixType6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DelayNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedModCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedLoopCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod3Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod4Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod5Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod6Value)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedModCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedLoopCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemInfoTextBoxParsed
            // 
            this.ItemInfoTextBoxParsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemInfoTextBoxParsed.Location = new System.Drawing.Point(3, 239);
            this.ItemInfoTextBoxParsed.Multiline = true;
            this.ItemInfoTextBoxParsed.Name = "ItemInfoTextBoxParsed";
            this.ItemInfoTextBoxParsed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ItemInfoTextBoxParsed.Size = new System.Drawing.Size(416, 324);
            this.ItemInfoTextBoxParsed.TabIndex = 1;
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemInfoTextBox.Location = new System.Drawing.Point(425, 239);
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(440, 324);
            this.ItemInfoTextBox.TabIndex = 2;
            this.ItemInfoTextBox.Text = "";
            this.ItemInfoTextBox.TextChanged += new System.EventHandler(this.ItemInfoTextBox_TextChanged);
            // 
            // itemMod1
            // 
            this.itemMod1.FormattingEnabled = true;
            this.itemMod1.Location = new System.Drawing.Point(70, 146);
            this.itemMod1.Name = "itemMod1";
            this.itemMod1.Size = new System.Drawing.Size(286, 21);
            this.itemMod1.TabIndex = 3;
            this.itemMod1.SelectedIndexChanged += new System.EventHandler(this.itemMod1_SelectedIndexChanged);
            // 
            // itemMod2
            // 
            this.itemMod2.FormattingEnabled = true;
            this.itemMod2.Location = new System.Drawing.Point(70, 173);
            this.itemMod2.Name = "itemMod2";
            this.itemMod2.Size = new System.Drawing.Size(286, 21);
            this.itemMod2.TabIndex = 4;
            this.itemMod2.SelectedIndexChanged += new System.EventHandler(this.itemMod2_SelectedIndexChanged);
            // 
            // itemMod1Value
            // 
            this.itemMod1Value.DecimalPlaces = 2;
            this.itemMod1Value.Location = new System.Drawing.Point(362, 147);
            this.itemMod1Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod1Value.Name = "itemMod1Value";
            this.itemMod1Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod1Value.TabIndex = 5;
            this.itemMod1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemMod2Value
            // 
            this.itemMod2Value.DecimalPlaces = 2;
            this.itemMod2Value.Location = new System.Drawing.Point(362, 173);
            this.itemMod2Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod2Value.Name = "itemMod2Value";
            this.itemMod2Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod2Value.TabIndex = 6;
            this.itemMod2Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTestItem
            // 
            this.buttonTestItem.Location = new System.Drawing.Point(443, 38);
            this.buttonTestItem.Name = "buttonTestItem";
            this.buttonTestItem.Size = new System.Drawing.Size(416, 49);
            this.buttonTestItem.TabIndex = 7;
            this.buttonTestItem.Text = "Start Crafting";
            this.buttonTestItem.UseVisualStyleBackColor = true;
            this.buttonTestItem.Click += new System.EventHandler(this.buttonTestItem_Click);
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Items.AddRange(new object[] {
            "Cobalt Jewels",
            "Crimson Jewels",
            "Viridian Jewels",
            "Energy Shield Chest",
            "Armour Chest",
            "Evasion Chest",
            "Armour And Energy Shield Chest",
            "Armour And Evasion Chest",
            "Evasion And Energy Shield Chest",
            "Armour, Evasion And Energy Shield Chest",
            "Armour Helm",
            "Evasion Helm",
            "Energy Shield Helm",
            "Armour And Energy Shield Helm",
            "Armour And Evasion Helm",
            "Evasion And Energy Shield Helm",
            "Armour Gloves",
            "Evasion Gloves",
            "Energy Shield Gloves",
            "Armour And Energy Shield Gloves",
            "Armour And Evasion Gloves",
            "Evasion And Energy Shield Gloves",
            "Armour Boots",
            "Evasion Boots",
            "Energy Shield Boots",
            "Armour And Energy Shield Boots",
            "Armour And Evasion Boots",
            "Evasion And Energy Shield Boots",
            "Armour Shield",
            "Evasion Shield",
            "Energy Shield Shield",
            "Armour And Energy Shield Shield",
            "Armour And Evasion Shield",
            "Evasion And Energy Shield Shield",
            "Daggers",
            "Claws",
            "Bows",
            "Quivers",
            "Wands",
            "Staves",
            "Scepters",
            "One Hand Swords",
            "Two Hand Swords",
            "One Hand Axes",
            "Two Hand Axes",
            "One Hand Maces",
            "Two Hand Maces",
            "Rings",
            "Amulets",
            "Belts",
            "Life Flask",
            "Mana Flask",
            "Hybrid Flask",
            "Utility Flask",
            "Diamond Flask"});
            this.itemTypeBox.Location = new System.Drawing.Point(126, 40);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(293, 21);
            this.itemTypeBox.TabIndex = 9;
            this.itemTypeBox.SelectedIndexChanged += new System.EventHandler(this.itemTypeBox_SelectedIndexChanged);
            // 
            // itemMod3Value
            // 
            this.itemMod3Value.DecimalPlaces = 2;
            this.itemMod3Value.Location = new System.Drawing.Point(362, 200);
            this.itemMod3Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod3Value.Name = "itemMod3Value";
            this.itemMod3Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod3Value.TabIndex = 11;
            this.itemMod3Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemMod3
            // 
            this.itemMod3.FormattingEnabled = true;
            this.itemMod3.Location = new System.Drawing.Point(70, 200);
            this.itemMod3.Name = "itemMod3";
            this.itemMod3.Size = new System.Drawing.Size(286, 21);
            this.itemMod3.TabIndex = 10;
            this.itemMod3.SelectedIndexChanged += new System.EventHandler(this.itemMod3_SelectedIndexChanged);
            // 
            // itemMod4Value
            // 
            this.itemMod4Value.DecimalPlaces = 2;
            this.itemMod4Value.Location = new System.Drawing.Point(801, 146);
            this.itemMod4Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod4Value.Name = "itemMod4Value";
            this.itemMod4Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod4Value.TabIndex = 13;
            this.itemMod4Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemMod4
            // 
            this.itemMod4.FormattingEnabled = true;
            this.itemMod4.Location = new System.Drawing.Point(509, 146);
            this.itemMod4.Name = "itemMod4";
            this.itemMod4.Size = new System.Drawing.Size(286, 21);
            this.itemMod4.TabIndex = 12;
            this.itemMod4.SelectedIndexChanged += new System.EventHandler(this.itemMod4_SelectedIndexChanged);
            // 
            // itemMod5Value
            // 
            this.itemMod5Value.DecimalPlaces = 2;
            this.itemMod5Value.Location = new System.Drawing.Point(800, 173);
            this.itemMod5Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod5Value.Name = "itemMod5Value";
            this.itemMod5Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod5Value.TabIndex = 15;
            this.itemMod5Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemMod5
            // 
            this.itemMod5.FormattingEnabled = true;
            this.itemMod5.Location = new System.Drawing.Point(508, 173);
            this.itemMod5.Name = "itemMod5";
            this.itemMod5.Size = new System.Drawing.Size(286, 21);
            this.itemMod5.TabIndex = 14;
            this.itemMod5.SelectedIndexChanged += new System.EventHandler(this.itemMod5_SelectedIndexChanged);
            // 
            // itemMod6Value
            // 
            this.itemMod6Value.DecimalPlaces = 2;
            this.itemMod6Value.Location = new System.Drawing.Point(801, 198);
            this.itemMod6Value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemMod6Value.Name = "itemMod6Value";
            this.itemMod6Value.Size = new System.Drawing.Size(59, 20);
            this.itemMod6Value.TabIndex = 17;
            this.itemMod6Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemMod6
            // 
            this.itemMod6.FormattingEnabled = true;
            this.itemMod6.Location = new System.Drawing.Point(509, 198);
            this.itemMod6.Name = "itemMod6";
            this.itemMod6.Size = new System.Drawing.Size(286, 21);
            this.itemMod6.TabIndex = 16;
            this.itemMod6.SelectedIndexChanged += new System.EventHandler(this.itemMod6_SelectedIndexChanged);
            // 
            // AffixType1
            // 
            this.AffixType1.AutoSize = true;
            this.AffixType1.Location = new System.Drawing.Point(1, 149);
            this.AffixType1.Name = "AffixType1";
            this.AffixType1.Size = new System.Drawing.Size(0, 13);
            this.AffixType1.TabIndex = 18;
            // 
            // AffixType2
            // 
            this.AffixType2.AutoSize = true;
            this.AffixType2.Location = new System.Drawing.Point(1, 175);
            this.AffixType2.Name = "AffixType2";
            this.AffixType2.Size = new System.Drawing.Size(0, 13);
            this.AffixType2.TabIndex = 19;
            // 
            // AffixType3
            // 
            this.AffixType3.AutoSize = true;
            this.AffixType3.Location = new System.Drawing.Point(1, 200);
            this.AffixType3.Name = "AffixType3";
            this.AffixType3.Size = new System.Drawing.Size(0, 13);
            this.AffixType3.TabIndex = 20;
            // 
            // AffixType4
            // 
            this.AffixType4.AutoSize = true;
            this.AffixType4.Location = new System.Drawing.Point(440, 149);
            this.AffixType4.Name = "AffixType4";
            this.AffixType4.Size = new System.Drawing.Size(0, 13);
            this.AffixType4.TabIndex = 21;
            // 
            // AffixType5
            // 
            this.AffixType5.AutoSize = true;
            this.AffixType5.Location = new System.Drawing.Point(440, 176);
            this.AffixType5.Name = "AffixType5";
            this.AffixType5.Size = new System.Drawing.Size(0, 13);
            this.AffixType5.TabIndex = 22;
            // 
            // AffixType6
            // 
            this.AffixType6.AutoSize = true;
            this.AffixType6.Location = new System.Drawing.Point(440, 203);
            this.AffixType6.Name = "AffixType6";
            this.AffixType6.Size = new System.Drawing.Size(0, 13);
            this.AffixType6.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Affix Mod Type Selector";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.placeholderToolStripMenuItem.Text = "Material Locations";
            this.placeholderToolStripMenuItem.Click += new System.EventHandler(this.placeholderToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 569);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(862, 45);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // DelayNumber
            // 
            this.DelayNumber.AutoSize = true;
            this.DelayNumber.Location = new System.Drawing.Point(152, 601);
            this.DelayNumber.Name = "DelayNumber";
            this.DelayNumber.Size = new System.Drawing.Size(0, 13);
            this.DelayNumber.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Extra Delay in Milliseconds: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Wanted Mod Count";
            // 
            // SelectedModCount
            // 
            this.SelectedModCount.Location = new System.Drawing.Point(126, 67);
            this.SelectedModCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SelectedModCount.Name = "SelectedModCount";
            this.SelectedModCount.Size = new System.Drawing.Size(51, 20);
            this.SelectedModCount.TabIndex = 30;
            this.SelectedModCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Times To Loop Craft";
            // 
            // selectedLoopCount
            // 
            this.selectedLoopCount.Location = new System.Drawing.Point(126, 93);
            this.selectedLoopCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.selectedLoopCount.Name = "selectedLoopCount";
            this.selectedLoopCount.Size = new System.Drawing.Size(51, 20);
            this.selectedLoopCount.TabIndex = 32;
            this.selectedLoopCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 634);
            this.Controls.Add(this.selectedLoopCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedModCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelayNumber);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AffixType6);
            this.Controls.Add(this.AffixType5);
            this.Controls.Add(this.AffixType4);
            this.Controls.Add(this.AffixType3);
            this.Controls.Add(this.AffixType2);
            this.Controls.Add(this.AffixType1);
            this.Controls.Add(this.itemMod6Value);
            this.Controls.Add(this.itemMod6);
            this.Controls.Add(this.itemMod5Value);
            this.Controls.Add(this.itemMod5);
            this.Controls.Add(this.itemMod4Value);
            this.Controls.Add(this.itemMod4);
            this.Controls.Add(this.itemMod3Value);
            this.Controls.Add(this.itemMod3);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.buttonTestItem);
            this.Controls.Add(this.itemMod2Value);
            this.Controls.Add(this.itemMod1Value);
            this.Controls.Add(this.itemMod2);
            this.Controls.Add(this.itemMod1);
            this.Controls.Add(this.ItemInfoTextBox);
            this.Controls.Add(this.ItemInfoTextBoxParsed);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoE Auto Crafting System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemMod1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod3Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod4Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod5Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod6Value)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedModCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedLoopCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ItemInfoTextBoxParsed;
        private System.Windows.Forms.RichTextBox ItemInfoTextBox;
        private System.Windows.Forms.ComboBox itemMod1;
        private System.Windows.Forms.ComboBox itemMod2;
        private System.Windows.Forms.NumericUpDown itemMod1Value;
        private System.Windows.Forms.NumericUpDown itemMod2Value;
        private System.Windows.Forms.Button buttonTestItem;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.NumericUpDown itemMod3Value;
        private System.Windows.Forms.ComboBox itemMod3;
        private System.Windows.Forms.NumericUpDown itemMod4Value;
        private System.Windows.Forms.ComboBox itemMod4;
        private System.Windows.Forms.NumericUpDown itemMod5Value;
        private System.Windows.Forms.ComboBox itemMod5;
        private System.Windows.Forms.NumericUpDown itemMod6Value;
        private System.Windows.Forms.ComboBox itemMod6;
        private System.Windows.Forms.Label AffixType1;
        private System.Windows.Forms.Label AffixType2;
        private System.Windows.Forms.Label AffixType3;
        private System.Windows.Forms.Label AffixType4;
        private System.Windows.Forms.Label AffixType5;
        private System.Windows.Forms.Label AffixType6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label DelayNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SelectedModCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown selectedLoopCount;
    }
}

