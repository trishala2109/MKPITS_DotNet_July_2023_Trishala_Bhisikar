#include<stdio.h>
int main()
{
	int num,rem=0,count=2;
	printf("enter number");
	scanf("\n%d",&num);
	while(count<num)
	{
		rem=num%count;
		if(rem==0)
		{
			printf("not a prime no");
			break;
		}
		count=count+1;
	}
	if(num==count)
	{
		printf("it is a prime no");
	}
}
