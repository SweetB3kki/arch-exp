using System;

namespace arch_exp
{
    internal static class DatabaseSettings
    {
        internal static string ConnectionString =>
            Environment.GetEnvironmentVariable("ARCH_EXP_CONNECTION_STRING")
            ?? throw new InvalidOperationException(
                "Set ARCH_EXP_CONNECTION_STRING before starting the application.");
    }
}
