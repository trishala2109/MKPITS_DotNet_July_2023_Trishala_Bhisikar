#include<stdio.h>
int main()
{
    int num,count=1;
    printf("Enter a Number ");
    scanf("%d",&num);
    do
	{
      	printf("\n%d*%d=%d",num,count,num*count);
        count=count+1;	
		
    }
    while(count<=10);
}
