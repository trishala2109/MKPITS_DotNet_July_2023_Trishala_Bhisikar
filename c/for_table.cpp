#include<stdio.h>
int main()
{
	int count,num,result;
	printf("enter a number");
	scanf("%d",&num);
	for(count=1;count<=10;count++)
	{
		result=num*count;
		printf("\n%d*%d=%d",num,count,result);
		
	}
}
