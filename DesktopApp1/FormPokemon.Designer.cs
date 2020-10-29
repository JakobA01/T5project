namespace DesktopApp1
{
    partial class FormPokemon
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
            this.buttonUpdateFP = new System.Windows.Forms.Button();
            this.numericUpDownLevelFP = new System.Windows.Forms.NumericUpDown();
            this.textBoxNicknameFP = new System.Windows.Forms.TextBox();
            this.textBoxTypeFP = new System.Windows.Forms.TextBox();
            this.textBoxNameFP = new System.Windows.Forms.TextBox();
            this.btnRemoveFP = new System.Windows.Forms.Button();
            this.textBoxTrainerId = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTrainer = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textBoxPidFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelFP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateFP
            // 
            this.buttonUpdateFP.Location = new System.Drawing.Point(46, 195);
            this.buttonUpdateFP.Name = "buttonUpdateFP";
            this.buttonUpdateFP.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateFP.TabIndex = 112;
            this.buttonUpdateFP.Text = "Update";
            this.buttonUpdateFP.UseVisualStyleBackColor = true;
            this.buttonUpdateFP.Click += new System.EventHandler(this.ButtonUpdateFP_Click);
            // 
            // numericUpDownLevelFP
            // 
            this.numericUpDownLevelFP.Location = new System.Drawing.Point(82, 155);
            this.numericUpDownLevelFP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevelFP.Name = "numericUpDownLevelFP";
            this.numericUpDownLevelFP.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownLevelFP.TabIndex = 111;
            this.numericUpDownLevelFP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxNicknameFP
            // 
            this.textBoxNicknameFP.Location = new System.Drawing.Point(82, 77);
            this.textBoxNicknameFP.Name = "textBoxNicknameFP";
            this.textBoxNicknameFP.Size = new System.Drawing.Size(153, 20);
            this.textBoxNicknameFP.TabIndex = 109;
            this.textBoxNicknameFP.Text = "Nickname";
            // 
            // textBoxTypeFP
            // 
            this.textBoxTypeFP.Location = new System.Drawing.Point(82, 103);
            this.textBoxTypeFP.Name = "textBoxTypeFP";
            this.textBoxTypeFP.Size = new System.Drawing.Size(153, 20);
            this.textBoxTypeFP.TabIndex = 108;
            this.textBoxTypeFP.Text = "Type";
            // 
            // textBoxNameFP
            // 
            this.textBoxNameFP.Location = new System.Drawing.Point(82, 51);
            this.textBoxNameFP.Name = "textBoxNameFP";
            this.textBoxNameFP.Size = new System.Drawing.Size(153, 20);
            this.textBoxNameFP.TabIndex = 107;
            this.textBoxNameFP.Text = "Name";
            // 
            // btnRemoveFP
            // 
            this.btnRemoveFP.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveFP.Location = new System.Drawing.Point(148, 195);
            this.btnRemoveFP.Name = "btnRemoveFP";
            this.btnRemoveFP.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFP.TabIndex = 113;
            this.btnRemoveFP.Text = "Remove";
            this.btnRemoveFP.UseVisualStyleBackColor = true;
            this.btnRemoveFP.Click += new System.EventHandler(this.BtnRemoveFP_Click);
            // 
            // textBoxTrainerId
            // 
            this.textBoxTrainerId.Location = new System.Drawing.Point(82, 129);
            this.textBoxTrainerId.Name = "textBoxTrainerId";
            this.textBoxTrainerId.ReadOnly = true;
            this.textBoxTrainerId.Size = new System.Drawing.Size(153, 20);
            this.textBoxTrainerId.TabIndex = 114;
            this.textBoxTrainerId.Text = "Trainer";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(12, 80);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(55, 13);
            this.labelNickname.TabIndex = 115;
            this.labelNickname.Text = "Nickname";
            this.labelNickname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 103);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 116;
            this.labelType.Text = "Type";
            this.labelType.Click += new System.EventHandler(this.LabelType_Click);
            // 
            // labelTrainer
            // 
            this.labelTrainer.AutoSize = true;
            this.labelTrainer.Location = new System.Drawing.Point(12, 129);
            this.labelTrainer.Name = "labelTrainer";
            this.labelTrainer.Size = new System.Drawing.Size(40, 13);
            this.labelTrainer.TabIndex = 117;
            this.labelTrainer.Text = "Trainer";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 157);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 118;
            this.labelLevel.Text = "Level";
            // 
            // textBoxPidFP
            // 
            this.textBoxPidFP.Location = new System.Drawing.Point(82, 25);
            this.textBoxPidFP.Name = "textBoxPidFP";
            this.textBoxPidFP.ReadOnly = true;
            this.textBoxPidFP.Size = new System.Drawing.Size(153, 20);
            this.textBoxPidFP.TabIndex = 119;
            this.textBoxPidFP.Text = "pId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Pokémon Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Nickname";
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(267, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPidFP);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelTrainer);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.textBoxTrainerId);
            this.Controls.Add(this.btnRemoveFP);
            this.Controls.Add(this.buttonUpdateFP);
            this.Controls.Add(this.numericUpDownLevelFP);
            this.Controls.Add(this.textBoxNicknameFP);
            this.Controls.Add(this.textBoxTypeFP);
            this.Controls.Add(this.textBoxNameFP);
            this.Name = "FormPokemon";
            this.Text = "FormPokemon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPokemon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveFP;
        public System.Windows.Forms.NumericUpDown numericUpDownLevelFP;
        public System.Windows.Forms.TextBox textBoxNicknameFP;
        public System.Windows.Forms.TextBox textBoxTypeFP;
        public System.Windows.Forms.TextBox textBoxNameFP;
        public System.Windows.Forms.TextBox textBoxTrainerId;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTrainer;
        private System.Windows.Forms.Label labelLevel;
        public System.Windows.Forms.TextBox textBoxPidFP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonUpdateFP;
    }
}