using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Collections;


namespace DocForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = fileDialog.FileName;
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Document doc = app.Documents.Open(filepath);
                string data = doc.Content.Text;
                txtDoc.Text = data;
                app.Quit();
            }

            
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtId.Text);
            string name = txtName.Text;
            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);

            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();

                string filepath = fileDialog.FileName;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = fileDialog.FileName;
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    //Document document = app.Documents.Open(filepath);
                    //string data = document.Content.Text;
                    
                    app.Quit();
                }
                // Convert Image to byte array
                byte[] doc = File.ReadAllBytes(filepath);

                // Open the connection
                scon.Open();

                // SQL command to insert binary data into database
                string sql = "INSERT INTO tbl_doc (id, name, document) VALUES (" + id + ", '" + name + "', @document1)";
                SqlCommand cmd = new SqlCommand(sql, scon);
                cmd.Parameters.AddWithValue("@document1", doc);

                // Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("doc uploaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}");
            }
            finally
            {
                // Close the connection
                scon.Close();
            }





            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtId.Text);
            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);

            try
            {

                // Open the connection
                scon.Open();

                // SQL command to insert binary data into database
                string sql = "select document from tbl_doc where  id =  " + id + "";
                SqlCommand cmd = new SqlCommand(sql, scon);
                

                SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                byte[] docByte = (byte[])dt.Rows[0][0];

                //txtDoc.Text = System.Text.Encoding.UTF8.GetString(docByte);
                txtDoc.Text = Encoding.Default.GetString(docByte);

                //System.StringBuilder stringBuilder = new System.StringBuilder();
                //foreach (byte in document)
                //    stringBuilder.Append(byte.ToString() + ", "); // a format parameter can be added
                //txtDoc.Text = stringBuilder.ToString.Trim();


                //using (MemoryStream stream = new MemoryStream(document))
                //{
                //    // Use StreamReader to read stream with UTF-8 encoding (adjust as needed)
                //    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                //    {
                //        // Read the content of StreamReader to string and set in TextBox
                //        string text = reader.ReadToEnd();
                //        txtDoc.Text = text;
                //    }
                //}

        

                MessageBox.Show("Image retrieved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}");
            }
            finally
            {
                // Close the connection
                scon.Close();
            }

        }
    }
}
