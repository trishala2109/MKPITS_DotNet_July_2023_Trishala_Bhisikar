#include<iostream>
using namespace std;
void deposite(int amt,int bal);
void withdrawl(int amt,int bal);
int main()
{
	int amt,bal=1000;
	cout<<"enter the amount:";
	cin>>amt;
	deposite(amt,bal);
	withdrawl(amt,bal);
}
void deposite(int amt,int bal)
{
	bal=bal+amt;
	cout<<"amount deposite balanace is="<<bal<<endl;
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	cout<<"amount withdrawl balance is="<<bal<<endl;
}
