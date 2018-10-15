using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
namespace MessengerClient
{
    class Helpers
    {
        /// <summary>
        /// Create an authorised get request with optional header.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="token">The token that was provided by the server</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> GetRequestAsync(string path, string token, Extras.Header header)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Get,

            };

            request.Headers.Add("Token", token);
            request.Headers.Add(header.name, header.value);
            //request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }

        /// <summary>
        /// Create an authorised get request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="token">The token that was provided by the server</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> GetRequestAsync(string path, string token)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Get,

            };

            request.Headers.Add("Token", token);
            //request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = new HttpResponseMessage();
            using(HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);
                
            }

            return response;
        }

        /// <summary>
        /// Create a non-authorised get request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> GetRequestAsync(string path)
        {
            // DEBUG: MessageBox.Show(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path);

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Get,

            };


            //request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }

        /// <summary>
        /// Create an authorised post request with a header object to add to the request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="token">The token that was provided by the server</param>
        /// <param name="data">An object that will be serialised into a json string</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> PostRequestAsync(string path, string token, object data, Extras.Header header)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Post,

            };

            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Headers.Add("Token", token);
            request.Headers.Add(header.name, header.value);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");



            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }

        /// <summary>
        /// Create an authorised post request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="token">The token that was provided by the server</param>
        /// <param name="data">An object that will be serialised into a json string</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> PostRequestAsync(string path, string token, object data)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Post,

            };

            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Headers.Add("Token", token);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            
            
            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }

        /// <summary>
        /// Create a non-authorised post request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="data">An object that will be serialised into a json string</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> PostRequestAsync(string path, object data)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Post,

            };


            



            
            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }
        /// <summary>
        /// Gets the deserialised object from the JSON found in a response. TODO Exception handling
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public async static Task<T> Deserialised<T>(HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

        }

        /// <summary>
        /// Create an authorised get request.
        /// </summary>
        /// <param name="path">The path to which the request will be sent</param>
        /// <param name="token">The token that was provided by the server</param>
        /// <returns></returns>
        public async static Task<HttpResponseMessage> DeleteRequestAsync(string path, string token)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Delete,

            };

            request.Headers.Add("Token", token);
            //request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }


    }
}
