#include<stdio.h>
int main()
{
	int i,max,min,num,arry[100];
	printf("enter a number:");
	scanf("%d",&num);
	for(i=0;i<num;i++)
	{
		printf("number of value");
		scanf("%d",&arry[i]);
	}
	max=arry[0];
	min=arry[0];
	for(i=1;i<num;i++)
	{
		if(arry[i]>max)
		{
			max=arry[i];
		}
		if(arry[i]<min)
		{
			min=arry[i];
		}
	}
	printf("\n enter a maximum no =%d",max);
	printf("\n enter a minimum no =%d",min);
}
