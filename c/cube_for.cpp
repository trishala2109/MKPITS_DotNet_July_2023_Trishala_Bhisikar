#include<stdio.h>
int main()
{
  int i,num,cube;
  printf("enter a integer number\n");
  scanf("%d",&num);
  for(i=1;i<=num;i++)
  {
  	cube=i*i*i;
  	printf("\n%d cube is %d",i,cube);
  }
}
