using System.Reflection.Metadata.Ecma335;

namespace TAP;
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Salary{get;set;}
    public bool IsManager{get;set;}
    public static List<Employee> GetEmployees(){
    List<Employee> employees=new List<Employee>();

     employees.Add(new Employee{Id=1,Name="Abhay",Salary="20000",IsManager=true});
     employees.Add(new Employee{Id=2,Name="Abhay",Salary="20000",IsManager=true});
     employees.Add(new Employee{Id=3,Name="Abhay",Salary="20000",IsManager=true});
     employees.Add(new Employee{Id=4,Name="Abhay",Salary="20000",IsManager=true});


     return employees;
    }
    
     public override string ToString(){
        return Id +" "+Name+" "+" "+Salary+ " "+IsManager;
     }
    
}