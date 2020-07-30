namespace Money_Tracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Income = new System.Windows.Forms.RadioButton();
            this.Payment = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transAmountBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Money_Tracker.DataSet1();
            this.moneyTrackerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyTrackerTableAdapter = new Money_Tracker.DataSet1TableAdapters.MoneyTrackerTableAdapter();
            this.transctionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(16, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "My Transaction";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(740, 218);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 47);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transctionValueDataGridViewTextBoxColumn,
            this.describtionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.transTypeDataGridViewCheckBoxColumn});
            this.dataGridView.DataSource = this.moneyTrackerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 271);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(859, 242);
            this.dataGridView.TabIndex = 20;
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income.Location = new System.Drawing.Point(581, 204);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(78, 22);
            this.Income.TabIndex = 19;
            this.Income.TabStop = true;
            this.Income.Text = "Income";
            this.Income.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Checked = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(448, 204);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(87, 22);
            this.Payment.TabIndex = 18;
            this.Payment.TabStop = true;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(42, 204);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(291, 24);
            this.dateTime.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(42, 108);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(446, 62);
            this.DescriptionBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transction Amount";
            // 
            // transAmountBox
            // 
            this.transAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transAmountBox.Location = new System.Drawing.Point(42, 41);
            this.transAmountBox.Name = "transAmountBox";
            this.transAmountBox.Size = new System.Drawing.Size(446, 30);
            this.transAmountBox.TabIndex = 12;
            this.transAmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transAmountBox_KeyPress);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyTrackerBindingSource
            // 
            this.moneyTrackerBindingSource.DataMember = "MoneyTracker";
            this.moneyTrackerBindingSource.DataSource = this.dataSet1;
            // 
            // moneyTrackerTableAdapter
            // 
            this.moneyTrackerTableAdapter.ClearBeforeFill = true;
            // 
            // transctionValueDataGridViewTextBoxColumn
            // 
            this.transctionValueDataGridViewTextBoxColumn.DataPropertyName = "transctionValue";
            this.transctionValueDataGridViewTextBoxColumn.HeaderText = "transctionValue";
            this.transctionValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transctionValueDataGridViewTextBoxColumn.Name = "transctionValueDataGridViewTextBoxColumn";
            this.transctionValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // describtionDataGridViewTextBoxColumn
            // 
            this.describtionDataGridViewTextBoxColumn.DataPropertyName = "Describtion";
            this.describtionDataGridViewTextBoxColumn.HeaderText = "Describtion";
            this.describtionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.describtionDataGridViewTextBoxColumn.Name = "describtionDataGridViewTextBoxColumn";
            this.describtionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transTypeDataGridViewCheckBoxColumn
            // 
            this.transTypeDataGridViewCheckBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.transTypeDataGridViewCheckBoxColumn.Name = "transTypeDataGridViewCheckBoxColumn";
            this.transTypeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transAmountBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton Income;
        private System.Windows.Forms.RadioButton Payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transAmountBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource moneyTrackerBindingSource;
        private DataSet1TableAdapters.MoneyTrackerTableAdapter moneyTrackerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transctionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn describtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTypeDataGridViewCheckBoxColumn;
    }
}