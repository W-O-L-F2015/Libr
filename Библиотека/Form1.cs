using DocumentFormat.OpenXml.Office2010.Excel;
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
using System.Xml;

namespace Библиотека
{
    public partial class Form1 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Book.mdb;";
        private OleDbConnection myConnection;




        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string author = textBox2.Text;
            string publishing = textBox3.Text;
            int year = Convert.ToInt32(textBox4.Text);
            string place = textBox5.Text;
            string style = textBox6.Text;
            string serial = textBox7.Text;
            int rating = Convert.ToInt32(textBox8.Text);
            int pages = Convert.ToInt32(textBox9.Text);
            int circulation = Convert.ToInt32(textBox10.Text);
            string description = textBox11.Text;
            string cost = textBox12.Text;
            string binding = textBox13.Text;
            string format = textBox14.Text;
            string status = textBox15.Text;
            Properties.Settings.Default.ID = Properties.Settings.Default.ID + Properties.Settings.Default.ID;

            string query = "INSERT INTO Book(Название,Автор,Издательство,Год,Место,Жанр,Серия,Оценка,Страниц,Тираж,Описание,Стоимость,Переплет,Формат,Состояние, Изображение) VALUES ('" + name + "','" + author + "','" + publishing + "','" + year + "','" + place + "','" + style + "','" + serial + "','" + rating + "','" + pages + "','" + circulation + "','" + description + "','" + cost + "','" + binding + "','" + format + "','" + status + "' ,'" + Properties.Settings.Default.ID + ".jpg" + "' )";
            pictureBox1.Image.Save(Properties.Settings.Default.ID + ".jpg");
            

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.bookDataSet.Book);


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic = new OpenFileDialog(); 
            pic.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"; 

            if (pic.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pictureBox1.Image = new Bitmap(pic.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                   
                    pictureBox1.Image = pictureBox1.Image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 0;

            string query = "SELECT Название,Автор,Издательство,Год,Место,Жанр,Серия,Оценка,Страниц,Тираж,Описание,Стоимость,Переплет,Формат,Состояние FROM book ORDER BY Номер_книги";

         
            OleDbCommand command = new OleDbCommand(query, myConnection);

      
            OleDbDataReader reader = command.ExecuteReader();

     
            listBox1.Items.Clear();
            

            while (reader.Read())
            {
            
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + " " + reader[3].ToString() + " " + " " + reader[4].ToString() + " " + " " + reader[5].ToString() + " " + " " + reader[6].ToString() + " " + " " + reader[7].ToString() + " " + " " + reader[8].ToString() + " " + " " + reader[9].ToString() + " " + " " + reader[10].ToString() + " " + " " + reader[11].ToString() + " " + " " + reader[12].ToString() + " " + " " + reader[13].ToString() + " " + " " + reader[14].ToString() + " ");
                number = (number)++;
            }

      
            reader.Close();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            int id = int.Parse(listBox1.SelectedValue.ToString());
            label1.Text = Convert.ToString(id);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value0 = row.Cells[0].Value.ToString();
                string value1 = row.Cells[1].Value.ToString();
                string value2 = row.Cells[2].Value.ToString();
                string value3 = row.Cells[3].Value.ToString();
                string value4 = row.Cells[4].Value.ToString();
                string value5 = row.Cells[5].Value.ToString();
                string value6 = row.Cells[6].Value.ToString();
                string value7 = row.Cells[7].Value.ToString();
                string value8 = row.Cells[8].Value.ToString();
                string value9 = row.Cells[9].Value.ToString();
                string value10 = row.Cells[10].Value.ToString();
                string value11 = row.Cells[11].Value.ToString();
                string value12 = row.Cells[12].Value.ToString();
                string value13 = row.Cells[13].Value.ToString();
                string value14 = row.Cells[14].Value.ToString();
                string value15 = row.Cells[15].Value.ToString();
                string value16 = row.Cells[16].Value.ToString();


                label1.Text = value11;
               

               pictureBox2.Image = Image.FromFile(value16);


            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tabControl1_SizeChanged(object sender, EventArgs e)
        {
            




        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
