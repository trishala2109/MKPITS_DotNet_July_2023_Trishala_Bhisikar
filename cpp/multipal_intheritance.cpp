#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
		public:
			int getn1(int n)
			{
				n1=n;
			}
};
class classB
{
	protected:
		int n2;
		public:
			int getn2(int n)
			{
				n2=n;
			}
};
class classC:public classA,public classB
{
	public:
		void display()
		{
			cout<<"n1="<<n1<<endl;
			cout<<"n2="<<n2<<endl;
			cout<<"TOTAL="<<n1+n2<<endl;
		}
};
int main()
{
	classC c1;
	c1.getn1(3);
	c1.getn2(6);
	c1.display();
	return 0;
}
