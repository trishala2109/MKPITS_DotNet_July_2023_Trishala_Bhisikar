#include<stdio.h>
int main()
{
	int i, sum=0,marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[3]=77;
	for(i=0;i<3;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n total marks=%d",sum);
}
