#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("enter any two number\n");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
int main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("result=%d",result);
		printf("\ndo you want to another ,press'y': ");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
