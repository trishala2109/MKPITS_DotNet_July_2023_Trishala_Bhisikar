#include<stdio.h>

void area()
{
	int num,result;
	printf("enter a number\n");
	scanf("%d",num);
	result=num*num;
	printf("area of square=%d",result);
}
int main()
{
	int result=0,num;
	area(num,result);
}
