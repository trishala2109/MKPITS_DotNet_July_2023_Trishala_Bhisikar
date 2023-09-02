#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
		public:
			void getn1(int n)
			{
				n1=n;
			}
};
class classB:public classA
{
	protected:
		int n2;
		public:
			void getn2(int n)
			{
				n2=n;
			}
};
class classC
{
	protected:
		int n3;
		public:
			void getn3(int n)
			{
				n3=n;
			}
};
class classD:public classB,public classC
{
	public:
		int multiply()
		{
			int m=n1*n2*n3;
			return m;
		}
};
int main()
{
	int result;
	classD d;
	d.getn1(9);
	d.getn2(2);
	d.getn3(3);
	result=d.multiply();
	cout<<"result="<<result;
	return 0;
}
