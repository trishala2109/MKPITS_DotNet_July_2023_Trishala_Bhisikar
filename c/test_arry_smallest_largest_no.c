#include <stdio.h>

int main() 
{
    int size, i;
    int arr[size];
    int largest = arr[0];
    int smallest = arr[0];
    
    printf("Enter the size of the array: ");
    scanf("%d", &size);
    
    printf("Enter %d elements:\n", size);
    for(i = 0; i < size; i++) 
	{
        scanf("%d", &arr[i]);
    }
    
    for(i = 1; i < size; i++)
	 {
        if(arr[i] > largest) 
		{
            largest = arr[i];
        }
        if(arr[i] < smallest)
	    {
            smallest = arr[i];
        }
     }
     
    printf("Largest element in the array: %d\n", largest);
    printf("Smallest element in the array: %d\n", smallest);
    
    return 0;
}

