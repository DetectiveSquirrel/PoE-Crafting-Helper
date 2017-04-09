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
            this.label1 = new System.Windows.Forms.Label();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod2Value)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemInfoTextBoxParsed
            // 
            this.ItemInfoTextBoxParsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInfoTextBoxParsed.Location = new System.Drawing.Point(13, 110);
            this.ItemInfoTextBoxParsed.Multiline = true;
            this.ItemInfoTextBoxParsed.Name = "ItemInfoTextBoxParsed";
            this.ItemInfoTextBoxParsed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ItemInfoTextBoxParsed.Size = new System.Drawing.Size(399, 314);
            this.ItemInfoTextBoxParsed.TabIndex = 1;
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInfoTextBox.Location = new System.Drawing.Point(418, 110);
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(400, 314);
            this.ItemInfoTextBox.TabIndex = 2;
            this.ItemInfoTextBox.Text = resources.GetString("ItemInfoTextBox.Text");
            this.ItemInfoTextBox.TextChanged += new System.EventHandler(this.ItemInfoTextBox_TextChanged);
            // 
            // itemMod1
            // 
            this.itemMod1.FormattingEnabled = true;
            this.itemMod1.Location = new System.Drawing.Point(13, 15);
            this.itemMod1.Name = "itemMod1";
            this.itemMod1.Size = new System.Drawing.Size(286, 21);
            this.itemMod1.TabIndex = 3;
            // 
            // itemMod2
            // 
            this.itemMod2.FormattingEnabled = true;
            this.itemMod2.Location = new System.Drawing.Point(13, 42);
            this.itemMod2.Name = "itemMod2";
            this.itemMod2.Size = new System.Drawing.Size(286, 21);
            this.itemMod2.TabIndex = 4;
            // 
            // itemMod1Value
            // 
            this.itemMod1Value.DecimalPlaces = 2;
            this.itemMod1Value.Location = new System.Drawing.Point(305, 16);
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
            this.itemMod2Value.Location = new System.Drawing.Point(305, 42);
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
            this.buttonTestItem.Location = new System.Drawing.Point(13, 69);
            this.buttonTestItem.Name = "buttonTestItem";
            this.buttonTestItem.Size = new System.Drawing.Size(75, 23);
            this.buttonTestItem.TabIndex = 7;
            this.buttonTestItem.Text = "Test";
            this.buttonTestItem.UseVisualStyleBackColor = true;
            this.buttonTestItem.Click += new System.EventHandler(this.buttonTestItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Placeholder for item data\r\nYou can paste any item here if you wish\r\n";
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Items.AddRange(new object[] {
            "CobaltJewel",
            "ESChest"});
            this.itemTypeBox.Location = new System.Drawing.Point(418, 16);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(286, 21);
            this.itemTypeBox.TabIndex = 9;
            this.itemTypeBox.SelectedIndexChanged += new System.EventHandler(this.itemTypeBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 436);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTestItem);
            this.Controls.Add(this.itemMod2Value);
            this.Controls.Add(this.itemMod1Value);
            this.Controls.Add(this.itemMod2);
            this.Controls.Add(this.itemMod1);
            this.Controls.Add(this.ItemInfoTextBox);
            this.Controls.Add(this.ItemInfoTextBoxParsed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path of Exile Auto Crafting System";
            ((System.ComponentModel.ISupportInitialize)(this.itemMod1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMod2Value)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemTypeBox;
    }
}

