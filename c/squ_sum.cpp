#include<stdio.h>
int main()
{
  int n,sum=0;
  printf("Enter n value = ");
  scanf("%d",&n);
  for(int i=0;i<=n;i++)
  {
     sum+=(i*i);
  }
  printf("Sum of squares of first %d natural numbers = %d",n,sum);
}
  
