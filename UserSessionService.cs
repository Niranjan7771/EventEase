using System.Collections.Generic;
using EventEase.Models;

public class UserSessionService
{
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    private readonly HashSet<string> attendedEvents = new();

    public void RegisterForEvent(string eventName, string userName, string userEmail)
    {
        UserName = userName;
        UserEmail = userEmail;
        attendedEvents.Add(eventName);
    }

    public bool IsRegisteredFor(string eventName) => attendedEvents.Contains(eventName);
    public IEnumerable<string> GetRegisteredEvents() => attendedEvents;
} 