namespace DesktopApp1
{
    partial class AddPokemonToTrainer
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
            this.dataGridViewAddPokemon = new System.Windows.Forms.DataGridView();
            this.btnAddToTrainer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddPokemon
            // 
            this.dataGridViewAddPokemon.AllowUserToAddRows = false;
            this.dataGridViewAddPokemon.AllowUserToDeleteRows = false;
            this.dataGridViewAddPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddPokemon.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAddPokemon.Name = "dataGridViewAddPokemon";
            this.dataGridViewAddPokemon.ReadOnly = true;
            this.dataGridViewAddPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddPokemon.Size = new System.Drawing.Size(775, 381);
            this.dataGridViewAddPokemon.TabIndex = 0;
            this.dataGridViewAddPokemon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddPokemon_CellDoubleClick);
            this.dataGridViewAddPokemon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewAddPokemon_DataBindingComplete_1);
            // 
            // btnAddToTrainer
            // 
            this.btnAddToTrainer.Location = new System.Drawing.Point(334, 415);
            this.btnAddToTrainer.Name = "btnAddToTrainer";
            this.btnAddToTrainer.Size = new System.Drawing.Size(153, 23);
            this.btnAddToTrainer.TabIndex = 1;
            this.btnAddToTrainer.Text = "Add to trainer";
            this.btnAddToTrainer.UseVisualStyleBackColor = true;
            this.btnAddToTrainer.Click += new System.EventHandler(this.BtnAddToTrainer_Click);
            // 
            // AddPokemonToTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToTrainer);
            this.Controls.Add(this.dataGridViewAddPokemon);
            this.Name = "AddPokemonToTrainer";
            this.Text = "AddPokemonToTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddToTrainer;
        public System.Windows.Forms.DataGridView dataGridViewAddPokemon;
    }
}