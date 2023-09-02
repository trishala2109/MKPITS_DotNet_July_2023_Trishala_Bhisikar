#1include<stdio.h>
struct book
{
	char title[50],author[50];
	int bookid;
};
void printbook(struct book *ptr);
int main()
{
	struct book b1;
	printf("enetr the title,author,bookid:");
	scanf("\n %s",b1.title);
	scanf("\n %s",b1.author);
	scanf("\n %s",b1.bookid);
	printbook(&b1);
}
void printbook(struct book *ptr)
{
	printf("title=%s",ptr->title);
	printf("author=%s",ptr->author);
	printf("bookid=%d",ptr->bookid);
}
