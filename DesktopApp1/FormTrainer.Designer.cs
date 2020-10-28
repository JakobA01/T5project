namespace DesktopApp1
{
    partial class FormTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrainer));
            this.buttonConfirmFT = new System.Windows.Forms.Button();
            this.numericUpDownNbrBadgesFT = new System.Windows.Forms.NumericUpDown();
            this.textBoxTrainerIdFT = new System.Windows.Forms.TextBox();
            this.textBoxNameFT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdateFT = new System.Windows.Forms.Button();
            this.buttonRemovePokemonFT = new System.Windows.Forms.Button();
            this.labeNbrOfBadges = new System.Windows.Forms.Label();
            this.buttonRemoveTrainerFT = new System.Windows.Forms.Button();
            this.buttonUpdateTrainerFT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTrainerId = new System.Windows.Forms.Label();
            this.labelTrainerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrBadgesFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmFT
            // 
            this.buttonConfirmFT.Location = new System.Drawing.Point(339, 326);
            this.buttonConfirmFT.Name = "buttonConfirmFT";
            this.buttonConfirmFT.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmFT.TabIndex = 118;
            this.buttonConfirmFT.Text = "Add";
            this.buttonConfirmFT.UseVisualStyleBackColor = true;
            this.buttonConfirmFT.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // numericUpDownNbrBadgesFT
            // 
            this.numericUpDownNbrBadgesFT.Location = new System.Drawing.Point(57, 119);
            this.numericUpDownNbrBadgesFT.Name = "numericUpDownNbrBadgesFT";
            this.numericUpDownNbrBadgesFT.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownNbrBadgesFT.TabIndex = 117;
            this.numericUpDownNbrBadgesFT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxTrainerIdFT
            // 
            this.textBoxTrainerIdFT.Location = new System.Drawing.Point(57, 37);
            this.textBoxTrainerIdFT.Name = "textBoxTrainerIdFT";
            this.textBoxTrainerIdFT.ReadOnly = true;
            this.textBoxTrainerIdFT.Size = new System.Drawing.Size(92, 20);
            this.textBoxTrainerIdFT.TabIndex = 115;
            this.textBoxTrainerIdFT.Text = "TrainerId";
            this.textBoxTrainerIdFT.TextChanged += new System.EventHandler(this.TextBoxNickname_TextChanged);
            // 
            // textBoxNameFT
            // 
            this.textBoxNameFT.Location = new System.Drawing.Point(57, 82);
            this.textBoxNameFT.Name = "textBoxNameFT";
            this.textBoxNameFT.Size = new System.Drawing.Size(92, 20);
            this.textBoxNameFT.TabIndex = 113;
            this.textBoxNameFT.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(286, 295);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // buttonUpdateFT
            // 
            this.buttonUpdateFT.Location = new System.Drawing.Point(420, 326);
            this.buttonUpdateFT.Name = "buttonUpdateFT";
            this.buttonUpdateFT.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateFT.TabIndex = 120;
            this.buttonUpdateFT.Text = "Update";
            this.buttonUpdateFT.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePokemonFT
            // 
            this.buttonRemovePokemonFT.ForeColor = System.Drawing.Color.Red;
            this.buttonRemovePokemonFT.Location = new System.Drawing.Point(501, 326);
            this.buttonRemovePokemonFT.Name = "buttonRemovePokemonFT";
            this.buttonRemovePokemonFT.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePokemonFT.TabIndex = 121;
            this.buttonRemovePokemonFT.Text = "Remove";
            this.buttonRemovePokemonFT.UseVisualStyleBackColor = true;
            this.buttonRemovePokemonFT.Click += new System.EventHandler(this.ButtonRemovePokemonFT_Click);
            // 
            // labeNbrOfBadges
            // 
            this.labeNbrOfBadges.AutoSize = true;
            this.labeNbrOfBadges.Location = new System.Drawing.Point(2, 119);
            this.labeNbrOfBadges.Name = "labeNbrOfBadges";
            this.labeNbrOfBadges.Size = new System.Drawing.Size(43, 13);
            this.labeNbrOfBadges.TabIndex = 123;
            this.labeNbrOfBadges.Text = "Badges";
            this.labeNbrOfBadges.Click += new System.EventHandler(this.Label2_Click);
            // 
            // buttonRemoveTrainerFT
            // 
            this.buttonRemoveTrainerFT.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveTrainerFT.Location = new System.Drawing.Point(150, 167);
            this.buttonRemoveTrainerFT.Name = "buttonRemoveTrainerFT";
            this.buttonRemoveTrainerFT.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTrainerFT.TabIndex = 124;
            this.buttonRemoveTrainerFT.Text = "Remove";
            this.buttonRemoveTrainerFT.UseVisualStyleBackColor = true;
            this.buttonRemoveTrainerFT.Click += new System.EventHandler(this.ButtonRemoveTrainerFT_Click);
            // 
            // buttonUpdateTrainerFT
            // 
            this.buttonUpdateTrainerFT.Location = new System.Drawing.Point(57, 167);
            this.buttonUpdateTrainerFT.Name = "buttonUpdateTrainerFT";
            this.buttonUpdateTrainerFT.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTrainerFT.TabIndex = 125;
            this.buttonUpdateTrainerFT.Text = "Update";
            this.buttonUpdateTrainerFT.UseVisualStyleBackColor = true;
            this.buttonUpdateTrainerFT.Click += new System.EventHandler(this.ButtonUpdateTrainerFT_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // labelTrainerId
            // 
            this.labelTrainerId.AutoSize = true;
            this.labelTrainerId.Location = new System.Drawing.Point(2, 40);
            this.labelTrainerId.Name = "labelTrainerId";
            this.labelTrainerId.Size = new System.Drawing.Size(49, 13);
            this.labelTrainerId.TabIndex = 127;
            this.labelTrainerId.Text = "TrainerId";
            this.labelTrainerId.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelTrainerName
            // 
            this.labelTrainerName.AutoSize = true;
            this.labelTrainerName.Location = new System.Drawing.Point(2, 85);
            this.labelTrainerName.Name = "labelTrainerName";
            this.labelTrainerName.Size = new System.Drawing.Size(35, 13);
            this.labelTrainerName.TabIndex = 128;
            this.labelTrainerName.Text = "Name";
            this.labelTrainerName.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // FormTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.labelTrainerName);
            this.Controls.Add(this.labelTrainerId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdateTrainerFT);
            this.Controls.Add(this.buttonRemoveTrainerFT);
            this.Controls.Add(this.labeNbrOfBadges);
            this.Controls.Add(this.buttonRemovePokemonFT);
            this.Controls.Add(this.buttonUpdateFT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConfirmFT);
            this.Controls.Add(this.numericUpDownNbrBadgesFT);
            this.Controls.Add(this.textBoxTrainerIdFT);
            this.Controls.Add(this.textBoxNameFT);
            this.Name = "FormTrainer";
            this.Text = "FormTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbrBadgesFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmFT;
        private System.Windows.Forms.Button buttonUpdateFT;
        private System.Windows.Forms.Button buttonRemovePokemonFT;
        private System.Windows.Forms.Label labeNbrOfBadges;
        private System.Windows.Forms.Button buttonRemoveTrainerFT;
        private System.Windows.Forms.Button buttonUpdateTrainerFT;
        public System.Windows.Forms.TextBox textBoxTrainerIdFT;
        public System.Windows.Forms.NumericUpDown numericUpDownNbrBadgesFT;
        public System.Windows.Forms.TextBox textBoxNameFT;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTrainerId;
        private System.Windows.Forms.Label labelTrainerName;
    }
}