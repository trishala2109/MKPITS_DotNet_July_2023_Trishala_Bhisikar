#include<stdio.h>
void foo();
int main()
{
	void foo(int);
	foo(1);
	return 0;
}
int foo(int i)
{
	printf("2");
}
