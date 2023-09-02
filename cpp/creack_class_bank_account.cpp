#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int amt;
		int bal=500;
		void depositMoney()
		{
			bal=bal+amt;
			cout<<"amouth deposite the amount balance ="<<bal<<endl;
		}
		void withdrawMoney()
		{
			bal=bal-amt;
			cout<<"amount withdrawl balace ="<<bal<<endl;
		}
};
int main()
{
	bankaccount b1;
	int amt;
	int accno;
	cout<<"enter the bank account number :"<<endl;
	cin>>accno;
	cout<<"enter the amount:"<<endl;
	cin>>amt;
	b1.depositMoney();
	b1.withdrawMoney();
	return 0;
}
