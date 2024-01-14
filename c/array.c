#include<stdio.h>
int main()
{
	int arry[5],i,j,count=0;
	for(i=0;i<5;i++)
	{
		printf("enter a number :");
		scanf("%d",&arry[i]);
	}
	for(i=0;i<5;i++)
	{
		count=0;
		for(j=i+1;j<5;j++)
		{
			if(arry[i]!=arry[j])
			{
				if(arry[i]==arry[j])
				{
			    	count++;
		    	}
			}
		}
	}
    if(count==0)
    {
	  printf("\n number of unique element= %d",count);
    }
}
