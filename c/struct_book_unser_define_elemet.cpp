#include<stdio.h>
struct book
{
	char title[50],author[50];
	int bookid;
};
int main()
{
	struct book b1;
	printf("enetr the title,author,bookid:");
	scanf("\n %s",b1.title);
	scanf("\n %s",b1.author);
	scanf("\n %s",b1.bookid);
	printf("title=%s",b1.title);
	printf("author=%s",b1.author);
	printf("bookid=%d",b1.bookid);
}
