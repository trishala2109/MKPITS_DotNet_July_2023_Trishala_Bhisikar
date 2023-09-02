#include <iostream>
using namespace std;
void calculte (float *a,float *c,int r)
{
	*a =3.14*r*r;
	*c=2*3.14*r;
}
int main()
{
	int radius;
	float area,circumfrence;
	cout<<"enter the radius";
	cin>>radius;
	calculte(float *a,float *c,int r);
	cout<<"area="<<area;
	cout<<"area="<<circumfrence;
}
