namespace TickBook
{
    partial class Form2
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
            System.Windows.Forms.Label вид_документа__удостоверяющий_личностьLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label номер_талонаLabel;
            System.Windows.Forms.Label номер_СНИЛСLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bDRDataSet1 = new TickBook.BDRDataSet1();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new TickBook.BDRDataSet1TableAdapters.ПациентыTableAdapter();
            this.tableAdapterManager = new TickBook.BDRDataSet1TableAdapters.TableAdapterManager();
            this.вид_документа__удостоверяющий_личностьTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.номер_талонаTextBox = new System.Windows.Forms.TextBox();
            this.номер_СНИЛСTextBox = new System.Windows.Forms.TextBox();
            вид_документа__удостоверяющий_личностьLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            номер_талонаLabel = new System.Windows.Forms.Label();
            номер_СНИЛСLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // вид_документа__удостоверяющий_личностьLabel
            // 
            вид_документа__удостоверяющий_личностьLabel.AutoSize = true;
            вид_документа__удостоверяющий_личностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вид_документа__удостоверяющий_личностьLabel.Location = new System.Drawing.Point(54, 197);
            вид_документа__удостоверяющий_личностьLabel.Name = "вид_документа__удостоверяющий_личностьLabel";
            вид_документа__удостоверяющий_личностьLabel.Size = new System.Drawing.Size(346, 20);
            вид_документа__удостоверяющий_личностьLabel.TabIndex = 92;
            вид_документа__удостоверяющий_личностьLabel.Text = "Вид документа, удостоверяющий личность:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(53, 245);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(83, 20);
            телефонLabel.TabIndex = 93;
            телефонLabel.Text = "Телефон:";
            // 
            // номер_талонаLabel
            // 
            номер_талонаLabel.AutoSize = true;
            номер_талонаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_талонаLabel.Location = new System.Drawing.Point(54, 293);
            номер_талонаLabel.Name = "номер_талонаLabel";
            номер_талонаLabel.Size = new System.Drawing.Size(122, 20);
            номер_талонаLabel.TabIndex = 94;
            номер_талонаLabel.Text = "Номер талона:";
            // 
            // номер_СНИЛСLabel
            // 
            номер_СНИЛСLabel.AutoSize = true;
            номер_СНИЛСLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_СНИЛСLabel.Location = new System.Drawing.Point(56, 151);
            номер_СНИЛСLabel.Name = "номер_СНИЛСLabel";
            номер_СНИЛСLabel.Size = new System.Drawing.Size(124, 20);
            номер_СНИЛСLabel.TabIndex = 96;
            номер_СНИЛСLabel.Text = "Номер СНИЛС:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(209, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Документы пациента:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(551, 449);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 51);
            this.button3.TabIndex = 86;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Cyan;
            this.button5.Location = new System.Drawing.Point(377, 449);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 51);
            this.button5.TabIndex = 88;
            this.button5.Text = "ДОБАВИТЬ ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TickBook.Properties.Resources.time_clock_timer_appointment_icon_131244__1_;
            this.pictureBox1.Location = new System.Drawing.Point(305, 449);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // bDRDataSet1
            // 
            this.bDRDataSet1.DataSetName = "BDRDataSet1";
            this.bDRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "Пациенты";
            this.пациентыBindingSource.DataSource = this.bDRDataSet1;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TickBook.BDRDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗанятостьTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = this.пациентыTableAdapter;
            this.tableAdapterManager.Списое_врачейTableAdapter = null;
            this.tableAdapterManager.ТалоныTableAdapter = null;
            // 
            // вид_документа__удостоверяющий_личностьTextBox
            // 
            this.вид_документа__удостоверяющий_личностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Вид документа, удостоверяющий личность", true));
            this.вид_документа__удостоверяющий_личностьTextBox.Location = new System.Drawing.Point(407, 197);
            this.вид_документа__удостоверяющий_личностьTextBox.Name = "вид_документа__удостоверяющий_личностьTextBox";
            this.вид_документа__удостоверяющий_личностьTextBox.Size = new System.Drawing.Size(200, 20);
            this.вид_документа__удостоверяющий_личностьTextBox.TabIndex = 93;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(407, 245);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 20);
            this.телефонTextBox.TabIndex = 94;
            // 
            // номер_талонаTextBox
            // 
            this.номер_талонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Номер талона", true));
            this.номер_талонаTextBox.Location = new System.Drawing.Point(407, 293);
            this.номер_талонаTextBox.Name = "номер_талонаTextBox";
            this.номер_талонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_талонаTextBox.TabIndex = 95;
            // 
            // номер_СНИЛСTextBox
            // 
            this.номер_СНИЛСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Номер СНИЛС", true));
            this.номер_СНИЛСTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_СНИЛСTextBox.Location = new System.Drawing.Point(407, 151);
            this.номер_СНИЛСTextBox.Name = "номер_СНИЛСTextBox";
            this.номер_СНИЛСTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_СНИЛСTextBox.TabIndex = 97;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(681, 520);
            this.Controls.Add(номер_СНИЛСLabel);
            this.Controls.Add(this.номер_СНИЛСTextBox);
            this.Controls.Add(номер_талонаLabel);
            this.Controls.Add(this.номер_талонаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(вид_документа__удостоверяющий_личностьLabel);
            this.Controls.Add(this.вид_документа__удостоверяющий_личностьTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Заявление о приеме ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private BDRDataSet1 bDRDataSet1;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private BDRDataSet1TableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private BDRDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox вид_документа__удостоверяющий_личностьTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox номер_талонаTextBox;
        private System.Windows.Forms.TextBox номер_СНИЛСTextBox;
    }
}