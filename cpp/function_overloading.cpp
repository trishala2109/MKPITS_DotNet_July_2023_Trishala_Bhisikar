#include<iostream>
using namespace std;
class Calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		int add(int n1,int n2,int n3)
		{
			return n1+n2+n3;
		}
};
int main()
{
	Calculation c;
	cout<<"enter two numbers:"<<c.add(5,6)<<endl;
	cout<<"enter the three numbers:"<<c.add(2,3,4);
	return 0;
}
