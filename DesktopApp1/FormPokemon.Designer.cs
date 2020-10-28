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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelFP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateFP
            // 
            this.buttonUpdateFP.Location = new System.Drawing.Point(29, 185);
            this.buttonUpdateFP.Name = "buttonUpdateFP";
            this.buttonUpdateFP.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateFP.TabIndex = 112;
            this.buttonUpdateFP.Text = "Update";
            this.buttonUpdateFP.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLevelFP
            // 
            this.numericUpDownLevelFP.Location = new System.Drawing.Point(170, 139);
            this.numericUpDownLevelFP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevelFP.Name = "numericUpDownLevelFP";
            this.numericUpDownLevelFP.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLevelFP.TabIndex = 111;
            this.numericUpDownLevelFP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxNicknameFP
            // 
            this.textBoxNicknameFP.Location = new System.Drawing.Point(29, 65);
            this.textBoxNicknameFP.Name = "textBoxNicknameFP";
            this.textBoxNicknameFP.Size = new System.Drawing.Size(261, 20);
            this.textBoxNicknameFP.TabIndex = 109;
            this.textBoxNicknameFP.Text = "Nickname";
            // 
            // textBoxTypeFP
            // 
            this.textBoxTypeFP.Location = new System.Drawing.Point(29, 101);
            this.textBoxTypeFP.Name = "textBoxTypeFP";
            this.textBoxTypeFP.Size = new System.Drawing.Size(261, 20);
            this.textBoxTypeFP.TabIndex = 108;
            this.textBoxTypeFP.Text = "Type";
            // 
            // textBoxNameFP
            // 
            this.textBoxNameFP.Location = new System.Drawing.Point(29, 30);
            this.textBoxNameFP.Name = "textBoxNameFP";
            this.textBoxNameFP.Size = new System.Drawing.Size(261, 20);
            this.textBoxNameFP.TabIndex = 107;
            this.textBoxNameFP.Text = "Name";
            // 
            // btnRemoveFP
            // 
            this.btnRemoveFP.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveFP.Location = new System.Drawing.Point(170, 185);
            this.btnRemoveFP.Name = "btnRemoveFP";
            this.btnRemoveFP.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFP.TabIndex = 113;
            this.btnRemoveFP.Text = "Update";
            this.btnRemoveFP.UseVisualStyleBackColor = true;
            // 
            // textBoxTrainerId
            // 
            this.textBoxTrainerId.Location = new System.Drawing.Point(29, 138);
            this.textBoxTrainerId.Name = "textBoxTrainerId";
            this.textBoxTrainerId.Size = new System.Drawing.Size(126, 20);
            this.textBoxTrainerId.TabIndex = 114;
            this.textBoxTrainerId.Text = "Trainer";
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(322, 280);
            this.Controls.Add(this.textBoxTrainerId);
            this.Controls.Add(this.btnRemoveFP);
            this.Controls.Add(this.buttonUpdateFP);
            this.Controls.Add(this.numericUpDownLevelFP);
            this.Controls.Add(this.textBoxNicknameFP);
            this.Controls.Add(this.textBoxTypeFP);
            this.Controls.Add(this.textBoxNameFP);
            this.Name = "FormPokemon";
            this.Text = "FormPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateFP;
        private System.Windows.Forms.Button btnRemoveFP;
        public System.Windows.Forms.NumericUpDown numericUpDownLevelFP;
        public System.Windows.Forms.TextBox textBoxNicknameFP;
        public System.Windows.Forms.TextBox textBoxTypeFP;
        public System.Windows.Forms.TextBox textBoxNameFP;
        public System.Windows.Forms.TextBox textBoxTrainerId;
    }
}