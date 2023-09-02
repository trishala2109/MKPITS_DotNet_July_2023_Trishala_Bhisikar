#include<stdio.h>
int main()
{
	int i,sum=0,marks[5];
	for(i=0;i<5;i++)
	{
		printf("enter a marks \n");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n total marks=%d",sum);
}
