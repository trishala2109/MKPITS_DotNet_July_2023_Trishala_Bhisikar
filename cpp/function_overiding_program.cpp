#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		void deposite(int amt)
		{
			cout<<"hello from account deposite"<<endl;
		}
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
	Saving s;
	s.accno=456;
	s.bal=1000;
	s.deposite(500);
	
	Current c;
	c.accno=564;
	c.bal=2000;
	c.deposite(1000);
	return 0;
}
