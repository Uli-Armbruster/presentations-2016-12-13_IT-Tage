using System.IO;

using SmartGateIn.Contracts.Common;

namespace SmartGateIn.Configuration
{
    internal class Reader
    {
        public Config FromExistingFile()
        {
            var configFile = ConfigFileProperties.Filepath;

            if (!configFile.Exists)
            {
                throw new FileNotFoundException($"Config file \'{configFile}\' not found");
            }

            var content = File.ReadAllText(configFile.FullName);
            var config = new Decryption().Decrypt(content, ConfigFileProperties.EncryptionPassword);

            return config;
        }
    }
}
