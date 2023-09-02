#include<stdio.h>
struct bank
{
	char name[20];
	int acno,bal;
};
void printbank (struct bank b)

{
	int i,num;
	printf("enter a name :");
	scanf("%d",num);
	for(i=0;i<num;i++)
	{
		if(b[i].bal<100)
        {
	       printf("Account Number:%d\n",b[i].acno);
           printf("Name:%s\n",b[i].name);
           printf("Balance:%d\n",b[i].bal);
        }
	}
	printbank(b[i]);
}
int main()
{ 
int i;
   for(i=0;i<3;i++)
   {
      printf("Enter Details of Customer %d\n",i+1);
      printf("Enter Account Number :");
      scanf("%d",&b[i].acno);
      printf("Enter Name :");
      scanf("%s",b[i].name);
      printf("Enter Balance:");
      scanf("%d",&b[i].bal);
   }
}
