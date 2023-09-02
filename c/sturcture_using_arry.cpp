#include<stdio.h>
struct student
{
	int rno;
	char name[5];
};
int main()
{
	struct student stud[5];
	int count;
	for(count=0;count<5;count++)
	{
		printf("enter a roll number :");
		scanf("\n %d",&stud[count].rno);
		printf("enter a  name :");
		scanf("\n %s",&stud[count].name);
	}
	printf("\n student of data :");
	for (count=0;count<5;count++)
	{
		printf("\n roll no=%d",stud[count].rno);
		printf("\n name=%s",stud[count].name);
	}
}
