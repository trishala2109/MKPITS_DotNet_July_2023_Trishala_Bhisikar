#include<stdio.h>
int main()
{
	int i;
	int num1;
	int num2;
	int add;
	add=num1+num2;
	printf("%d,%d", num1,num2);
	for(i=3;i<20;i++)
	{
		printf(", %d",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}
