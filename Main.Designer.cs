
namespace OSRS_DPS_Calculator {

    partial class Main {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            attackLevel = new NumericUpDown();
            attackPictureBox = new PictureBox();
            strengthPictureBox = new PictureBox();
            rangedPictureBox = new PictureBox();
            magicPictureBox = new PictureBox();
            miningPictureBox = new PictureBox();
            strengthLevel = new NumericUpDown();
            rangedLevel = new NumericUpDown();
            magicLevel = new NumericUpDown();
            miningLevel = new NumericUpDown();
            statsPictureBox = new PictureBox();
            potionsPictureBox = new PictureBox();
            prayersPictureBox = new PictureBox();
            attackPotions = new ComboBox();
            strengthPotions = new ComboBox();
            rangedPotions = new ComboBox();
            magicPotions = new ComboBox();
            miningPotions = new ComboBox();
            statsPanel = new Panel();
            miningTotal = new Label();
            magicTotal = new Label();
            rangedTotal = new Label();
            strengthTotal = new Label();
            attackTotal = new Label();
            magicPrayers = new ComboBox();
            rangedPrayers = new ComboBox();
            strengthPrayers = new ComboBox();
            attackPrayers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)attackLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attackPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rangedPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magicPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miningPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rangedLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magicLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miningLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)potionsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prayersPictureBox).BeginInit();
            statsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // attackLevel
            // 
            attackLevel.Location = new Point(66, 59);
            attackLevel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            attackLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            attackLevel.Name = "attackLevel";
            attackLevel.Size = new Size(38, 23);
            attackLevel.TabIndex = 1;
            attackLevel.Value = new decimal(new int[] { 99, 0, 0, 0 });
            attackLevel.ValueChanged += attackLevel_ValueChanged;
            // 
            // attackPictureBox
            // 
            attackPictureBox.Image = Properties.Resources.Attack_icon__detail_;
            attackPictureBox.Location = new Point(16, 55);
            attackPictureBox.Name = "attackPictureBox";
            attackPictureBox.Size = new Size(30, 30);
            attackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            attackPictureBox.TabIndex = 3;
            attackPictureBox.TabStop = false;
            // 
            // strengthPictureBox
            // 
            strengthPictureBox.Image = (Image)resources.GetObject("strengthPictureBox.Image");
            strengthPictureBox.Location = new Point(19, 91);
            strengthPictureBox.Name = "strengthPictureBox";
            strengthPictureBox.Size = new Size(24, 30);
            strengthPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            strengthPictureBox.TabIndex = 4;
            strengthPictureBox.TabStop = false;
            // 
            // rangedPictureBox
            // 
            rangedPictureBox.Image = (Image)resources.GetObject("rangedPictureBox.Image");
            rangedPictureBox.Location = new Point(16, 127);
            rangedPictureBox.Name = "rangedPictureBox";
            rangedPictureBox.Size = new Size(30, 30);
            rangedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rangedPictureBox.TabIndex = 5;
            rangedPictureBox.TabStop = false;
            // 
            // magicPictureBox
            // 
            magicPictureBox.Image = (Image)resources.GetObject("magicPictureBox.Image");
            magicPictureBox.Location = new Point(16, 163);
            magicPictureBox.Name = "magicPictureBox";
            magicPictureBox.Size = new Size(30, 29);
            magicPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            magicPictureBox.TabIndex = 6;
            magicPictureBox.TabStop = false;
            // 
            // miningPictureBox
            // 
            miningPictureBox.Image = (Image)resources.GetObject("miningPictureBox.Image");
            miningPictureBox.Location = new Point(16, 199);
            miningPictureBox.Name = "miningPictureBox";
            miningPictureBox.Size = new Size(30, 30);
            miningPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            miningPictureBox.TabIndex = 7;
            miningPictureBox.TabStop = false;
            // 
            // strengthLevel
            // 
            strengthLevel.Location = new Point(66, 95);
            strengthLevel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            strengthLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            strengthLevel.Name = "strengthLevel";
            strengthLevel.Size = new Size(38, 23);
            strengthLevel.TabIndex = 8;
            strengthLevel.Value = new decimal(new int[] { 99, 0, 0, 0 });
            strengthLevel.ValueChanged += strengthLevel_ValueChanged;
            // 
            // rangedLevel
            // 
            rangedLevel.Location = new Point(66, 131);
            rangedLevel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            rangedLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rangedLevel.Name = "rangedLevel";
            rangedLevel.Size = new Size(38, 23);
            rangedLevel.TabIndex = 9;
            rangedLevel.Value = new decimal(new int[] { 99, 0, 0, 0 });
            rangedLevel.ValueChanged += rangedLevel_ValueChanged;
            // 
            // magicLevel
            // 
            magicLevel.Location = new Point(66, 166);
            magicLevel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            magicLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            magicLevel.Name = "magicLevel";
            magicLevel.Size = new Size(38, 23);
            magicLevel.TabIndex = 10;
            magicLevel.Value = new decimal(new int[] { 99, 0, 0, 0 });
            magicLevel.ValueChanged += magicLevel_ValueChanged;
            // 
            // miningLevel
            // 
            miningLevel.Location = new Point(66, 203);
            miningLevel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            miningLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            miningLevel.Name = "miningLevel";
            miningLevel.Size = new Size(38, 23);
            miningLevel.TabIndex = 11;
            miningLevel.Value = new decimal(new int[] { 99, 0, 0, 0 });
            miningLevel.ValueChanged += miningLevel_ValueChanged;
            // 
            // statsPictureBox
            // 
            statsPictureBox.Image = (Image)resources.GetObject("statsPictureBox.Image");
            statsPictureBox.Location = new Point(71, 13);
            statsPictureBox.Name = "statsPictureBox";
            statsPictureBox.Size = new Size(30, 30);
            statsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            statsPictureBox.TabIndex = 12;
            statsPictureBox.TabStop = false;
            // 
            // potionsPictureBox
            // 
            potionsPictureBox.Image = (Image)resources.GetObject("potionsPictureBox.Image");
            potionsPictureBox.Location = new Point(188, 14);
            potionsPictureBox.Name = "potionsPictureBox";
            potionsPictureBox.Size = new Size(21, 30);
            potionsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            potionsPictureBox.TabIndex = 13;
            potionsPictureBox.TabStop = false;
            // 
            // prayersPictureBox
            // 
            prayersPictureBox.Image = (Image)resources.GetObject("prayersPictureBox.Image");
            prayersPictureBox.Location = new Point(342, 14);
            prayersPictureBox.Name = "prayersPictureBox";
            prayersPictureBox.Size = new Size(30, 30);
            prayersPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            prayersPictureBox.TabIndex = 14;
            prayersPictureBox.TabStop = false;
            // 
            // attackPotions
            // 
            attackPotions.DropDownStyle = ComboBoxStyle.DropDownList;
            attackPotions.FormattingEnabled = true;
            attackPotions.Items.AddRange(new object[] { "None", "Attack", "Super Attack", "Zamorak Brew", "Overload (+)", "Smelling Salts" });
            attackPotions.Location = new Point(120, 59);
            attackPotions.Name = "attackPotions";
            attackPotions.Size = new Size(155, 23);
            attackPotions.TabIndex = 15;
            attackPotions.SelectedIndexChanged += attackPotions_SelectedIndexChanged;
            // 
            // strengthPotions
            // 
            strengthPotions.DropDownStyle = ComboBoxStyle.DropDownList;
            strengthPotions.FormattingEnabled = true;
            strengthPotions.Items.AddRange(new object[] { "None", "Strength", "Super Strength", "Overload (+)", "Smelling Salts" });
            strengthPotions.Location = new Point(120, 95);
            strengthPotions.Name = "strengthPotions";
            strengthPotions.Size = new Size(155, 23);
            strengthPotions.TabIndex = 16;
            strengthPotions.SelectedIndexChanged += strengthPotions_SelectedIndexChanged;
            // 
            // rangedPotions
            // 
            rangedPotions.DropDownStyle = ComboBoxStyle.DropDownList;
            rangedPotions.FormattingEnabled = true;
            rangedPotions.Items.AddRange(new object[] { "None", "Ranging", "Overload (+)", "Smelling Salts" });
            rangedPotions.Location = new Point(120, 131);
            rangedPotions.Name = "rangedPotions";
            rangedPotions.Size = new Size(155, 23);
            rangedPotions.TabIndex = 17;
            rangedPotions.SelectedIndexChanged += rangedPotions_SelectedIndexChanged;
            // 
            // magicPotions
            // 
            magicPotions.DropDownStyle = ComboBoxStyle.DropDownList;
            magicPotions.FormattingEnabled = true;
            magicPotions.Items.AddRange(new object[] { "None", "Magic", "Ancient Brew", "Forgotten Brew", "Imbued Heart", "Saturated Heart", "Overload (+)", "Smelling Salts" });
            magicPotions.Location = new Point(120, 166);
            magicPotions.Name = "magicPotions";
            magicPotions.Size = new Size(155, 23);
            magicPotions.TabIndex = 18;
            magicPotions.SelectedIndexChanged += magicPotions_SelectedIndexChanged;
            // 
            // miningPotions
            // 
            miningPotions.DropDownStyle = ComboBoxStyle.DropDownList;
            miningPotions.FormattingEnabled = true;
            miningPotions.Items.AddRange(new object[] { "None", "Dragon Pick Spec" });
            miningPotions.Location = new Point(120, 203);
            miningPotions.Name = "miningPotions";
            miningPotions.Size = new Size(155, 23);
            miningPotions.TabIndex = 19;
            miningPotions.SelectedIndexChanged += miningPotions_SelectedIndexChanged;
            // 
            // statsPanel
            // 
            statsPanel.BackColor = SystemColors.ControlDark;
            statsPanel.Controls.Add(miningTotal);
            statsPanel.Controls.Add(magicTotal);
            statsPanel.Controls.Add(rangedTotal);
            statsPanel.Controls.Add(strengthTotal);
            statsPanel.Controls.Add(attackTotal);
            statsPanel.Controls.Add(magicPrayers);
            statsPanel.Controls.Add(rangedPrayers);
            statsPanel.Controls.Add(strengthPrayers);
            statsPanel.Controls.Add(attackPrayers);
            statsPanel.Controls.Add(statsPictureBox);
            statsPanel.Controls.Add(miningPotions);
            statsPanel.Controls.Add(attackLevel);
            statsPanel.Controls.Add(magicPotions);
            statsPanel.Controls.Add(attackPictureBox);
            statsPanel.Controls.Add(rangedPotions);
            statsPanel.Controls.Add(strengthPictureBox);
            statsPanel.Controls.Add(strengthPotions);
            statsPanel.Controls.Add(rangedPictureBox);
            statsPanel.Controls.Add(attackPotions);
            statsPanel.Controls.Add(magicPictureBox);
            statsPanel.Controls.Add(prayersPictureBox);
            statsPanel.Controls.Add(miningPictureBox);
            statsPanel.Controls.Add(potionsPictureBox);
            statsPanel.Controls.Add(strengthLevel);
            statsPanel.Controls.Add(rangedLevel);
            statsPanel.Controls.Add(miningLevel);
            statsPanel.Controls.Add(magicLevel);
            statsPanel.Location = new Point(13, 13);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(564, 254);
            statsPanel.TabIndex = 20;
            // 
            // miningTotal
            // 
            miningTotal.AutoSize = true;
            miningTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            miningTotal.Location = new Point(461, 205);
            miningTotal.Name = "miningTotal";
            miningTotal.Size = new Size(72, 15);
            miningTotal.TabIndex = 29;
            miningTotal.Text = "miningTotal";
            // 
            // magicTotal
            // 
            magicTotal.AutoSize = true;
            magicTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            magicTotal.Location = new Point(461, 169);
            magicTotal.Name = "magicTotal";
            magicTotal.Size = new Size(67, 15);
            magicTotal.TabIndex = 28;
            magicTotal.Text = "magicTotal";
            // 
            // rangedTotal
            // 
            rangedTotal.AutoSize = true;
            rangedTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rangedTotal.Location = new Point(461, 134);
            rangedTotal.Name = "rangedTotal";
            rangedTotal.Size = new Size(73, 15);
            rangedTotal.TabIndex = 27;
            rangedTotal.Text = "rangedTotal";
            // 
            // strengthTotal
            // 
            strengthTotal.AutoSize = true;
            strengthTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            strengthTotal.Location = new Point(461, 98);
            strengthTotal.Name = "strengthTotal";
            strengthTotal.Size = new Size(82, 15);
            strengthTotal.TabIndex = 26;
            strengthTotal.Text = "strengthTotal";
            // 
            // attackTotal
            // 
            attackTotal.AutoSize = true;
            attackTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            attackTotal.Location = new Point(461, 62);
            attackTotal.Name = "attackTotal";
            attackTotal.Size = new Size(69, 15);
            attackTotal.TabIndex = 25;
            attackTotal.Text = "attackTotal";
            // 
            // magicPrayers
            // 
            magicPrayers.DropDownStyle = ComboBoxStyle.DropDownList;
            magicPrayers.FormattingEnabled = true;
            magicPrayers.Items.AddRange(new object[] { "None", "5%", "10%", "15%", "Augury" });
            magicPrayers.Location = new Point(281, 166);
            magicPrayers.Name = "magicPrayers";
            magicPrayers.Size = new Size(155, 23);
            magicPrayers.TabIndex = 24;
            magicPrayers.SelectedIndexChanged += magicPrayers_SelectedIndexChanged;
            // 
            // rangedPrayers
            // 
            rangedPrayers.DropDownStyle = ComboBoxStyle.DropDownList;
            rangedPrayers.FormattingEnabled = true;
            rangedPrayers.Items.AddRange(new object[] { "None", "5%", "10%", "15%", "Rigour" });
            rangedPrayers.Location = new Point(281, 131);
            rangedPrayers.Name = "rangedPrayers";
            rangedPrayers.Size = new Size(155, 23);
            rangedPrayers.TabIndex = 23;
            rangedPrayers.SelectedIndexChanged += rangedPrayers_SelectedIndexChanged;
            // 
            // strengthPrayers
            // 
            strengthPrayers.DropDownStyle = ComboBoxStyle.DropDownList;
            strengthPrayers.FormattingEnabled = true;
            strengthPrayers.Items.AddRange(new object[] { "None", "5%", "10%", "15%", "Chivalry", "Piety" });
            strengthPrayers.Location = new Point(281, 95);
            strengthPrayers.Name = "strengthPrayers";
            strengthPrayers.Size = new Size(155, 23);
            strengthPrayers.TabIndex = 22;
            strengthPrayers.SelectedIndexChanged += strengthPrayers_SelectedIndexChanged;
            // 
            // attackPrayers
            // 
            attackPrayers.DropDownStyle = ComboBoxStyle.DropDownList;
            attackPrayers.FormattingEnabled = true;
            attackPrayers.Items.AddRange(new object[] { "None", "5%", "10%", "15%", "Chivalry", "Piety" });
            attackPrayers.Location = new Point(281, 59);
            attackPrayers.Name = "attackPrayers";
            attackPrayers.Size = new Size(155, 23);
            attackPrayers.TabIndex = 21;
            attackPrayers.SelectedIndexChanged += attackPrayers_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 832);
            Controls.Add(statsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Padding = new Padding(10);
            Text = "OSRS DPS Calculator";
            ((System.ComponentModel.ISupportInitialize)attackLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)attackPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rangedPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)magicPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)miningPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)rangedLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)magicLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)miningLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)statsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)potionsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)prayersPictureBox).EndInit();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown attackLevel;
        private PictureBox attackPictureBox;
        private PictureBox strengthPictureBox;
        private PictureBox rangedPictureBox;
        private PictureBox magicPictureBox;
        private PictureBox miningPictureBox;
        private NumericUpDown strengthLevel;
        private NumericUpDown rangedLevel;
        private NumericUpDown magicLevel;
        private NumericUpDown miningLevel;
        private PictureBox statsPictureBox;
        private PictureBox potionsPictureBox;
        private PictureBox prayersPictureBox;
        private ComboBox attackPotions;
        private ComboBox strengthPotions;
        private ComboBox rangedPotions;
        private ComboBox magicPotions;
        private ComboBox miningPotions;
        private Panel statsPanel;
        private ComboBox magicPrayers;
        private ComboBox rangedPrayers;
        private ComboBox strengthPrayers;
        private ComboBox attackPrayers;
        private Label attackTotal;
        private Label miningTotal;
        private Label magicTotal;
        private Label rangedTotal;
        private Label strengthTotal;
    }

}
