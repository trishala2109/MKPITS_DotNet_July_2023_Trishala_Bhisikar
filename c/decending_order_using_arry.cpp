#include<stdio.h>
int main()
{
	int i,j,temp,arry[5];
	
	for(i=0;i<5;i++)
	{
		printf("enter a number :");
		scanf("%d",&arry[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i;j<5;j++)
		{
			if(arry[j]<arry[i])
			{
		    	temp=arry[i];
		    	arry[i]=arry[j];
		    	arry[j]=temp;
	     	}
		}
	}
	printf("\n element in decending order is :");
	for(i=0;i<5;i++)
	{
		printf("%d",arry[i]);
	}
}
