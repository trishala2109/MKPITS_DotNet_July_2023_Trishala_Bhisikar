#include<stdio.h>
int main()
{
	int i,num1=0,num2=1;
	int add=num1+num2;
	printf("%d,%d",num1,num2);
	for(i=3;i<10;i++)
	{
		printf(",%d",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}        
