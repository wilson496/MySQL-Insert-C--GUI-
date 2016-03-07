using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        MySqlCommand cmd;
        MySqlConnection connection;



        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
              try {



            

                connection = new MySqlConnection(@"server=localhost;uid=root;pwd=0zx10852A;persistsecurityinfo=True;database=patientlog");

                cmd = connection.CreateCommand();

                cmd = new MySqlCommand("INSERT INTO patient (first_name, last_name, address, city, province, zip, phone, birth_date, cc_num, patient_id) VALUES (@first_name, @last_name, @address, @city, @province, @zip, @phone, @birth_date, @cc_num, @patient_id)", connection);
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox11.Text);
                cmd.Parameters.AddWithValue("@city", textBox4.Text);
                cmd.Parameters.AddWithValue("@province", textBox3.Text);
                cmd.Parameters.AddWithValue("@zip", textBox5.Text);
                cmd.Parameters.AddWithValue("@phone", textBox10.Text);
                cmd.Parameters.AddWithValue("@birth_date", textBox9.Text);
                cmd.Parameters.AddWithValue("@cc_num", textBox8.Text);
                cmd.Parameters.AddWithValue("@patient_id", textBox7.Text);
                connection.Open();
                cmd.ExecuteNonQuery();

                

           }
            
            catch (MySqlException ex){

                Console.WriteLine("Sorry, there is a MySQL error");
                System.Windows.Forms.Application.Exit();

             }
            
        }

        
    }
}
