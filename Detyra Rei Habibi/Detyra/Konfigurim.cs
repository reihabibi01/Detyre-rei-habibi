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
    public partial class Konfigurim : Form
    {

        string filePath;
        string fileName;
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=detyre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int ID = 1;
        public static string titulli;
        public static string pershkrim;
        public static string docname;

        public Konfigurim()
        {
            InitializeComponent();
        }

        private void Btn_doc_Click(object sender, EventArgs e)
        {
            get_path();
        }

        private void Konfigurim_Load(object sender, EventArgs e)
        {
            ID = Form1.ID;
            titulli = Form1.titulli;
            txt_titulli.Text = titulli;
            pershkrim = Form1.pershkrimi;
            txt_pershkrimi.Text = pershkrim;
            docname = Form1.docname;
            txt_doc.Text = docname;

            txt_pershkrimi.Text = pershkrim;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "Shto Kerkesen")
            {
                get_ID();
                shto();
            }else if (txt_name.Text == "Modifiko Kerkesen")
            {
                modifiko();
            }
           
        }

        void shto()
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            string string_DATA = DateTime.Now.ToString();

            FileStream fStream = File.OpenRead(filePath);
            byte[] contents = new byte[fStream.Length];
            fStream.Read(contents, 0, (int)fStream.Length);
            fStream.Close();

            SqlCommand insert_command = new SqlCommand("INSERT INTO Kerkesa ( Id , Titulli , Pershkrimi , Data , Dokumenti , emri_dokumentit )" + "VALUES (@id , @titulli, @pershkirmi ,@data, @dokumet, @emri_dokumentit) ", cnn);

            insert_command.Parameters.AddWithValue("@id", ID);
            insert_command.Parameters.AddWithValue("@titulli", txt_titulli.Text);
            insert_command.Parameters.AddWithValue("@pershkirmi", txt_pershkrimi.Text);
            insert_command.Parameters.AddWithValue("@data", string_DATA);
            insert_command.Parameters.AddWithValue("@dokumet", contents);
            insert_command.Parameters.AddWithValue("@emri_dokumentit", fileName);

            cnn.Open();
            insert_command.ExecuteNonQuery();
            MessageBox.Show("Kerkesa u shtua!");
            cnn.Close();
        }
        void modifiko()
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            string string_DATA = DateTime.Now.ToString();

            FileStream fStream = File.OpenRead(filePath);
            byte[] contents = new byte[fStream.Length];
            fStream.Read(contents, 0, (int)fStream.Length);
            fStream.Close();

            SqlCommand insert_command = new SqlCommand("UPDATE Kerkesa Set Titulli = @titulli, Pershkrimi = @pershkirmi, Data = @data, Dokumenti = @dokumet, emri_dokumentit = @emri_dokumentit Where id=@Id", cnn);
            insert_command.Parameters.AddWithValue("@id", ID);
            insert_command.Parameters.AddWithValue("@titulli", txt_titulli.Text);
            insert_command.Parameters.AddWithValue("@pershkirmi", txt_pershkrimi.Text);
            insert_command.Parameters.AddWithValue("@data", string_DATA);
            insert_command.Parameters.AddWithValue("@dokumet", contents);
            insert_command.Parameters.AddWithValue("@emri_dokumentit", fileName);

            cnn.Open();
            insert_command.ExecuteNonQuery();
            MessageBox.Show("Kerkesa u modifukua!");
            cnn.Close();

        }


        void get_path()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Pdf Files| *.pdf|Words Files|*.doc;*.docx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileName = Path.GetFileName(filePath);
                    txt_doc.Text = fileName;
                }
            }
        }

        void get_ID() //gjenerimi i ID
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmdzs = new SqlCommand("SELECT MAX (Id) FROM Kerkesa ", cnn);
            cmdzs.CommandType = CommandType.Text;
            cnn.Open();
            ID = Convert.ToInt32( cmdzs.ExecuteScalar());
            cnn.Close();
            ID += 1;
        }

        

    }
}