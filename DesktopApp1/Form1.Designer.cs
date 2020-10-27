namespace DesktopApp1
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioBtnPokemon = new System.Windows.Forms.RadioButton();
            this.radioBtnTrainer = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTrainer = new System.Windows.Forms.ComboBox();
            this.buttonTestTrainer = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.radioBtnSearchTrainer = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchPokemon = new System.Windows.Forms.RadioButton();
            this.panelRadioBtnSearch = new System.Windows.Forms.Panel();
            this.panelRadioBtn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.panelRadioBtnSearch.SuspendLayout();
            this.panelRadioBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(789, 200);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(97, 39);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 244);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(853, 263);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Text = "Name";
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(53, 107);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(261, 20);
            this.textBoxType.TabIndex = 6;
            this.textBoxType.Text = "Type";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(53, 71);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(261, 20);
            this.textBoxNickname.TabIndex = 7;
            this.textBoxNickname.Text = "Nickname";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(619, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(160, 20);
            this.textBox5.TabIndex = 8;
            // 
            // radioBtnPokemon
            // 
            this.radioBtnPokemon.AutoSize = true;
            this.radioBtnPokemon.Checked = true;
            this.radioBtnPokemon.Location = new System.Drawing.Point(16, 3);
            this.radioBtnPokemon.Name = "radioBtnPokemon";
            this.radioBtnPokemon.Size = new System.Drawing.Size(70, 17);
            this.radioBtnPokemon.TabIndex = 9;
            this.radioBtnPokemon.TabStop = true;
            this.radioBtnPokemon.Text = "Pokémon";
            this.radioBtnPokemon.UseVisualStyleBackColor = true;
            // 
            // radioBtnTrainer
            // 
            this.radioBtnTrainer.AutoSize = true;
            this.radioBtnTrainer.Location = new System.Drawing.Point(104, 3);
            this.radioBtnTrainer.Name = "radioBtnTrainer";
            this.radioBtnTrainer.Size = new System.Drawing.Size(58, 17);
            this.radioBtnTrainer.TabIndex = 10;
            this.radioBtnTrainer.Text = "Trainer";
            this.radioBtnTrainer.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(218, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 28);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(194, 145);
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLevel.TabIndex = 100;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxTrainer
            // 
            this.comboBoxTrainer.FormattingEnabled = true;
            this.comboBoxTrainer.Location = new System.Drawing.Point(53, 144);
            this.comboBoxTrainer.Name = "comboBoxTrainer";
            this.comboBoxTrainer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrainer.TabIndex = 13;
            this.comboBoxTrainer.Text = "TrainerId";
            this.comboBoxTrainer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTId_SelectedIndexChanged);
            // 
            // buttonTestTrainer
            // 
            this.buttonTestTrainer.Location = new System.Drawing.Point(441, 107);
            this.buttonTestTrainer.Name = "buttonTestTrainer";
            this.buttonTestTrainer.Size = new System.Drawing.Size(197, 22);
            this.buttonTestTrainer.TabIndex = 101;
            this.buttonTestTrainer.Text = "testopen trainer";
            this.buttonTestTrainer.UseVisualStyleBackColor = true;
            this.buttonTestTrainer.Click += new System.EventHandler(this.ButtonTestTrainer_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.ForeColor = System.Drawing.Color.Red;
            this.buttonRemove.Location = new System.Drawing.Point(789, 513);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(96, 28);
            this.buttonRemove.TabIndex = 103;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(683, 513);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 28);
            this.buttonUpdate.TabIndex = 104;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // radioBtnSearchTrainer
            // 
            this.radioBtnSearchTrainer.AutoSize = true;
            this.radioBtnSearchTrainer.Location = new System.Drawing.Point(102, 0);
            this.radioBtnSearchTrainer.Name = "radioBtnSearchTrainer";
            this.radioBtnSearchTrainer.Size = new System.Drawing.Size(58, 17);
            this.radioBtnSearchTrainer.TabIndex = 106;
            this.radioBtnSearchTrainer.Text = "Trainer";
            this.radioBtnSearchTrainer.UseVisualStyleBackColor = true;
            // 
            // radioBtnSearchPokemon
            // 
            this.radioBtnSearchPokemon.AutoSize = true;
            this.radioBtnSearchPokemon.Location = new System.Drawing.Point(0, -2);
            this.radioBtnSearchPokemon.Name = "radioBtnSearchPokemon";
            this.radioBtnSearchPokemon.Size = new System.Drawing.Size(70, 17);
            this.radioBtnSearchPokemon.TabIndex = 105;
            this.radioBtnSearchPokemon.Text = "Pokémon";
            this.radioBtnSearchPokemon.UseVisualStyleBackColor = true;
            // 
            // panelRadioBtnSearch
            // 
            this.panelRadioBtnSearch.Controls.Add(this.radioBtnSearchPokemon);
            this.panelRadioBtnSearch.Controls.Add(this.radioBtnSearchTrainer);
            this.panelRadioBtnSearch.Location = new System.Drawing.Point(619, 226);
            this.panelRadioBtnSearch.Name = "panelRadioBtnSearch";
            this.panelRadioBtnSearch.Size = new System.Drawing.Size(165, 18);
            this.panelRadioBtnSearch.TabIndex = 109;
            // 
            // panelRadioBtn
            // 
            this.panelRadioBtn.Controls.Add(this.radioBtnPokemon);
            this.panelRadioBtn.Controls.Add(this.radioBtnTrainer);
            this.panelRadioBtn.Location = new System.Drawing.Point(46, 180);
            this.panelRadioBtn.Name = "panelRadioBtn";
            this.panelRadioBtn.Size = new System.Drawing.Size(166, 30);
            this.panelRadioBtn.TabIndex = 107;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 545);
            this.Controls.Add(this.panelRadioBtn);
            this.Controls.Add(this.panelRadioBtnSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonTestTrainer);
            this.Controls.Add(this.comboBoxTrainer);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.panelRadioBtnSearch.ResumeLayout(false);
            this.panelRadioBtnSearch.PerformLayout();
            this.panelRadioBtn.ResumeLayout(false);
            this.panelRadioBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioBtnPokemon;
        private System.Windows.Forms.RadioButton radioBtnTrainer;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.ComboBox comboBoxTrainer;
        private System.Windows.Forms.Button buttonTestTrainer;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RadioButton radioBtnSearchTrainer;
        private System.Windows.Forms.RadioButton radioBtnSearchPokemon;
        private System.Windows.Forms.Panel panelRadioBtnSearch;
        private System.Windows.Forms.Panel panelRadioBtn;
    }
}

