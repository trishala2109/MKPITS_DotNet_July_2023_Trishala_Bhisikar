#include<iostream>
using namespace std;
class Rectangle
{
	public:
		
		int length;
		int width;
		void calculateArea()
		{
			int a=length*width;
		    cout<<"area="<<a<<endl;
		}
		void calculateParimete()
		{
		    int	p=2*(length+width);
		    cout<<"parimeter="<<p;
		}
};
int main()
{
	Rectangle r1;
	int result;
	cout<<"enter the length :"<<endl;
	cout<<"enter the width:"<<endl;
	cin>>r1.length;
	cin>>r1.width;
	r1.calculateArea();
	r1.calculateParimete();
	return 0;
}
