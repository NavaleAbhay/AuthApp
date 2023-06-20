using System.Xml.Schema;

namespace TAP;
public delegate void EventHandlerDelegate(string message);
public class DeEvent{
    public event EventHandlerDelegate EventHandler;

    public void DoSomething(){
        EventHandler.Invoke("Event raised from shubham");
        System.Console.WriteLine("hii");
    }
}

public class EventSubscriber{
    public void EventHandle(string message){
        System.Console.WriteLine("EventSubscriber received event :"+message);
    }
}