#include<stdio.h>
int main()
{
	int arry[3][3];
	int i,j;
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("enter a number:");
			scanf("%d",&arry[i][j]);
		}
	}
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
		 printf("\n arry [%d][%d]=[%d]",i,j,arry[i][j]);
		}
	}
}
