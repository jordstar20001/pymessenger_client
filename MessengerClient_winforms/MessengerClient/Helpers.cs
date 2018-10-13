﻿using System;
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
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

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
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Main.ServerAddress + ":" + Main.ServerPort.ToString() + path),
                Method = HttpMethod.Get,

            };

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


            MessageBox.Show("Content: " + JsonConvert.SerializeObject(data));



            
            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            MessageBox.Show(request.ToString());
            var response = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            return response;
        }


    }
}
