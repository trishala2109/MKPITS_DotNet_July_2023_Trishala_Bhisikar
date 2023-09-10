#include<stdio.h>
int main()
{
	char name[20];
	char designation;
	int salary;
	printf("Enter employe name:\n");
	scanf("%s",&name);
	fflush(stdin);
	printf("Enter designation (m, c, p):\n");
	scanf("%c",&designation);
	switch(designation)
	{
		case'm':
			salary=50000;
			break;
		case'c':
		    salary=20000;
		    break;
		case'p':
		    salary=10000;
		    break;
	}
	printf("Employe=%s\n",name);
	printf("Salary=%d",salary);
}
