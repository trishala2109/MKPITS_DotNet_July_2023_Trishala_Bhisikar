#include<iostream>
using namespace std;
class Circle
{
	public:
		int r;
		float calculateArea()
		{
		   float a=3.14f*r*r;
		   return r;
		}
		float calculateCircum()
		{
			float circum=2*3.14f*r;
			return circum;
		}
};
int main()
{
	float result;
	Circle c1;
	
	cout<<"enter the Radius:";
	cin>>c1.r;
	result=c1.calculateArea();
	cout<<"Area="<<result<<endl;
	
	result=c1.calculateCircum();
	cout<<"circumfrence of circle="<<result;
}
