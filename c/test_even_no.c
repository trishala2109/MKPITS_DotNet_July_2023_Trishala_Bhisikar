#include <stdio.h>

int main() {
    int num, sum = 0 ,i;
    
    // Ask user for input
    printf("Enter a positive integer: ");
    scanf("%d", &num);
    
    // Validate input
    if (num <= 0)
    {
        printf("Invalid input. Please enter a positive integer.\n");
    } 
	else
    {
        // Calculate sum of even numbers
        for ( i = 2; i <= num; i += 2)
	    {
            sum += i;
        }
        
        // Print the sum
        printf("Sum of even numbers between 1 and %d is: %d\n", num, sum);
    }
    
    return 0;
}

