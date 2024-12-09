using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AttendanceSeekers_client.Services
{
    public class Requests
    {
        HttpClient _http;
        public Requests(HttpClient http)
        {
            _http = http;
        }
        public async Task<HttpResponseMessage> SendRequestAsync<T>(string url, HttpMethod method, T data)
        {
            using (var request = new HttpRequestMessage(method, url))
            {
                // Serialize the data to JSON
                string jsonPayload = JsonSerializer.Serialize(data);
                request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Send the request
                return await _http.SendAsync(request);
            }
        }

        public async Task HandleResponse(HttpResponseMessage response, string successMessage, string errorMessage)
        {
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"{errorMessage}: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
