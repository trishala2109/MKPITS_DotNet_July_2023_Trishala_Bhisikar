#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		static float roi;
		Account(int accno, int bal)
		{
			this->accno=accno;
			this->bal=bal;
		}
		void display()
		{
			cout<<"enter the account number:"<<accno<<endl;
			cout<<"balance amount:"<<bal<<endl;
			cout<<"rate of interest:"<<roi<<endl;
		}
};
float Account::roi=9.5f;
int main()
{
	Account a1=Account(123,2000);
	Account a2=Account(564,3000);
	a1.display();
	a2.display();
	return 0;
}
