#include<stdio.h>
int main()
{
	int count=2,num,rem=0;
	for(num=3;num<20;num++)
	{
		count=2;
	    while(count<num)
	    {
	    	rem=num%count;
	    	if(rem==0)
	    	{
	    		break;
			}
			count++;
		}
		if(num==count)
		{
			printf("%d is a prime number \n",num);
		}
	}
}
