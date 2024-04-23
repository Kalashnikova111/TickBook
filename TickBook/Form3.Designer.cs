namespace TickBook
{
    partial class Form3
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
            System.Windows.Forms.Label день_неделиLabel;
            System.Windows.Forms.Label номер_талонаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.день_неделиTextBox = new System.Windows.Forms.TextBox();
            this.номер_талонаTextBox = new System.Windows.Forms.TextBox();
            this.талоныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDRDataSet1 = new TickBook.BDRDataSet1();
            this.талоныTableAdapter = new TickBook.BDRDataSet1TableAdapters.ТалоныTableAdapter();
            this.tableAdapterManager = new TickBook.BDRDataSet1TableAdapters.TableAdapterManager();
            день_неделиLabel = new System.Windows.Forms.Label();
            номер_талонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.талоныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // день_неделиLabel
            // 
            день_неделиLabel.AutoSize = true;
            день_неделиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            день_неделиLabel.Location = new System.Drawing.Point(44, 146);
            день_неделиLabel.Name = "день_неделиLabel";
            день_неделиLabel.Size = new System.Drawing.Size(113, 20);
            день_неделиLabel.TabIndex = 112;
            день_неделиLabel.Text = "День недели:";
            // 
            // номер_талонаLabel
            // 
            номер_талонаLabel.AutoSize = true;
            номер_талонаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_талонаLabel.Location = new System.Drawing.Point(44, 192);
            номер_талонаLabel.Name = "номер_талонаLabel";
            номер_талонаLabel.Size = new System.Drawing.Size(122, 20);
            номер_талонаLabel.TabIndex = 114;
            номер_талонаLabel.Text = "Номер талона:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Cyan;
            this.button5.Location = new System.Drawing.Point(103, 279);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 51);
            this.button5.TabIndex = 91;
            this.button5.Text = "ДОБАВИТЬ ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(277, 279);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 51);
            this.button3.TabIndex = 90;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TickBook.Properties.Resources.time_clock_timer_appointment_icon_131244__1_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 279);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(133, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "Свободные талоны:";
            // 
            // день_неделиTextBox
            // 
            this.день_неделиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.талоныBindingSource, "День недели", true));
            this.день_неделиTextBox.Location = new System.Drawing.Point(178, 148);
            this.день_неделиTextBox.Name = "день_неделиTextBox";
            this.день_неделиTextBox.Size = new System.Drawing.Size(200, 20);
            this.день_неделиTextBox.TabIndex = 113;
            // 
            // номер_талонаTextBox
            // 
            this.номер_талонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.талоныBindingSource, "Номер талона", true));
            this.номер_талонаTextBox.Location = new System.Drawing.Point(178, 192);
            this.номер_талонаTextBox.Name = "номер_талонаTextBox";
            this.номер_талонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_талонаTextBox.TabIndex = 115;
            // 
            // талоныBindingSource
            // 
            this.талоныBindingSource.DataMember = "Талоны";
            this.талоныBindingSource.DataSource = this.bDRDataSet1;
            // 
            // bDRDataSet1
            // 
            this.bDRDataSet1.DataSetName = "BDRDataSet1";
            this.bDRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // талоныTableAdapter
            // 
            this.талоныTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TickBook.BDRDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗанятостьTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.Списое_врачейTableAdapter = null;
            this.tableAdapterManager.ТалоныTableAdapter = this.талоныTableAdapter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 350);
            this.Controls.Add(номер_талонаLabel);
            this.Controls.Add(this.номер_талонаTextBox);
            this.Controls.Add(день_неделиLabel);
            this.Controls.Add(this.день_неделиTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Свободные талоны";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.талоныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private BDRDataSet1 bDRDataSet1;
        private System.Windows.Forms.BindingSource талоныBindingSource;
        private BDRDataSet1TableAdapters.ТалоныTableAdapter талоныTableAdapter;
        private BDRDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox день_неделиTextBox;
        private System.Windows.Forms.TextBox номер_талонаTextBox;
    }
}