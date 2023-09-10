#include<stdio.h>
void reverse (int i);
int main()
{
	reverse(5);
	
}
void reverse(int i)
{
	if(i<1)
	return;
	printf("%d",i);
	return reverse (i-1);
}
