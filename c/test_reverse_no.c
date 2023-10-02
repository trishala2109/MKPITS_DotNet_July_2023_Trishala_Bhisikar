#include <stdio.h>
int main() 
{
    int num;
	int reversedNumber = 0; 
	int remainder;
    
    printf("Enter a positive integer: ");
    scanf("%d", &num);
    
    if (num <= 0) 
	{
        printf("Error: Please enter a positive integer.\n");
    } 
	else
	 {
        while (num != 0) 
		{
            remainder = num % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            num /= 10;
        }
        printf("Reversed number: %d\n", reversedNumber);
    }
    
}

