namespace ExemplosDataGridView
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
            this.btnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChecks = new System.Windows.Forms.Button();
            this.btnComboBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(32, 279);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Botões";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 218);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnChecks
            // 
            this.btnChecks.Location = new System.Drawing.Point(123, 279);
            this.btnChecks.Name = "btnChecks";
            this.btnChecks.Size = new System.Drawing.Size(75, 23);
            this.btnChecks.TabIndex = 2;
            this.btnChecks.Text = "CheckBoxes";
            this.btnChecks.UseVisualStyleBackColor = true;
            this.btnChecks.Click += new System.EventHandler(this.btnChecks_Click);
            // 
            // btnComboBoxes
            // 
            this.btnComboBoxes.Location = new System.Drawing.Point(214, 279);
            this.btnComboBoxes.Name = "btnComboBoxes";
            this.btnComboBoxes.Size = new System.Drawing.Size(92, 23);
            this.btnComboBoxes.TabIndex = 3;
            this.btnComboBoxes.Text = "ComboBoxes";
            this.btnComboBoxes.UseVisualStyleBackColor = true;
            this.btnComboBoxes.Click += new System.EventHandler(this.btnComboBoxes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 454);
            this.Controls.Add(this.btnComboBoxes);
            this.Controls.Add(this.btnChecks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "Exemplos DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChecks;
        private System.Windows.Forms.Button btnComboBoxes;
    }
}

