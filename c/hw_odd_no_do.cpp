#include<stdio.h>
int main()
{
	int count=20;
	do
	{
		if(count%2==1)
		{
			printf("\n%d",count);
		}
		count=count+1;
		
	}
	while(count<=30);
}
