namespace SKIT.FlurlHttpClient.Upyun.Uss.Utilities
{
    internal static class HttpRequestGuard
    {
        public static void AgainstEmptyPathVariable(string? varValue, string varName)
        {
            if (string.IsNullOrEmpty(varValue))
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        public static void AgainstEmptyPathVariable(long? varValue, string varName)
        {
            if (varValue.GetValueOrDefault() == 0)
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        private static string NormalizePathName(string segment)
        {
            if (segment is not null && !segment.StartsWith("{") && !segment.EndsWith("}"))
                segment = "{" + segment + "}";
            return segment ?? "{}";
        }
    }
}
