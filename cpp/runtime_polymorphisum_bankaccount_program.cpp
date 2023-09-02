#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		virtual void deposite(int amt)
		{
			cout<<"hello from account depositer"<<endl;
		}
};
class Saving:public Account
{
	public:
		void deposite(int amt)
		{
			int intrest;
			bal=bal+amt+intrest;
			cout<<"Amount with intrest:"<<endl<<bal<<endl;
			cout<<endl;
		}
};
class Current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"Amount without intrest:"<<endl<<bal<<endl;
		}
};
int main()
{
	Account *A;
	Saving s;
	Current c;
	A=&s;
	A->accno=456;
	A->bal=1000;
	A->deposite(500);
	A=&c;
	A->accno=985;
	A->bal=2000;
	A->deposite(1000);
	return 0;
}
