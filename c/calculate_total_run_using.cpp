#include<stdio.h>
struct cricket
{
	char name[20];
	int run;
};
int main()
{
	struct cricket cri[];
	int i,sum=0;
	printf("enter the name:\n");
	scanf("%s",cri.name);
	printf("enter the run:\n");
	scanf("%d".&cri.run);
	
	for(i=0;i<11;i++)
	{
		sum=sum+cri.run;
	}
	printf("calculat the total run=%d",cri.run);
}
