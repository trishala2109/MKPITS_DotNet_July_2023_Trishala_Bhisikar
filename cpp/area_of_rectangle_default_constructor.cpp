#include<iostream>
using namespace std;
class Rectangle
{
	public:
		int length;
		int width;
		int a,p;
		Rectangle()
		{
			length=2;
			width=4;
		}
		void calculateArea()
		{
			a=length*width;
			cout<<"area="<<a<<endl;
		}
		void calculateParimeter()
		{
			p=2*(length+width);
			cout<<"area of rectangle="<<p;
		}
};
int main()
{
	Rectangle r1;
	int result;
	r1.calculateArea();
	r1.calculateParimeter();
	return 0;
}
