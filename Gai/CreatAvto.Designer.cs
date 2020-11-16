namespace Gai
{
    partial class CreatAvto
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
            System.Windows.Forms.Label владелецLabel;
            System.Windows.Forms.Label vinLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label годLabel;
            System.Windows.Forms.Label пТСLabel;
            System.Windows.Forms.Label страховкаLabel;
            System.Windows.Forms.Label cтcLabel;
            this.databasegaiDataSet = new Gai.DatabasegaiDataSet();
            this.автоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.АвтоTableAdapter();
            this.tableAdapterManager = new Gai.DatabasegaiDataSetTableAdapters.TableAdapterManager();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.comboBox_Vlad = new System.Windows.Forms.ComboBox();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_PTS = new System.Windows.Forms.ComboBox();
            this.пТСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_STrax = new System.Windows.Forms.ComboBox();
            this.страховкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Sts = new System.Windows.Forms.ComboBox();
            this.стсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.водителиTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.ВодителиTableAdapter();
            this.пТСTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.ПТСTableAdapter();
            this.страховкаTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.СтраховкаTableAdapter();
            this.стсTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.СтсTableAdapter();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            владелецLabel = new System.Windows.Forms.Label();
            vinLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            годLabel = new System.Windows.Forms.Label();
            пТСLabel = new System.Windows.Forms.Label();
            страховкаLabel = new System.Windows.Forms.Label();
            cтcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // владелецLabel
            // 
            владелецLabel.AutoSize = true;
            владелецLabel.Location = new System.Drawing.Point(17, 15);
            владелецLabel.Name = "владелецLabel";
            владелецLabel.Size = new System.Drawing.Size(59, 13);
            владелецLabel.TabIndex = 0;
            владелецLabel.Text = "Владелец:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new System.Drawing.Point(51, 41);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(25, 13);
            vinLabel.TabIndex = 2;
            vinLabel.Text = "Vin:";
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(27, 67);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(49, 13);
            модельLabel.TabIndex = 4;
            модельLabel.Text = "Модель:";
            // 
            // годLabel
            // 
            годLabel.AutoSize = true;
            годLabel.Location = new System.Drawing.Point(48, 93);
            годLabel.Name = "годLabel";
            годLabel.Size = new System.Drawing.Size(28, 13);
            годLabel.TabIndex = 6;
            годLabel.Text = "Год:";
            // 
            // пТСLabel
            // 
            пТСLabel.AutoSize = true;
            пТСLabel.Location = new System.Drawing.Point(44, 119);
            пТСLabel.Name = "пТСLabel";
            пТСLabel.Size = new System.Drawing.Size(32, 13);
            пТСLabel.TabIndex = 8;
            пТСLabel.Text = "ПТС:";
            // 
            // страховкаLabel
            // 
            страховкаLabel.AutoSize = true;
            страховкаLabel.Location = new System.Drawing.Point(13, 145);
            страховкаLabel.Name = "страховкаLabel";
            страховкаLabel.Size = new System.Drawing.Size(63, 13);
            страховкаLabel.TabIndex = 10;
            страховкаLabel.Text = "Страховка:";
            // 
            // cтcLabel
            // 
            cтcLabel.AutoSize = true;
            cтcLabel.Location = new System.Drawing.Point(48, 171);
            cтcLabel.Name = "cтcLabel";
            cтcLabel.Size = new System.Drawing.Size(28, 13);
            cтcLabel.TabIndex = 12;
            cтcLabel.Text = "Cтc:";
            // 
            // databasegaiDataSet
            // 
            this.databasegaiDataSet.DataSetName = "DatabasegaiDataSet";
            this.databasegaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автоBindingSource
            // 
            this.автоBindingSource.DataMember = "Авто";
            this.автоBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // автоTableAdapter
            // 
            this.автоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gai.DatabasegaiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = this.автоTableAdapter;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ДТПTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.ПраваTableAdapter = null;
            this.tableAdapterManager.ПТСTableAdapter = null;
            this.tableAdapterManager.РапортыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтраховкаTableAdapter = null;
            this.tableAdapterManager.СтсTableAdapter = null;
            // 
            // vinTextBox
            // 
            this.vinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Vin", true));
            this.vinTextBox.Location = new System.Drawing.Point(82, 38);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(183, 20);
            this.vinTextBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Модель", true));
            this.modelTextBox.Location = new System.Drawing.Point(82, 64);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(183, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // comboBox_Vlad
            // 
            this.comboBox_Vlad.DataSource = this.водителиBindingSource;
            this.comboBox_Vlad.DisplayMember = "Фамилия";
            this.comboBox_Vlad.FormattingEnabled = true;
            this.comboBox_Vlad.Location = new System.Drawing.Point(82, 12);
            this.comboBox_Vlad.Name = "comboBox_Vlad";
            this.comboBox_Vlad.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Vlad.TabIndex = 13;
            this.comboBox_Vlad.ValueMember = "ИНВ";
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataMember = "Водители";
            this.водителиBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // comboBox_PTS
            // 
            this.comboBox_PTS.DataSource = this.пТСBindingSource;
            this.comboBox_PTS.DisplayMember = "Vin";
            this.comboBox_PTS.FormattingEnabled = true;
            this.comboBox_PTS.Location = new System.Drawing.Point(82, 116);
            this.comboBox_PTS.Name = "comboBox_PTS";
            this.comboBox_PTS.Size = new System.Drawing.Size(183, 21);
            this.comboBox_PTS.TabIndex = 14;
            this.comboBox_PTS.ValueMember = "ИНПТС";
            // 
            // пТСBindingSource
            // 
            this.пТСBindingSource.DataMember = "ПТС";
            this.пТСBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // comboBox_STrax
            // 
            this.comboBox_STrax.DataSource = this.страховкаBindingSource;
            this.comboBox_STrax.DisplayMember = "Vin";
            this.comboBox_STrax.FormattingEnabled = true;
            this.comboBox_STrax.Location = new System.Drawing.Point(82, 142);
            this.comboBox_STrax.Name = "comboBox_STrax";
            this.comboBox_STrax.Size = new System.Drawing.Size(183, 21);
            this.comboBox_STrax.TabIndex = 15;
            this.comboBox_STrax.ValueMember = "ИНСтр";
            // 
            // страховкаBindingSource
            // 
            this.страховкаBindingSource.DataMember = "Страховка";
            this.страховкаBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // comboBox_Sts
            // 
            this.comboBox_Sts.DataSource = this.стсBindingSource;
            this.comboBox_Sts.DisplayMember = "Vin";
            this.comboBox_Sts.FormattingEnabled = true;
            this.comboBox_Sts.Location = new System.Drawing.Point(82, 168);
            this.comboBox_Sts.Name = "comboBox_Sts";
            this.comboBox_Sts.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Sts.TabIndex = 16;
            this.comboBox_Sts.ValueMember = "ИНСТС";
            // 
            // стсBindingSource
            // 
            this.стсBindingSource.DataMember = "Стс";
            this.стсBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gai.Properties.Resources._4047284_auto_automobile_automotive_car_shipping_tavel_transport_113533__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 297);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(264, 62);
            this.button_Save.TabIndex = 18;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // водителиTableAdapter
            // 
            this.водителиTableAdapter.ClearBeforeFill = true;
            // 
            // пТСTableAdapter
            // 
            this.пТСTableAdapter.ClearBeforeFill = true;
            // 
            // страховкаTableAdapter
            // 
            this.страховкаTableAdapter.ClearBeforeFill = true;
            // 
            // стсTableAdapter
            // 
            this.стсTableAdapter.ClearBeforeFill = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(82, 91);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(183, 20);
            this.yearTextBox.TabIndex = 19;
            // 
            // CreatAvto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 369);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_Sts);
            this.Controls.Add(this.comboBox_STrax);
            this.Controls.Add(this.comboBox_PTS);
            this.Controls.Add(this.comboBox_Vlad);
            this.Controls.Add(cтcLabel);
            this.Controls.Add(страховкаLabel);
            this.Controls.Add(пТСLabel);
            this.Controls.Add(годLabel);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(vinLabel);
            this.Controls.Add(this.vinTextBox);
            this.Controls.Add(владелецLabel);
            this.Name = "CreatAvto";
            this.Text = "CreatAvto";
            this.Load += new System.EventHandler(this.CreatAvto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пТСBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabasegaiDataSet databasegaiDataSet;
        private System.Windows.Forms.BindingSource автоBindingSource;
        private DatabasegaiDataSetTableAdapters.АвтоTableAdapter автоTableAdapter;
        private DatabasegaiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox comboBox_Vlad;
        private System.Windows.Forms.ComboBox comboBox_PTS;
        private System.Windows.Forms.ComboBox comboBox_STrax;
        private System.Windows.Forms.ComboBox comboBox_Sts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private DatabasegaiDataSetTableAdapters.ВодителиTableAdapter водителиTableAdapter;
        private System.Windows.Forms.BindingSource пТСBindingSource;
        private DatabasegaiDataSetTableAdapters.ПТСTableAdapter пТСTableAdapter;
        private System.Windows.Forms.BindingSource страховкаBindingSource;
        private DatabasegaiDataSetTableAdapters.СтраховкаTableAdapter страховкаTableAdapter;
        private System.Windows.Forms.BindingSource стсBindingSource;
        private DatabasegaiDataSetTableAdapters.СтсTableAdapter стсTableAdapter;
        private System.Windows.Forms.TextBox yearTextBox;
    }
}