#include<stdio.h>
int main()
{
	int i,j,temp,arry[10];
	
	for(i=0;i<10;i++)
	{
		printf("enter a number :");
		scanf("%d",&arry[i]);
	}
	for(i=0;i<10;i++)
	{
		for(j=i+1;j<10;j++)
		{
			if(arry[j]<arry[i])
			{
		    	temp=arry[i];
		    	arry[i]=arry[j];
		    	arry[j]=temp;
	     	}
		}
	}
	printf("\n element in assending order is ");
	for(i=0;i<10;i++)
	{
		printf("%d",arry[i]);
	}
	
	
}
