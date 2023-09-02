#include<iostream>
using namespace std;
class Circle
{
	public:
		int r;
		
		Circle()
		{
		  r=2;	
		}
		float calculateArea()
		{
			float a=3.14f*r*r;
		    cout<<"area="<<a<<endl;
		}
		float calculateCircum()
		{
			float cirum=2*3.14f*r;
		    cout<<"circumfrence="<<cirum;
		}
};
int main()
{
	float result;
	Circle c1;
	c1.calculateArea();
	c1.calculateCircum();	
}
