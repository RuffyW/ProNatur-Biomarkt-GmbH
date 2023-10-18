namespace ProNatur_Biomarkt_GmbH
{
    partial class BillScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Empfänger = new System.Windows.Forms.TextBox();
            this.Billtext = new System.Windows.Forms.Label();
            this.textBox_BillText = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.DGV_Bills = new System.Windows.Forms.DataGridView();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.ForeColor = System.Drawing.Color.White;
            this.textBox_ID.Location = new System.Drawing.Point(102, 23);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(237, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(12, 26);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empfänger";
            // 
            // textBox_Empfänger
            // 
            this.textBox_Empfänger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox_Empfänger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Empfänger.ForeColor = System.Drawing.Color.White;
            this.textBox_Empfänger.Location = new System.Drawing.Point(102, 49);
            this.textBox_Empfänger.Name = "textBox_Empfänger";
            this.textBox_Empfänger.Size = new System.Drawing.Size(237, 20);
            this.textBox_Empfänger.TabIndex = 2;
            // 
            // Billtext
            // 
            this.Billtext.AutoSize = true;
            this.Billtext.ForeColor = System.Drawing.Color.White;
            this.Billtext.Location = new System.Drawing.Point(12, 78);
            this.Billtext.Name = "Billtext";
            this.Billtext.Size = new System.Drawing.Size(50, 13);
            this.Billtext.TabIndex = 5;
            this.Billtext.Text = "Produkte";
            // 
            // textBox_BillText
            // 
            this.textBox_BillText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox_BillText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_BillText.ForeColor = System.Drawing.Color.White;
            this.textBox_BillText.Location = new System.Drawing.Point(102, 75);
            this.textBox_BillText.Name = "textBox_BillText";
            this.textBox_BillText.Size = new System.Drawing.Size(237, 20);
            this.textBox_BillText.TabIndex = 4;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.ForeColor = System.Drawing.Color.White;
            this.TotalPrice.Location = new System.Drawing.Point(12, 104);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(30, 13);
            this.TotalPrice.TabIndex = 7;
            this.TotalPrice.Text = "Preis";
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Price.ForeColor = System.Drawing.Color.White;
            this.textBox_Price.Location = new System.Drawing.Point(102, 101);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(95, 20);
            this.textBox_Price.TabIndex = 6;
            // 
            // DGV_Bills
            // 
            this.DGV_Bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Bills.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Bills.Location = new System.Drawing.Point(12, 156);
            this.DGV_Bills.MultiSelect = false;
            this.DGV_Bills.Name = "DGV_Bills";
            this.DGV_Bills.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = null;
            this.DGV_Bills.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Bills.RowTemplate.ReadOnly = true;
            this.DGV_Bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Bills.Size = new System.Drawing.Size(776, 282);
            this.DGV_Bills.TabIndex = 8;
            this.DGV_Bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Bills_CellContentClick);
            // 
            // btn_Create
            // 
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(102, 127);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Erstellen";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(183, 127);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Bearbeiten";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(264, 127);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Löschen";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(345, 127);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Feld leeren";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.DGV_Bills);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.Billtext);
            this.Controls.Add(this.textBox_BillText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Empfänger);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox_ID);
            this.Name = "BillScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillScreen";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Empfänger;
        private System.Windows.Forms.Label Billtext;
        private System.Windows.Forms.TextBox textBox_BillText;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.DataGridView DGV_Bills;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
    }
}