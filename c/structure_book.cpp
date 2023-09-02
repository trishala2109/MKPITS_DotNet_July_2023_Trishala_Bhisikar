#include<stdio.h>
#include<string.h>
struct book
{
	char title[50],author[50];
	int bookid;
};
int main()
{
	struct book b1;
	strcpy(b1.title,"dotnet");
	strcpy(b1.author,"ashish");
	b1.bookid=123;
	printf("\n title=%s",b1.title);
	printf("\n author=%s",b1.author);
	printf("\n bookid=%d",b1.bookid);
}
