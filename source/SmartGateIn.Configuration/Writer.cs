using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using SmartGateIn.Contracts.Common;
using SmartGateIn.Contracts.Common.Returnables;

namespace SmartGateIn.Configuration
{
    internal class Writer
    {
        public static void ToFile(Config config)
        {
            try
            {
                var serializedConfig = JsonConvert.SerializeObject(config, Formatting.Indented, IgnoreComplexType(typeof(CheckInProcessType)));
                var encryptedConfig = Encryption.Encrypt(serializedConfig, ConfigFileProperties.EncryptionPassword);
                File.WriteAllText(ConfigFileProperties.Filepath.FullName, encryptedConfig);
            }
            catch (Exception ex)
            {
                throw new Exception("Can't write new config", ex);
            }
        }

        private static JsonSerializerSettings IgnoreComplexType(Type type)
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new DynamicContractResolver(type)
            };
        }

        private class DynamicContractResolver : DefaultContractResolver
        {
            private readonly Type _type;

            public DynamicContractResolver(Type type)
            {
                _type = type;
            }

            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var properties = base.CreateProperties(type, memberSerialization);
                // only serializer properties that are not named after the specified property.
                Debug.WriteLine(properties.Count);
                properties = properties.Where(p => p.PropertyType != _type).ToList();
                Debug.WriteLine(properties.Count);

                return properties;
            }
        }
    }
}
