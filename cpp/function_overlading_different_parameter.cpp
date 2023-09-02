#include<iostream>
using namespace std;
class Calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
		}
};
int main()
{
	Calculation c;
	cout<<"enter integer numbers:"<<c.add(5,6)<<endl;
	cout<<"enter the float numbers:"<<c.add(2.9f,3.4f);
	return 0;
}
