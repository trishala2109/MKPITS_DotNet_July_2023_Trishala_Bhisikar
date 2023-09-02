#include<stdio.h>
void calculate(int r,float *a,float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
int main()
{
	int radius;
	float circumfrance,area;
	printf("enter a radius: ");
	scanf("\n %d",&radius);
	calculate(radius,&area,&circumfrance);
	printf("\n area of circle=%f",area);
	printf("\n area of circumfrance=%f",circumfrance);
}
