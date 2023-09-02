#include<stdio.h>
int main()
{
	int i,j,sum=0;
	int arry[2][2]={{5,2},{3,4}};
	
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[i][j];
			
		}
		printf("sum of row %d=%d \n",i+1,sum);
	}
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[j][i];
			
		}
		printf("sum of coloum %d=%d \n",i+1,sum);
	}
}
