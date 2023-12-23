using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;
using Newtonsoft.Json;

namespace _13.SimleForm.Options
{
    public partial class ConnectionForm : Form
    {
        private SqlConnection connection = null;

        private IConfiguration configuration;

        public SqlConnection Connection
        {
            get { if (IsConnectionSuccessful) return connection;
                else throw new Exception("Неможливо підключитися до сервера за такими параметрами!");
            }
        }

        private bool IsConnectionSuccessful = false;
        public ConnectionForm()
        {
            InitializeComponent();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();

            txtServerHost.Text = configuration.GetConnectionString("host");
            txtUserName.Text = configuration.GetConnectionString("user");
            txtUserPasssword.Text = configuration.GetConnectionString("password");
        }

        private void btnCheckConnection_Click_1(object sender, EventArgs e)
        {
            string host = txtServerHost.Text;
            string userName = txtUserName.Text;
            string password = txtUserPasssword.Text;
            string conStr = $"Data Source={host};User ID={userName};Password={password};Initial Catalog = BEBE;MultipleActiveResultSets=true;";
            try
            {
                connection = new SqlConnection(conStr);
                MessageBox.Show("Успішно");
                connection.Open();
                IsConnectionSuccessful= true;
                base.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! "+ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
