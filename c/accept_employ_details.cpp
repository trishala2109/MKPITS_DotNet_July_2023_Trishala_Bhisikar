#include<stdio.h>
struct employe
{
	char name[20];
	char post[20];
	char department[20];
	int empid,salary;
};
int main()
{   
    struct employe emp[100];
	int count,num;
	printf("enter the no of employe:");
	scanf("%d",&num);
	printf("enter employe data:employeId, Name, Post, Department, salary\n");
	for(count=0;count<num;count++)
	{
    	scanf("%d %s %s %s %d",&emp[count].empid,emp[count].name,emp[count].post,emp[count].department,&emp[count].salary);
    }
    printf("\n employeID\t name\t post\t department\t salary\n");
    
    for(count=0;count<num;count++)
  {
     printf("\n %d \t %s \t %s \t %s \t %d \n",emp[count].empid,emp[count].name,emp[count].post,emp[count].department,emp[count].salary);
  } 
}
