
#include<stdio.h>
int main()
{
	int num=1,count=20,rem;
    while(count<=20)
    {
    	rem=num%count;
    	if(rem==count)
    	{
    		printf("%d",num);
    		break;
		}
    	count=count+1;
	}
	
}
