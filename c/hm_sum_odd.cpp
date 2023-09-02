#include<stdio.h>
int main()
{
	int num,i,sum=0;
	printf("enter a number\n");
	scanf("%d",&num);
	
	printf("\n sum of odd number from 0 to %d are ",num);

	for(i=1;i<=num;i++)
	{
		if(i%2==1)
		{
			printf("\n %d",i);
			sum=sum+i;
			
		}
		
	}
	printf("\n sum of odd number from 1 to %d = %d ",num,sum);
}
