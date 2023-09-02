#include<stdio.h>
int area()
{
	int num;
	printf("enter a number\n");
	scanf("%d",&num);
	int result=num*num;
	return result;
}
int main()
{
	int result;
	result=area();
	printf("\n result=%d",result);
	
}
