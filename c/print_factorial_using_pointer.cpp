#include<stdio.h>
int main()
{
	int num,fact=1;
	int *ptr=&fact;
	printf("enter a number:");
	scanf("%d",&num);
	while(num>0)
	{
		*ptr=*ptr*num;
		num=num-1;
	}
	printf("fact=%d",*ptr);
}
