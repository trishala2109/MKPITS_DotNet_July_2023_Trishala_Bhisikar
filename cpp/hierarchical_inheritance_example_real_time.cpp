#include<iostream>
using namespace std;
class account
{
	public:
		int acno,bal,intrest;
		void getdata(int a,int b,int c)
		{
			acno=a;
			bal=b;
			intrest=c;
		}
};
class saving:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+intrest+amt;
			return bal;
		}
};
class current:public account
{
	public:
		int deposite(int amt)
		{2
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int result;
	int accountno,amount,balance,ins;
	cout<<"ENTER ACCOUNT DETAILS:"<<endl;
	cin>>accountno>>balance>>ins>>amount;
	s1.getdata(accountno,balance,ins);
	result=s1.deposite(amount);
	cout<<"SAVING ACCOUNT:"<<result<<endl;
	c1.getdata(accountno,balance,ins);
	result=c1.deposite(amount);
	cout<<"CURRENT BALANCE WITHOUT INTRESTE:"<<result<<endl;
	return 0;
}
