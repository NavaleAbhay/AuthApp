using System.ComponentModel.DataAnnotations;

namespace TAP;
public class BSearch{
    public static int Search(int[] arr,int key){
        int left = 0;
        int right=arr.Length-1;
        while(left<=right){
             int mid  =(left+right)/2;

                  if(arr[mid]>key){
                    right=mid-1;
                  }
                  if(arr[mid]<key){
                    left=mid+1;
                  }
                  else if(arr[mid]==key){
                    return mid;
                  }
        }
        return -1;
    }
}