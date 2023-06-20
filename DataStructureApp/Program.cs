using System.Text.Json;
//Array =an array is a collection of items of same data type stored in contiguous memory location
// //once the array  gives a size we cannot change
// //array is static  ,list is dynamic
// int[] arr=new int[10];
// // int[] arr1={3,5,4,5,3};
// // Console.WriteLine(arr1.Length);
// // arr1[0]=1;
// //  arr[11]=67;
// //  arr1[5]=67;   //index outside the bound 5=index 
// // System.Console.WriteLine(string.Join(",",arr1));

// arr[0]=34;
// arr[1]=43;
// arr[2]=12;
// arr[3]=90;
// arr[4]=24;
// arr[5]=90;
// arr[6]=99;
// arr[7]=66;
// arr[8]=33;
// arr[9]=67;
// for (int i=0;i<arr.Length;i++){
//     if(arr[i]==90){
//     System.Console.WriteLine(i);    
//     //linear search  O(n) time complexity  //if i<any index number thren its TC is O(1)  
//     }
// }


// //array initilization
// int[] arr1={1,1,2,3,3};    //By passing specific values within the initializer but not declaring the size
// // int[5] arr3= {};           //passing no values to the initializer
// double result=641.9330164733651*47.00816872623578;
// result+=2471.4257370880114;
// System.Console.WriteLine(result);


// Deleg.PerformOperation(5,Deleg.CallBackMethod);
// DeEvent publisher=new DeEvent();
// EventSubscriber subscriber=new EventSubscriber();
// publisher.EventHandler+=subscriber.EventHandle;
// publisher.DoSomething();
// var myval=10;
// System.Console.WriteLine(myval.GetType());     // type of value determines at compile time
// dynamic myvalue="hello";
// string a2=myvalue;
// System.Console.WriteLine(myvalue.GetType());   //type of value determine at runtime
// System.Console.WriteLine(a2);
// object myobject="shubham";
// string name=myobject.ToString();
// System.Console.WriteLine(name);

// int x=21;
// int y=5;
// //double a=x/y;             //answer=4 
//  double a=(double)x/y;       //explicit conversion  answer=4.2    //(datatype)=casting
// System.Console.WriteLine(a);

// double x1=20;
// double y1=3;
// int a1=(int)(x1/y1);
// System.Console.WriteLine(a1);

// double b=12.54;
// int c=10;
// b=b+c;
// System.Console.WriteLine(b);     //implicit conversion int c converted to double by compiler
// int[] arr={10,20,30,40,50,60,70,80,90};
// int x=BSearch.Search(arr,30);
// Console.WriteLine(x);

// var employee1=Employee.GetEmployees();
// foreach(var e in employee1){
//     System.Console.WriteLine(e);
// }
//  using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         ReverseString reverseString = new ReverseString();
//         string reversed = reverseString.ReverseStr("Abhya");
//         Console.WriteLine(reversed);
//     }
// }

// public class ReverseString
// {
//     public string ReverseStr(string str)
//     {
//         char[] charArray = str.ToCharArray();
//         for (int i = 0, j = str.Length - 1; i < j; i++, j--)
//         {
//             char temp = charArray[i];
//             charArray[i] = charArray[j];
//             charArray[j] = temp;
//         }
//         return new string(charArray);
//     }
// }

using TAP;
Employee employee=new Employee(){
Id=2,Name="asd",Salary="5677",IsManager=true
};
string fileName=@"C:\Users\naval\OneDrive\Desktop\DataStructureApp\employee.json";
string jsonString=JsonSerializer.Serialize(employee);
File.WriteAllText(fileName,jsonString);
System.Console.WriteLine(File.ReadAllText(fileName));
System.Console.WriteLine(employee);
