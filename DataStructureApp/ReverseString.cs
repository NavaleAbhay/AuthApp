namespace TAP;
public class ReverseString{
    public static void ReverseStr(String str){
        char[] charArray=str.ToCharArray();
        for (int i=0,j=str.Length -1;i<j;i++,j--){
            charArray[i]=str[j];
            charArray[j]=str[i];
        }  
        string reversedstring = new string(charArray);  
    Console.WriteLine(reversedstring);   
    }
}