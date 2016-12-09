using System.IO;
using System.Reflection;

namespace SmartGateIn.Configuration
{
    internal static class ConfigFileProperties
    {
        /// <summary>
        ///     Password for AES Encryption.
        /// </summary>
        internal static string EncryptionPassword => @"Le0gistics.com";

        /// <summary>
        ///     Convention: the file SmartGateIn.config has to be in the same directory as the executables
        /// </summary>
        internal static FileInfo Filepath
        {
            get
            {
                var file =
                    new FileInfo(
                                 $"{new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName}\\SmartGateIn.config");

                return file;
            }
        }
    }
}
