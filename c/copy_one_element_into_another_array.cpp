#include<stdio.h>
int main()
{
	int i,arry1[5],arry2[5];
	for(i=0;i<5;i++)
	{
		printf("enter a number \n");
		scanf("%d",&arry1[i]);
	}
	for(i=0;i<5;i++)
	{
		arry2[i]=arry1[i];
	}
	printf("\n enter a element of arry1");
	for(i=0;i<5;i++)
	{
		printf("\n %d",arry1[i]);
	}
	printf("\n enter a copy element of arry2");
	for(i=0;i<5;i++)
	{
		printf("\n %d",arry2[i]);
	}
}
