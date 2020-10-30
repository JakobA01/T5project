namespace DesktopApp1
{
    partial class FormBattle
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
            this.lblYou = new System.Windows.Forms.Label();
            this.lblYourOpponent = new System.Windows.Forms.Label();
            this.lblAttack1 = new System.Windows.Forms.Label();
            this.lblAttack3 = new System.Windows.Forms.Label();
            this.lblAttack2 = new System.Windows.Forms.Label();
            this.lblAttack4 = new System.Windows.Forms.Label();
            this.progressBarYou = new System.Windows.Forms.ProgressBar();
            this.lblYourHP = new System.Windows.Forms.Label();
            this.progressBarOpponent = new System.Windows.Forms.ProgressBar();
            this.lblOpponentHP = new System.Windows.Forms.Label();
            this.lblYourPokemon = new System.Windows.Forms.Label();
            this.lblYourPokemonLvl = new System.Windows.Forms.Label();
            this.lblOpponentPokemon = new System.Windows.Forms.Label();
            this.lblOpponentPokemonLvl = new System.Windows.Forms.Label();
            this.lblBattleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(12, 9);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(85, 46);
            this.lblYou.TabIndex = 0;
            this.lblYou.Text = "You";
            // 
            // lblYourOpponent
            // 
            this.lblYourOpponent.AutoSize = true;
            this.lblYourOpponent.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOpponent.Location = new System.Drawing.Point(515, 9);
            this.lblYourOpponent.Name = "lblYourOpponent";
            this.lblYourOpponent.Size = new System.Drawing.Size(273, 46);
            this.lblYourOpponent.TabIndex = 1;
            this.lblYourOpponent.Text = "Your opponent";
            // 
            // lblAttack1
            // 
            this.lblAttack1.AutoSize = true;
            this.lblAttack1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttack1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack1.Location = new System.Drawing.Point(17, 254);
            this.lblAttack1.Name = "lblAttack1";
            this.lblAttack1.Size = new System.Drawing.Size(106, 23);
            this.lblAttack1.TabIndex = 2;
            this.lblAttack1.Text = "Thunderbolt";
            this.lblAttack1.Click += new System.EventHandler(this.LblAttack1_Click);
            // 
            // lblAttack3
            // 
            this.lblAttack3.AutoSize = true;
            this.lblAttack3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttack3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack3.Location = new System.Drawing.Point(17, 343);
            this.lblAttack3.Name = "lblAttack3";
            this.lblAttack3.Size = new System.Drawing.Size(113, 21);
            this.lblAttack3.TabIndex = 3;
            this.lblAttack3.Text = "Electric shock";
            this.lblAttack3.Click += new System.EventHandler(this.LblAttack3_Click);
            // 
            // lblAttack2
            // 
            this.lblAttack2.AutoSize = true;
            this.lblAttack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttack2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack2.Location = new System.Drawing.Point(17, 300);
            this.lblAttack2.Name = "lblAttack2";
            this.lblAttack2.Size = new System.Drawing.Size(106, 21);
            this.lblAttack2.TabIndex = 4;
            this.lblAttack2.Text = "Quick attack";
            this.lblAttack2.Click += new System.EventHandler(this.LblAttack2_Click);
            // 
            // lblAttack4
            // 
            this.lblAttack4.AutoSize = true;
            this.lblAttack4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttack4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack4.Location = new System.Drawing.Point(17, 383);
            this.lblAttack4.Name = "lblAttack4";
            this.lblAttack4.Size = new System.Drawing.Size(66, 21);
            this.lblAttack4.TabIndex = 5;
            this.lblAttack4.Text = "Harden";
            this.lblAttack4.Click += new System.EventHandler(this.LblAttack4_Click);
            // 
            // progressBarYou
            // 
            this.progressBarYou.BackColor = System.Drawing.Color.ForestGreen;
            this.progressBarYou.ForeColor = System.Drawing.Color.Black;
            this.progressBarYou.Location = new System.Drawing.Point(17, 159);
            this.progressBarYou.Name = "progressBarYou";
            this.progressBarYou.Size = new System.Drawing.Size(100, 23);
            this.progressBarYou.TabIndex = 6;
            // 
            // lblYourHP
            // 
            this.lblYourHP.AutoSize = true;
            this.lblYourHP.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourHP.Location = new System.Drawing.Point(18, 197);
            this.lblYourHP.Name = "lblYourHP";
            this.lblYourHP.Size = new System.Drawing.Size(45, 16);
            this.lblYourHP.TabIndex = 7;
            this.lblYourHP.Text = "label1";
            // 
            // progressBarOpponent
            // 
            this.progressBarOpponent.BackColor = System.Drawing.Color.ForestGreen;
            this.progressBarOpponent.ForeColor = System.Drawing.Color.Black;
            this.progressBarOpponent.Location = new System.Drawing.Point(523, 159);
            this.progressBarOpponent.Name = "progressBarOpponent";
            this.progressBarOpponent.Size = new System.Drawing.Size(100, 23);
            this.progressBarOpponent.TabIndex = 8;
            // 
            // lblOpponentHP
            // 
            this.lblOpponentHP.AutoSize = true;
            this.lblOpponentHP.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHP.Location = new System.Drawing.Point(523, 197);
            this.lblOpponentHP.Name = "lblOpponentHP";
            this.lblOpponentHP.Size = new System.Drawing.Size(45, 16);
            this.lblOpponentHP.TabIndex = 9;
            this.lblOpponentHP.Text = "label1";
            // 
            // lblYourPokemon
            // 
            this.lblYourPokemon.AutoSize = true;
            this.lblYourPokemon.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPokemon.Location = new System.Drawing.Point(18, 91);
            this.lblYourPokemon.Name = "lblYourPokemon";
            this.lblYourPokemon.Size = new System.Drawing.Size(100, 25);
            this.lblYourPokemon.TabIndex = 10;
            this.lblYourPokemon.Text = "Pikachu";
            // 
            // lblYourPokemonLvl
            // 
            this.lblYourPokemonLvl.AutoSize = true;
            this.lblYourPokemonLvl.Location = new System.Drawing.Point(24, 116);
            this.lblYourPokemonLvl.Name = "lblYourPokemonLvl";
            this.lblYourPokemonLvl.Size = new System.Drawing.Size(39, 13);
            this.lblYourPokemonLvl.TabIndex = 11;
            this.lblYourPokemonLvl.Text = "Lvl: 25";
            // 
            // lblOpponentPokemon
            // 
            this.lblOpponentPokemon.AutoSize = true;
            this.lblOpponentPokemon.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentPokemon.Location = new System.Drawing.Point(518, 91);
            this.lblOpponentPokemon.Name = "lblOpponentPokemon";
            this.lblOpponentPokemon.Size = new System.Drawing.Size(111, 25);
            this.lblOpponentPokemon.TabIndex = 12;
            this.lblOpponentPokemon.Text = "Machoke";
            // 
            // lblOpponentPokemonLvl
            // 
            this.lblOpponentPokemonLvl.AutoSize = true;
            this.lblOpponentPokemonLvl.Location = new System.Drawing.Point(529, 116);
            this.lblOpponentPokemonLvl.Name = "lblOpponentPokemonLvl";
            this.lblOpponentPokemonLvl.Size = new System.Drawing.Size(39, 13);
            this.lblOpponentPokemonLvl.TabIndex = 13;
            this.lblOpponentPokemonLvl.Text = "Lvl: 25";
            // 
            // lblBattleText
            // 
            this.lblBattleText.AutoSize = true;
            this.lblBattleText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleText.Location = new System.Drawing.Point(232, 254);
            this.lblBattleText.Name = "lblBattleText";
            this.lblBattleText.Size = new System.Drawing.Size(58, 18);
            this.lblBattleText.TabIndex = 14;
            this.lblBattleText.Text = "label1";
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBattleText);
            this.Controls.Add(this.lblOpponentPokemonLvl);
            this.Controls.Add(this.lblOpponentPokemon);
            this.Controls.Add(this.lblYourPokemonLvl);
            this.Controls.Add(this.lblYourPokemon);
            this.Controls.Add(this.lblOpponentHP);
            this.Controls.Add(this.progressBarOpponent);
            this.Controls.Add(this.lblYourHP);
            this.Controls.Add(this.progressBarYou);
            this.Controls.Add(this.lblAttack4);
            this.Controls.Add(this.lblAttack2);
            this.Controls.Add(this.lblAttack3);
            this.Controls.Add(this.lblAttack1);
            this.Controls.Add(this.lblYourOpponent);
            this.Controls.Add(this.lblYou);
            this.Name = "FormBattle";
            this.Text = "FormBattle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblYou;
        public System.Windows.Forms.Label lblYourOpponent;
        public System.Windows.Forms.Label lblAttack1;
        public System.Windows.Forms.Label lblAttack3;
        public System.Windows.Forms.Label lblAttack2;
        public System.Windows.Forms.Label lblAttack4;
        public System.Windows.Forms.ProgressBar progressBarYou;
        public System.Windows.Forms.Label lblYourHP;
        public System.Windows.Forms.ProgressBar progressBarOpponent;
        public System.Windows.Forms.Label lblOpponentHP;
        public System.Windows.Forms.Label lblYourPokemon;
        public System.Windows.Forms.Label lblYourPokemonLvl;
        public System.Windows.Forms.Label lblOpponentPokemon;
        public System.Windows.Forms.Label lblOpponentPokemonLvl;
        public System.Windows.Forms.Label lblBattleText;
    }
}