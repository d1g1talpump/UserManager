using Newtonsoft.Json;
using RequestMaker.UserRequests;
using System.Data;
using System.Text;
using UserManager.Helpers;
using Timer = System.Windows.Forms.Timer;

namespace UserManager
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private async void Submit_Click(object sender, EventArgs e)
        {

            var createRequest = new CreateRequest()
            {
                Title = tb_Title.Text,
                Login = tb_Login.Text,
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Role = tb_Role.Text,
                Email = tb_Email.Text,
                Password = tb_Password.Text,
                ConfirmPassword = tb_ConfirmPassword.Text
            };

            List<string> nullOrEmptyProperties = typeof(CreateRequest).GetProperties()
                .Where(p => p.PropertyType == typeof(string))
                .Where(p => string.IsNullOrEmpty((string)p.GetValue(createRequest)))
                .Select(p => p.Name)
                .ToList();


            if (nullOrEmptyProperties.Count == 0)
            {

                HttpClient client = new HttpClient();
                // Set the request URI
                var requestUri = AppSettings.BaseUrl + "/users";

                // Create the JSON content
                var jsonContent = JsonConvert.SerializeObject(createRequest);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync(requestUri, content);

                // Get the response content
                var responseJson = await response.Content.ReadAsStringAsync() ?? "";
                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseJson) ?? new ApiResponse();

                // TODO: Handle the response content
                l_createResponseMsg.Text = responseJson;
                TimedMessage(l_createResponseMsg);
            }
            else
            {

                var s_listEmptyFields = "";

                foreach (var prop in nullOrEmptyProperties)
                {
                    s_listEmptyFields += prop + (nullOrEmptyProperties.Last() != prop ? ", " : "");
                }

                l_emptyWarning.Text = $"Cannot proceed: Fields {s_listEmptyFields} {(nullOrEmptyProperties.Count > 1 ? "are" : "is")} empty";

                TimedMessage(l_emptyWarning);
                return;

            }


        }

        private void TimedMessage(Label lable)
        {
            lable.Visible = true;
            // Create a timer with an interval of 5 seconds (5000 milliseconds)
            var timer = new Timer { Interval = 5000 };

            // Set the timer's Tick event handler
            timer.Tick += (s, ea) =>
            {
                // Hide the label
                lable.Visible = false;

                // Stop and dispose the timer
                timer.Stop();
                timer.Dispose();
            };

            // Start the timer
            timer.Start();
        }
    }
}
