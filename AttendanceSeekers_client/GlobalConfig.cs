using System;

public class GlobalConfig
{
    private static GlobalConfig _instance;
    private static readonly object _lock = new object();

    public HttpClient HttpClient { get; private set; }

    private GlobalConfig()
    {
        HttpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7241/")
        };
    }

    public static GlobalConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GlobalConfig();
                    }
                }
            }
            return _instance;
        }
    }
}