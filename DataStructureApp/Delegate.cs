using System.Data;
using System.Diagnostics.Contracts;

namespace TAP;

public delegate void CallbackDelegate(int a);

public class Deleg{
    
   public static void PerformOperation(int x,CallbackDelegate callbackDelegate){
     int result=x*2;
     callbackDelegate(result);
    }
   public static void CallBackMethod(int result){
        Console.WriteLine("Callback method:"+result);
    }
}
