using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Detyra
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=detyre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string konfigurim_name = "";
        public static int ID;
        public static string titulli;
        public static string pershkrimi;
        public static string docname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_shto_Click(object sender, EventArgs e)
        {
            konfigurim_name = "Shto Kerkesen";
            hap_konfigurimin();
        }

        private void Btn_modifiko_Click(object sender, EventArgs e)
        {
            konfigurim_name = "Modifiko Kerkesen";
            get_data();
            hap_konfigurimin(); 

        }

        private void Btn_lexo_Click(object sender, EventArgs e)
        {
            konfigurim_name = "Lexo Kerkesen";
            get_data();
            btn_disable();
            hap_konfigurimin();


        }

        private void Btn_shkarko_Click(object sender, EventArgs e)
        {
            shkarko();
        }

        private void Txt_refresh_Click(object sender, EventArgs e)
        {
            Inicializimi_kerkeses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializimi_kerkeses();
        }
        private void Txt_filter_TextChanged(object sender, EventArgs e)
        {
            db_filter();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Fshi_Kerkesen();
            Inicializimi_kerkeses();
        }


        void Inicializimi_kerkeses()
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Kerkesa", cnn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();

        }

        void db_filter()
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapt;
            DataTable dt;
            cnn.Open();
            adapt = new SqlDataAdapter("select * from Kerkesa where Titulli like '" + txt_filter.Text + "%'", cnn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        void hap_konfigurimin(){

            Konfigurim konfigurimi = new Konfigurim();
            konfigurimi.txt_name.Text = konfigurim_name;
            konfigurimi.Show();

        }

        void btn_disable()
        {

            Konfigurim konfigurimi = new Konfigurim();
            konfigurimi.txt_pershkrimi.Enabled = false;
            konfigurimi.txt_titulli.Enabled = false;
            konfigurimi.txt_name.Text = konfigurim_name;
        }

        void Fshi_Kerkesen()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand delet_command = new SqlCommand("delete from Kerkesa where Id=@id", cnn);
            ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            delet_command.Parameters.AddWithValue("@id", ID);

            cnn.Open();
            delet_command.ExecuteNonQuery();
            MessageBox.Show("Kerkesa u Fshi!");
            cnn.Close();
        }

        void shkarko()
        {
            ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            docname = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand download_command = new SqlCommand("SELECT Dokumenti from Kerkesa where Id=@id", cnn);

            {
                download_command.Parameters.AddWithValue("@id", ID);
                cnn.Open();
                using (var sqlQueryResult = download_command.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(docname, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
                cnn.Close();
            }
        }

        void get_data()
        {
            Konfigurim konfigurimi = new Konfigurim();
            ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            titulli = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pershkrimi = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            docname = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
