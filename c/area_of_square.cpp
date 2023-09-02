#include<stdio.h>
void area(int num)
{
	int result=num*num;
	printf("area of square=%d",result);
}
int main()
{
	int num;
	printf("enter a two number\n");
	scanf("\n %d",&num);
	area(num);
}

