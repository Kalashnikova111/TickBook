using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickBook
{

    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = BDR.mdb";//строка подключен

        private OleDbConnection myConnection;

        //запрос с бд
        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();// соединен с БД

        }

        private void button5_Click(object sender, EventArgs e)
        {
             //свернуть форму 1
            Form2 Form1 = new Form2();
            Form1.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //свернуть форму 1
            Form3 Form1 = new Form3();
            Form1.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView4.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView4.RowCount - 1; j++)
                {
                    dataGridView4[i, j].Style.BackColor = Color.White;
                    dataGridView4[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView4.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView4.RowCount - 1; j++)
                {
                    if (dataGridView4[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView4[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView4[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView2.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount - 1; j++)
                {
                    dataGridView2[i, j].Style.BackColor = Color.White;
                    dataGridView2[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView2.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount - 1; j++)
                {
                    if (dataGridView2[i, j].Value.ToString().IndexOf(textBox2.Text) != -1)
                    {
                        dataGridView2[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView2[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Новая запись сохранена ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            занятостьBindingSource1.RemoveCurrent();
            пациентыBindingSource3.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            списоеВрачейBindingSource1.RemoveCurrent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDRDataSet11.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter1.Fill(this.bDRDataSet11.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDRDataSet11.Занятость". При необходимости она может быть перемещена или удалена.
            this.занятостьTableAdapter1.Fill(this.bDRDataSet11.Занятость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDRDataSet11.Списое_врачей". При необходимости она может быть перемещена или удалена.
            this.списое_врачейTableAdapter1.Fill(this.bDRDataSet11.Списое_врачей);

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Новая запись сохранена ");
        }
    }
}
