#include<stdio.h>
int main()
{
	int n1=9,n2=5,*p1=&n1,*p2=&n2;
	printf("\n before swapping *p1=%d *p2=%d",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("\n after sapping *p1=%d *p2=%d",*p1,*p2);
	
}
