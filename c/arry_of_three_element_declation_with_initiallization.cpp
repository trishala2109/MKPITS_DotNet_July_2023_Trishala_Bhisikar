#include<stdio.h>
int main()
{
	int sum=0,i,marks[3]={80,70,50};
	for(i=0;i<3;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n total marks=%d",sum);
}
