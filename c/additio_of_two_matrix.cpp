#include<stdio.h>
int main()
{
	int i,j;
	int arry1[2][2]={{1,2},{3,4}};
	int arry2[2][2]={{5,6},{7,8}};
	int arry3[2][2];
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			arry3[i][j]=arry1[i][j]+arry2[i][j];
		}
	}
	//display
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("%d \t",arry3[i][j]);
		}
		printf("\n");
	}
}
