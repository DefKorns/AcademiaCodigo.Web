using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace AcademiaCodigo.Web.DataAccess {
    public class BaseClient {
        private HttpClient client;

        public BaseClient () {
            client = new HttpClient ();
            client.BaseAddress = new Uri ("http://localhost:5000/api/");
        }

        public TGet Get<TGet> (string route, Dictionary<string, string> routeParams) {

            string routeParamsString = string.Empty;

            if (routeParams != null) {
                routeParamsString = "?" + string.Join ("&",
                    routeParams.Select (x => x.Key + "=" + WebUtility.HtmlEncode (x.Value)));
            }
            return Get<TGet> (route, routeParamsString);
        }

        public TGet Get<TGet> (string route, string routeParams) {
            Uri uri = new Uri (client.BaseAddress + route + "/" + routeParams);
            var task = this.client.GetAsync (uri);
            task.Wait ();

            HttpResponseMessage result = task.Result;
            if (task.Result.IsSuccessStatusCode) {
                var taskRequest = result.Content.ReadAsAsync<TGet> ();
                taskRequest.Wait ();
                return taskRequest.Result;
            } else {
                throw new Exception ("The Result failed with code: " +
                    result.StatusCode +
                    Environment.NewLine +
                    result.ReasonPhrase);
            }
        }

        public TGet Post<TGet, TParams> (string route, TParams param) where TParams: class
        {

            Uri uri = new Uri(client.BaseAddress + route);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
            var body = JsonConvert.SerializeObject(param);
            request.Content = new StringContent(body,Encoding.UTF8);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var task = client.SendAsync(request);
            task.Wait();
            HttpResponseMessage response = task.Result;
            if(response.IsSuccessStatusCode){
                var taskRequest = request.Content.ReadAsAsync<TGet>();
                taskRequest.Wait();
                return taskRequest.Result;
            }else{
                throw new Exception("The Request Failed with code: "
                    + response.StatusCode
                    + Environment.NewLine
                    + response.ReasonPhrase);
            }
        }
    }
}