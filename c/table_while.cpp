#include<stdio.h>
int main()
{
    int num,count=1;
    printf("Enter a Number ");
    scanf("%d",&num);
    while(count<=10)
	{
      	printf("\n%d*%d=%d",num,count,num*count);
        count=count+1;	
		
    }
}
