#include<stdio.h>
int main()
{
	int i,n,nums[100];
	printf("enter a number \n");
	scanf("%d",&n);
	//accepting the value
	for(i=0;i<n;i++)
	{
		printf("enter number \n");
		scanf("%d",&nums[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n arry is reverse number =%d",nums[i]);
	}
			}
