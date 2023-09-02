#include<stdio.h>
int area(int num)
{
	int result=num*num;
	return result;
}
int main()
{
	int num,result;
	printf("enter a number\n");
	scanf("\n %d ",&num);
	result=area(num);
	printf("\n result=%d",result);
}
