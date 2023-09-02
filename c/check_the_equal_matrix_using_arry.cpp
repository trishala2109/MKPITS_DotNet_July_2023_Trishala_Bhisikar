#include<stdio.h>
int main()
{
	int arry1[2][2],arry2[2][2];
	int i,j,count=0;
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
	    	printf("enter the value in matrix 1 :");
	    	scanf("%d",&arry1[i][j]);
	    }
	}
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
	    	printf("enter the value in matrix 2 :");
	    	scanf("%d",&arry2[i][j]);
	    }
	}
	printf("\n enter the matrix 1:");
	for(i=0;i<2;i++)
	{
		 printf("\n");
		for(j=0;j<2;j++)
		{
	    	printf("%d\t",arry1[i][j]);
	    }
		  
	}
	printf("\n enter the matrix 2 :");
	for(i=0;i<2;i++)
	{
		 printf("\n");
		for(j=0;j<2;j++)
		{
	    	printf("%d\t",arry2[i][j]);
	    }
	}
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
	    	if(arry1[i][j]!=arry2[i][j]);
	    	{
	    		count=1;
			}
	    } 
	}
	printf("\n");
	 if(count==1)
	    printf("the matrix is  not equal\n");
	    else
	    printf("the matrix is equal\n");
}
