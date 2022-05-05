namespace ReflectionSample
{
    public class NetworkMonitorSettings
    {
        public string WarningService { get; set; } = string.Empty;
        public string MethodToExecute { get; set; } = string.Empty;
        public Dictionary<string, object> PropertyBag { get; set; } =
            new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
    }
}
