#include<stdio.h>
int main()
{
	int count=0;
	char name [10];
	char *ptr;
	printf("enter a name:");
	gets(name);
	ptr=name;
	while(*ptr!=0)
	{
		if(*ptr>=10)
		{
			count=count+1;
		}
		ptr++;
	}
	printf("no of a length in a string = %d",count);
}
