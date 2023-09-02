#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		virtual void deposite(int amt)=0;
};
class Saving:public Account
{
	public:
		void deposite(int amt)
		{
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"amount with intrest:"<<bal<<endl;
		}
};
class Current :public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"amount without intrest:"<<bal<<endl;
		}
};
int main()
{
	Account *A;
	Saving s;
	A=&s;
	A->accno=456;
	A->bal=1000;
	A->deposite(500);
	
	Current c;
	A=&c;
	A->accno=564;
	A->bal=2000;
	A->deposite(1000);
	return 0;
}
