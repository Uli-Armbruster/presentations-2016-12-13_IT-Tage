using System;

namespace SmartGateIn.Contracts
{
    public static class DebugEnvironment
    {
        public static Tuple<bool, string> UseFakeGate()
        {
            return UseFake("EnvUseFakeGate");
        }

        public static Tuple<bool, string> UseLocalTestDataInsteadOfBackend()
        {
            return UseFake("EnvUseLocalTestData");
        }

        public static Tuple<bool, string> UseDebugConfig()
        {
            return UseFake("EnvUseDebugConfig");
        }

        public static Tuple<bool, string> UseFakeDaemon()
        {
            return UseFake("EnvUseFakeDaemon");
        }

        public static Tuple<bool, string> UseFakeBackgroundApplicationState()
        {
            return UseFake("EnvUseFakeBackgroundApplicationState");
        }

        public static Tuple<bool, string> DontSaveChanges()
        {
            return UseFake("EnvDontSaveChanges");
        }

        private static Tuple<bool, string> UseFake(string variableName)
        {
            var value = Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User);

            return value == null
                       ? new Tuple<bool, string>(false, string.Empty)
                       : new Tuple<bool, string>(true, value);
        }        
    }
}
