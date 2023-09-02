#include<iostream>
using namespace std;
class number
{
	public:
		int mul(int i,int j)
		{
			return i*j;
		}
		float mul(float i,float j)
		{
			return i*j;
		}
};
int main()
{
	number n1;
	cout<<"enter the interger number :"<<n1.mul(5,9)<<endl;
	cout<<"enter the float number :"<<n1.mul(1.2f,2.2f)<<endl;
	return 0;
}
