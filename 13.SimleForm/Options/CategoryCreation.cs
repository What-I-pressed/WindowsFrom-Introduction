using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp.Formats.Webp;
using System.Buffers.Text;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Windows.Forms;
using WebPWrapper;

namespace _13.SimleForm.Options
{
    public partial class CategoryCreation : Form
    {
        private SqlConnection connection;
        public CategoryCreation(SqlConnection connection)
        {
            InitializeComponent();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());
            IConfiguration configuration = builder.Build();
            //string conStr = configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;";
            //conStr += $"Initial Catalog={databaseName};";
            this.connection = connection;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblDescription_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CategoryCreation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category c = new Category();
                c.Name = txtCategoryName.Text;
                c.Description = txtCategoryDecription.Text;
                c.Image = txtCategoryImage.Text;
                var date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                c.CreatedDate = date;
                //2004-12-08
                //2023-09-10 11:15:22
                string sql = "INSERT INTO tblCategories " +
                    "(Name, Description, [Image], CreatedDate) " +
                    $"VALUES(@Name, @Description, @Image, @CreatedDate);";
                SqlCommand sqlCommand = connection.CreateCommand(); //окманди виконуєються на основі підлкючення
                sqlCommand.CommandText = sql; //текст команди

                // Create a parameter with NVarChar data type for Unicode strings and add it to the command's Parameters collection
                SqlParameter pName = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
                pName.Value = c.Name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pDescription = new SqlParameter("@Description", System.Data.SqlDbType.NVarChar);
                pDescription.Value = c.Description;
                sqlCommand.Parameters.Add(pDescription);
                var imageName = Guid.NewGuid().ToString();


                WebClient webClient = new WebClient();
                webClient.DownloadFile(txtCategoryImage.Text, imageName);
               // Bitmap bitmap = new Bitmap(webClient.OpenRead(txtCategoryImage.Text));
               // if(bitmap != null)
               // {
               //     bitmap.Save(imageName, System.Drawing.Imaging.ImageFormat.Png);    
               // }
               // webClient.Dispose();
               //
               // categoryImage.ImageLocation = System.Environment.CurrentDirectory +'\\'+ imageName + ".png";
               // categoryImage.SizeMode = PictureBoxSizeMode.AutoSize;

                SqlParameter pImage = new SqlParameter("@Image", System.Data.SqlDbType.NVarChar);
                pImage.Value = imageName;
                sqlCommand.Parameters.Add(pImage);
                SqlParameter pCreatedDate = new SqlParameter("@CreatedDate", System.Data.SqlDbType.DateTime);
                pCreatedDate.Value = c.CreatedDate;
                sqlCommand.Parameters.Add(pCreatedDate);

                //виконати комнаду до сервера
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Категорія успішно додана.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Виникла помилка під час додавання категорії. " + ex.Message);
            }
        }

        private void categoryImage_Click(object sender, EventArgs e)
        {

        }
    }
}
