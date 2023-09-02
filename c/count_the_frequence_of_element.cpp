#include<stdio.h>
int main()
{
	int i,j,count;
	int arry[5],f[5];
	for(i=0;i<5;i++)
	{
		printf("enter a number : ");
		scanf("%d",&arry[i]);
		f[i]=-1;
	}
	for(i=0;i<5;i++)
	{
		count=1;
		for(j=i+1;j<5;j++)
		{
		  if(arry[i]==arry[j])
		  {
		  	count++;
		  	f[j]=0;
		  }	
		  if(f[j]!=0)
		  {
		  	f[i]=count;
		  }
		}
	}
	for(i=0;i<5;i++)
	{
		if(f[i]!=0)
		{
			printf("frequence %d is %d",arry[i],f[i]);
		}
	}
}
