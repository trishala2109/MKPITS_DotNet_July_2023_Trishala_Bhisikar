#include<stdio.h>
int main()
{
	int n1, n2,sum,count;
	int *p1=&n1;
	int *p2=&n2;
	printf("enter a two number:\n");
	scanf("%d %d",&*p1,&*p2);
	while(count>=sum)
	{
	  sum=*p1+*p2;
	  
    }
	printf("addition of two number=%d",sum);
}
