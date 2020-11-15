namespace Gai
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.databasegaiDataSet = new Gai.DatabasegaiDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Gai.DatabasegaiDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Gai.DatabasegaiDataSetTableAdapters.TableAdapterManager();
            this.label_pattempt = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.TextBox();
            this.Label_Logins = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // databasegaiDataSet
            // 
            this.databasegaiDataSet.DataSetName = "DatabasegaiDataSet";
            this.databasegaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.databasegaiDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПТСTableAdapter = null;
            this.tableAdapterManager.РапортыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.СтраховкаTableAdapter = null;
            this.tableAdapterManager.СтсTableAdapter = null;
            // 
            // label_pattempt
            // 
            this.label_pattempt.AutoSize = true;
            this.label_pattempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pattempt.Location = new System.Drawing.Point(38, 324);
            this.label_pattempt.Name = "label_pattempt";
            this.label_pattempt.Size = new System.Drawing.Size(238, 20);
            this.label_pattempt.TabIndex = 13;
            this.label_pattempt.Text = "Количество попыток входа : 3";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(87, 344);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(128, 23);
            this.Btn_Login.TabIndex = 12;
            this.Btn_Login.Text = "Вход";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пароль";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(124, 232);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(55, 20);
            this.log.TabIndex = 10;
            this.log.Text = "Логин";
            // 
            // Label_Password
            // 
            this.Label_Password.Location = new System.Drawing.Point(87, 302);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(128, 20);
            this.Label_Password.TabIndex = 9;
            // 
            // Label_Logins
            // 
            this.Label_Logins.Location = new System.Drawing.Point(87, 256);
            this.Label_Logins.Name = "Label_Logins";
            this.Label_Logins.Size = new System.Drawing.Size(128, 20);
            this.Label_Logins.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 374);
            this.Controls.Add(this.label_pattempt);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Logins);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasegaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabasegaiDataSet databasegaiDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private DatabasegaiDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private DatabasegaiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label_pattempt;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.TextBox Label_Password;
        private System.Windows.Forms.TextBox Label_Logins;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}