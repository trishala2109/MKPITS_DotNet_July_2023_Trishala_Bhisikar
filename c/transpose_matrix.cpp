#include<stdio.h>
int main()
{
	int i,j;
	int arry[3][3];
	int trans[3][3];
	
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("enter a number:");
		    scanf("%d",&arry[i][j]);
		}
	}
	printf("original matrix :\n");
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("%d \t",arry[i][j]);
		}
		printf("\n");
	}
	
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
		 trans[j][i]=arry[i][j];
		}
		printf("\n");
	}
	printf("transpose matrix :\n");
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("%d \t",trans[i][j]);
		}
		printf("\n");
	}	
}
