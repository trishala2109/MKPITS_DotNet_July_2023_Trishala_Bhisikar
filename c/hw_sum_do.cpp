#include<stdio.h>
int main()
{
	int count=10,sum=0;
	do
	{
		sum=sum+count;
		count=count+1;
	}
	while(count<=20);
	printf("sum=%d",sum);
}
