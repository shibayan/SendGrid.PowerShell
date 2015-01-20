using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json;

namespace SendGrid.PowerShell.Common
{
    public abstract class CmdletBase : Cmdlet
    {
        private const string Endpoint = "https://api.sendgrid.com/api/{0}.{1}.json";
        private const string EndpointV3 = "https://api.sendgrid.com/v3";

        protected static NetworkCredential ApiCredential;

        protected TResult Get<TResult>(string module, string action, object parameters = null)
        {
            var client = new HttpClient();

            var url = string.Format(Endpoint, module, action);

            var queryString = new QueryStringDictionary(parameters)
            {
                { "api_user", ApiCredential.UserName },
                { "api_key", ApiCredential.Password }
            };

            var response = client.GetAsync(url + "?" + queryString).Result;

            var content = response.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;

            try
            {
                return JsonConvert.DeserializeObject<TResult>(content);
            }
            catch (JsonSerializationException)
            {
                var result = JsonConvert.DeserializeObject<GenericResult>(content);

                WriteObject(result);

                return default(TResult);
            }
        }

        protected TResult Post<TResult>(string module, string action, object parameters)
        {
            var client = new HttpClient();

            var url = string.Format(Endpoint, module, action);

            var queryString = new QueryStringDictionary(parameters)
            {
                { "api_user", ApiCredential.UserName },
                { "api_key", ApiCredential.Password }
            };

            var content = new FormUrlEncodedContent(queryString);

            var response = client.PostAsync(url, content).Result;

            var result = response.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<TResult>(result);
        }

        protected TResult GetV3<TResult>(string path, object parameters)
        {
            throw new NotImplementedException();
        }

        protected TResult PostV3<TResult>(string path, object parameters)
        {
            throw new NotImplementedException();
        }

        protected void WriteObject(GenericResult result)
        {
            if (result == null || result.IsSuccess)
            {
                return;
            }

            WriteError(new ErrorRecord(new Exception(result.Error.Message), "", ErrorCategory.NotSpecified, null));
        }

        private class QueryStringDictionary : Dictionary<string, string>
        {
            public QueryStringDictionary(object parameter)
            {
                if (parameter == null)
                {
                    return;
                }

                foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(parameter))
                {
                    var value = property.GetValue(parameter);

                    if (value != null)
                    {
                        Add(property.Name, value.ToString());
                    }
                }
            }

            public override string ToString()
            {
                if (Count == 0)
                {
                    return "";
                }

                var result = new StringBuilder();

                foreach (var item in this)
                {
                    result.AppendFormat("{0}={1}&", item.Key, Uri.EscapeDataString(item.Value));
                }

                return result.ToString(0, result.Length - 1);
            }
        }
    }
}
