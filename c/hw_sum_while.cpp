#include<stdio.h>
int main()
{
	int count=10,sum=0;
	while(count<=20)
	{
		sum=sum+count;
		count=count+1;
	}
	printf("sum=%d",sum);
}
