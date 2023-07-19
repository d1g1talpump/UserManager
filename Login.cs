using AuthenticationAPI.Models;
using Newtonsoft.Json;
using System.Data;
using System.Text;
using UserManager.Helpers;

namespace UserManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void b_SubmitLogin_Click(object sender, EventArgs e)
        {
            var logingRequest = new LoginRequest()
            {
                Login = tb_Login.Text,
                Password = tb_Password.Text
            };

            List<string> nullOrEmptyProperties = typeof(LoginRequest).GetProperties()
                .Where(p => p.PropertyType == typeof(string))
                .Where(p => string.IsNullOrEmpty((string)p.GetValue(logingRequest)))
                .Select(p => p.Name)
                .ToList();

            if (nullOrEmptyProperties.Count == 0)
            {


                HttpClient client = new HttpClient();
                // Set the request URI
                var requestUri = AppSettings.BaseUrl + "/login";

                // Create the JSON content
                var jsonContent = JsonConvert.SerializeObject(logingRequest);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync(requestUri, content);

                // Get the response content
                var responseJson = await response.Content.ReadAsStringAsync() ?? "";
                //ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseJson) ?? new ApiResponse();

                // Proceed
                var f_createUser = new CreateUser();
                f_createUser.FormClosed += (s, ea) => this.Close();
                f_createUser.ShowDialog();                
            }
        }
    }
}
