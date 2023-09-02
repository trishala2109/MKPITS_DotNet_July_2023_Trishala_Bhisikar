#include<stdio.h>
int main()
{
	int count=0,i,j,arry[5];
	for(i=0;i<5;i++)
	{
		printf("enter a number :");
		scanf("%d",&arry[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arry[i]==arry[j])
			{
				count++;
				break;
			}
		}
	}
	printf("\n number of duplicate element=%d",count);
}
