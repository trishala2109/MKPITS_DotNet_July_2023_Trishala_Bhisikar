#include<stdio.h>
struct worker
{
	char name[20];
	int wage,wday;
};
int main()
{
	struct worker n1,n2;
	int w1,w2;
	printf("Enter the first worker details:\n");
	printf("enter the first worker :");
	scanf("%s",n1.name);
	printf("enter the wage of first worker :");
	scanf("%d",&n1.wage);
	printf("enter the working days :");
	scanf("%d",&n1.wday);
	printf("\n");
	
	printf("Enter the second worker details:\n");
	printf("enter the second worker :");
	scanf("%s",n2.name);
	printf("enter the wage of second worker :");
	scanf("%d",&n2.wage);
	printf("eneter the second worker working days :");
	scanf("%d",&n2.wday);
	printf("\n");
	
	w1=n1.wage*n1.wday;
	printf("first worker=%s\n payment of first worker=%d\n",n1.name,w1);
	
	w2=n2.wage*n2.wday;
	printf("second worker=%s\n payment of second worker=%d\n",n2.name,w2);
	
}
