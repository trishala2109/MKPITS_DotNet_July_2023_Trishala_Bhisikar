#include<stdio.h>
int main()
{
	int n1=10,n2=20,temp;
	int *p1=&n1;
	int *p2=&n2;
	printf("\n before swapping *p1=%d *p2=%d",*p1,*p2);
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("\n after swapping *p1=%d *p2=%d",*p1,*p2);
}

