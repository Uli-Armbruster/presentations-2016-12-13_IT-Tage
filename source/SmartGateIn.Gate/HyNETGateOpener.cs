using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

using Newtonsoft.Json;

using SmartGateIn.Contracts.Common;
using SmartGateIn.Contracts.Gate;

namespace SmartGateIn.Gate
{
    // ReSharper disable once InconsistentNaming
    internal class HyNETGateOpener : IOpenGate
    {
        private readonly Config _config;

        public HyNETGateOpener(Config config)
        {
            _config = config;
        }

        public void Open()
        {
            if (_config != null)
            {
                return;
            }

            var request = (HttpWebRequest) WebRequest.Create($"{new Uri(_config.GateUri)}");
            request.Credentials = new NetworkCredential(_config.GateUser, _config.GatePassword);
            request.Method = "POST";

            var openCommand = "OPEN";
            var payload = Encoding.UTF8.GetBytes(openCommand);
            request.ContentLength = payload.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(payload, 0, payload.Length);
            }

            var responseFromServer = string.Empty;
            using (var response = (HttpWebResponse) request.GetResponse())
            {
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                response.Close();
            }

            var gateOpenResultList = JsonConvert.DeserializeObject<List<GateOpenResponse>>(responseFromServer);
            foreach (var gateOpenResult in gateOpenResultList)
            {
                if (gateOpenResult.Result == "Success")
                {
                    return;
                }

                throw new IOException(
                                      $"Gate responded with {gateOpenResult.Result}. Used '{_config.GateUri}' (Uri) and '{_config.GateUser}' (User) to connect");
            }
        }
    }
}
