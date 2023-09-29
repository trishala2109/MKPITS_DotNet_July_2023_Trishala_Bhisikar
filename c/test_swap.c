#include <stdio.h>
int main() 
{
    int num1, num2, temp;

    printf("Enter the first integer: ");
    scanf("%d", &num1);
    printf("Enter the second integer: ");
    scanf("%d", &num2);

    temp = num1;
    num1 = num2;
    num2 = temp;

    printf("After swapping:\n");
    printf("First integer: %d\n", num1);
    printf("Second integer: %d\n", num2);

    return 0;
}

