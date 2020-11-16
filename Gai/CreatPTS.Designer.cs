namespace Gai
{
    partial class CreatPTS
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
            System.Windows.Forms.Label номерПтсLabel;
            System.Windows.Forms.Label серияПТСLabel;
            System.Windows.Forms.Label мощьностьДвигателяLabel;
            System.Windows.Forms.Label объемДвигателяLabel;
            this.databasegaiDataSet = new Gai.DatabasegaiDataSet();
            this.пТСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пТСTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.ПТСTableAdapter();
            this.tableAdapterManager = new Gai.DatabasegaiDataSetTableAdapters.TableAdapterManager();
            this.tabControl_PTS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.номерПтсTextBox = new System.Windows.Forms.TextBox();
            this.серияПТСTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.мощьностьДвигателяTextBox = new System.Windows.Forms.TextBox();
            this.объемДвигателяTextBox = new System.Windows.Forms.TextBox();
            номерПтсLabel = new System.Windows.Forms.Label();
            серияПТСLabel = new System.Windows.Forms.Label();
            мощьностьДвигателяLabel = new System.Windows.Forms.Label();
            объемДвигателяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСBindingSource)).BeginInit();
            this.tabControl_PTS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databasegaiDataSet
            // 
            this.databasegaiDataSet.DataSetName = "DatabasegaiDataSet";
            this.databasegaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пТСBindingSource
            // 
            this.пТСBindingSource.DataMember = "ПТС";
            this.пТСBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // пТСTableAdapter
            // 
            this.пТСTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gai.DatabasegaiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ДТПTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.ПраваTableAdapter = null;
            this.tableAdapterManager.ПТСTableAdapter = this.пТСTableAdapter;
            this.tableAdapterManager.РапортыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтраховкаTableAdapter = null;
            this.tableAdapterManager.СтсTableAdapter = null;
            // 
            // tabControl_PTS
            // 
            this.tabControl_PTS.Controls.Add(this.tabPage3);
            this.tabControl_PTS.Controls.Add(this.tabPage1);
            this.tabControl_PTS.Location = new System.Drawing.Point(12, 12);
            this.tabControl_PTS.Name = "tabControl_PTS";
            this.tabControl_PTS.SelectedIndex = 0;
            this.tabControl_PTS.Size = new System.Drawing.Size(776, 351);
            this.tabControl_PTS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авто";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(серияПТСLabel);
            this.tabPage3.Controls.Add(this.серияПТСTextBox);
            this.tabPage3.Controls.Add(номерПтсLabel);
            this.tabPage3.Controls.Add(this.номерПтсTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Документы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // номерПтсLabel
            // 
            номерПтсLabel.AutoSize = true;
            номерПтсLabel.Location = new System.Drawing.Point(4, 6);
            номерПтсLabel.Name = "номерПтсLabel";
            номерПтсLabel.Size = new System.Drawing.Size(66, 13);
            номерПтсLabel.TabIndex = 0;
            номерПтсLabel.Text = "Номер Птс:";
            // 
            // номерПтсTextBox
            // 
            this.номерПтсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пТСBindingSource, "НомерПтс", true));
            this.номерПтсTextBox.Location = new System.Drawing.Point(76, 3);
            this.номерПтсTextBox.Name = "номерПтсTextBox";
            this.номерПтсTextBox.Size = new System.Drawing.Size(100, 20);
            this.номерПтсTextBox.TabIndex = 1;
            // 
            // серияПТСLabel
            // 
            серияПТСLabel.AutoSize = true;
            серияПТСLabel.Location = new System.Drawing.Point(4, 32);
            серияПТСLabel.Name = "серияПТСLabel";
            серияПТСLabel.Size = new System.Drawing.Size(66, 13);
            серияПТСLabel.TabIndex = 2;
            серияПТСLabel.Text = "Серия ПТС:";
            // 
            // серияПТСTextBox
            // 
            this.серияПТСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пТСBindingSource, "СерияПТС", true));
            this.серияПТСTextBox.Location = new System.Drawing.Point(76, 29);
            this.серияПТСTextBox.Name = "серияПТСTextBox";
            this.серияПТСTextBox.Size = new System.Drawing.Size(100, 20);
            this.серияПТСTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(объемДвигателяLabel);
            this.groupBox1.Controls.Add(this.объемДвигателяTextBox);
            this.groupBox1.Controls.Add(мощьностьДвигателяLabel);
            this.groupBox1.Controls.Add(this.мощьностьДвигателяTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Двигатель";
            // 
            // мощьностьДвигателяLabel
            // 
            мощьностьДвигателяLabel.AutoSize = true;
            мощьностьДвигателяLabel.Location = new System.Drawing.Point(11, 22);
            мощьностьДвигателяLabel.Name = "мощьностьДвигателяLabel";
            мощьностьДвигателяLabel.Size = new System.Drawing.Size(72, 13);
            мощьностьДвигателяLabel.TabIndex = 0;
            мощьностьДвигателяLabel.Text = "Мощьность :";
            // 
            // мощьностьДвигателяTextBox
            // 
            this.мощьностьДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пТСBindingSource, "МощьностьДвигателя", true));
            this.мощьностьДвигателяTextBox.Location = new System.Drawing.Point(89, 19);
            this.мощьностьДвигателяTextBox.Name = "мощьностьДвигателяTextBox";
            this.мощьностьДвигателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.мощьностьДвигателяTextBox.TabIndex = 1;
            // 
            // объемДвигателяLabel
            // 
            объемДвигателяLabel.AutoSize = true;
            объемДвигателяLabel.Location = new System.Drawing.Point(35, 45);
            объемДвигателяLabel.Name = "объемДвигателяLabel";
            объемДвигателяLabel.Size = new System.Drawing.Size(48, 13);
            объемДвигателяLabel.TabIndex = 2;
            объемДвигателяLabel.Text = "Объем :";
            // 
            // объемДвигателяTextBox
            // 
            this.объемДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пТСBindingSource, "ОбъемДвигателя", true));
            this.объемДвигателяTextBox.Location = new System.Drawing.Point(89, 45);
            this.объемДвигателяTextBox.Name = "объемДвигателяTextBox";
            this.объемДвигателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.объемДвигателяTextBox.TabIndex = 3;
            // 
            // CreatPTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_PTS);
            this.Name = "CreatPTS";
            this.Text = "CreatPTS";
            this.Load += new System.EventHandler(this.CreatPTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСBindingSource)).EndInit();
            this.tabControl_PTS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabasegaiDataSet databasegaiDataSet;
        private System.Windows.Forms.BindingSource пТСBindingSource;
        private DatabasegaiDataSetTableAdapters.ПТСTableAdapter пТСTableAdapter;
        private DatabasegaiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl_PTS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox серияПТСTextBox;
        private System.Windows.Forms.TextBox номерПтсTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox объемДвигателяTextBox;
        private System.Windows.Forms.TextBox мощьностьДвигателяTextBox;
    }
}