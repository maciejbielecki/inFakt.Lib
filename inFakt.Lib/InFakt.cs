namespace inFakt.Lib
{
    public enum ApiType
    {
        Sandbox,
        Production
    }

    public class InFakt
    {
        public InFakt(string apiKey, ApiType type)
        {
            Config = new(apiKey, type);
        }

        public Config Config { get; set; }
    }

    public class Config
    {
        public Config(string apiKey, ApiType type)
        {
            ApiKey = apiKey;
            IsSandbox = type == ApiType.Sandbox;
        }

        public bool IsSandbox { get; } = true;
        public string ApiKey { get; }
    }
}
