#include<stdio.h>
#include<string.h>
int main()
{
	char name[10];
	char *ptr;
	printf("enter a name:");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		printf("%c",*ptr);
		*ptr++;
	}
}
