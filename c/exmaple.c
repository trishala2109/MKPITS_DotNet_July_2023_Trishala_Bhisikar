#include<stdio.h>
int main()
{
	int a=2;
	int b=3;
	int c=5;
	int result;
	a++;
	b++;
	c++;
	result=a++ + b++ + c++ ;
	printf("result:%d\n",result);
	printf("a:%d,b:%d,c:%d",a,b,c);
	a++;
	b++;
	++c;
	result=a++ + b++ + ++c ;
	printf("\n");
	printf("result:%d\n",result);
	printf("a:%d,b:%d,c:%d",a,b,c);
	
}
