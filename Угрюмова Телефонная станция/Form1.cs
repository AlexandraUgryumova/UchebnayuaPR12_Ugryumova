using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_Телефонная_станция
{
    public partial class Form1 :Form
    {
        SqlDataAdapter adptr;
        SqlConnection connect = new SqlConnection(@"Data Source=PC325L12\SQLEXPRESS;Initial Catalog=TelephoneStation_Ugryumova;Integrated Security=True");
        DataTable table;

        public Form1 ()
        {
            InitializeComponent( );
            TableView("select * from dbo.Абоненты");
            dataGridView1.DataSource = table;
            TableView("select * from dbo.АТС");
            dataGridView2.DataSource = table;
            TableView("select * from dbo.Номера");
            dataGridView3.DataSource = table;
        }
        private void TableView(string mess)
        {
            connect.Open( );
            adptr = new SqlDataAdapter(mess, connect);
            table = new DataTable( );
            adptr.Fill(table);
            connect.Close( );
        }
        private bool CheckString(string mess)
        {
            bool check = true;
            char [ ] mess1 = mess.ToCharArray();

            for(int i = 0; i < mess1.Length; i ++ )
            {
                if((mess1[i] >= 'а' && mess1[i] <= 'я') || (mess1[i] >= 'А' && mess1[i] <= 'Я') || mess1[i] == ' ' || mess1[i] == '-')
                {
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged (object sender, EventArgs e)
        {
            if ( checkBox1.Checked )
            {
                primechanie_txt.Visible = true;
                label4.Visible = true;
            }
            else
            {
                primechanie_txt.Visible = false;
                label4.Visible = false;
            }
        }
        //г. Берёзовский, ул. Восточная, д. 11а, кв. 326

        private void Add_btn3_Click (object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dateTimePicker1.Value;
                bool check = checkBox1.Checked;

                if ( NumberPhone_txt.Text == "" || Abonent_txt.Text == "" || ATS_txt.Text == "" )
                {
                    MessageBox.Show("заполните необходимые поля: Номер телефона, Абонент, АТС");
                }
                else
                {
                    TableView($"SELECT * FROM dbo.Абоненты WHERE [Номер абонента] = '{Abonent_txt.Text}'");
                    if(table.Rows.Count != 0 )
                    {
                        TableView($"SELECT * FROM dbo.АТС WHERE [Код] = '{ATS_txt.Text}'");
                        if(table.Rows.Count != 0 )
                        {
                            TableView($"INSERT INTO dbo.Номера  ([Номер телефона],  Абонент,  АТС,  Задолжность, [Дата установки]) VALUES('{NumberPhone_txt.Text}','{Abonent_txt.Text}','{ATS_txt.Text}','{check}','{dt.ToString("yyyy-MM-dd")}')");
                            TableView("SELECT * FROM dbo.Номера");
                            dataGridView3.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("данного кода не существует");
                        }
                    }
                    else
                    {
                        MessageBox.Show("данного абонента не сущесвтует");
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("данные не соответствуют своим типам");
            }
        }

        private void Add_btn1_Click (object sender, EventArgs e)
        {
            if ( FIO_txt.Text == "" || Adress_txt.Text == "" )
            {
                MessageBox.Show("заполните необходимые поля: ФИО и Адрес");
            }
            else
            {
                if ( CheckString(FIO_txt.Text) )
                {
                    if ( checkBox1.Checked )
                    {
                        if ( primechanie_txt.Text != "" )
                        {
                            TableView($"INSERT INTO dbo.Абоненты  (ФИО,  Адрес,  Блокиатор,  Примечание) VALUES('{FIO_txt.Text}','{Adress_txt.Text}','True','{primechanie_txt.Text}')");
                            TableView("SELECT * FROM dbo.Абоненты");
                            dataGridView1.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("заполните поле примечания");
                        }
                    }
                    else
                    {
                        TableView($"INSERT INTO dbo.Абоненты  (ФИО,  Адрес,  Блокиатор,  Примечание) VALUES('{FIO_txt.Text}','{Adress_txt.Text}','False','')");
                        TableView("SELECT * FROM dbo.Абоненты");
                        dataGridView1.DataSource = table;
                    }
                    //ЖБИ, ул. Криворучкино, д. 666, кв. 66
                }
                else
                {
                    MessageBox.Show("в фамилии есть символы, которых не должно быть");
                }
                
            }
        }

        private void Add_btn2_Click (object sender, EventArgs e)
        {
            try
            {
                if ( KodRaiona_txt.Text == "" || CountNumber_txt.Text == "" )
                {
                    MessageBox.Show("заполните необходимые поля: Код района и Количество номеров");
                }
                else
                {
                    if ( KodRaiona_txt.Text.Length == 6 )
                    {
                        TableView($"INSERT INTO dbo.АТС  ([Код района],  [Количество номеров]) VALUES({int.Parse(KodRaiona_txt.Text)},{int.Parse(CountNumber_txt.Text)})");
                        TableView("SELECT * FROM dbo.АТС");
                        dataGridView2.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Код района должен состоять из 6 цифр");
                    }
                }
            }
            catch
            {
                MessageBox.Show("для заполнения полей нужно использовать числа");
            }
        }

        private void Delete_btn3_Click (object sender, EventArgs e)
        {
            int strokaCount  = dataGridView3.RowCount;
            string id = ToString( );
            TableView($"DELETE FROM dbo.Номера WHERE 'ID' = {dataGridView3.CurrentRow.Index+1}");
            adptr.Update(table);
        }
    }
}
