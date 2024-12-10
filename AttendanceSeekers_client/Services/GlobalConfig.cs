using System;

public class GlobalConfig
{
    private static GlobalConfig _instance;
    private static readonly object _lock = new object();

    public HttpClient HttpClient { get; private set; }
    public string Token { get; set; } = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImI4MjA5MTdjLTJiN2QtNDAwZC04MjQ5LTkzZTJjMWExOGU2OCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJteXNlbGYiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTczNDQyODMxOH0.TIh3UMAj8ihBB4PLiM22Dak1psw5Yi-0WXaVKbLNIPM";
    public string role { get; set; }
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