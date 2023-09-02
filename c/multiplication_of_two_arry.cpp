#include<stdio.h>
int main()
{
	int i,j;
	int arry1[2][2]={{5,3},{2,1}};
	int arry2[2][2]={{3,1},{1,1}};
	int arry3[2][2];
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			arry3[i][j]=arry1[i][j]*arry2[i][j];
		}
	}
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("%d \t",arry3[i][j]);
		}
	} printf("\n");
}
