using System;
using System.Collections.Generic;

interface INotifier
{
    string Channel { get; }
    void Send(string to, string message);
} 

class EmailNotifier : INotifier
{
    public string Channel => "Email";
    public void Send(string to, string msg)
        => Console.WriteLine($"Mail {to}: {msg}");
}

class SmsNotifier : INotifier
{
    public string Channel => "SMS";
    public void Send(string to, string msg)
        => Console.WriteLine($"Text {to}: {msg}");
}

class PushNotifier : INotifier
{
    public string Channel => "Push";
    public void Send(string to, string msg)
        => Console.WriteLine($"Push notification to {to}: {msg}");
}

class Alerts
{
    private readonly List<INotifier> _channels;

    public Alerts(List<INotifier> channels)
        => _channels = channels;

        public void Broadcast(string to, string msg)
        {
            foreach (INotifier n in _channels)
              n.Send(to, msg);
                
             
        }
}

class Program
{
    static void Main(string[] args)
    {
        List<INotifier> channels = new List<INotifier>
        {
            new EmailNotifier(),
            new SmsNotifier(),
            new PushNotifier()
        };

        Alerts alerts = new Alerts(channels);

        alerts.Broadcast(
            "Lislie",
            "Your notification has been sent."
        );
    }
}