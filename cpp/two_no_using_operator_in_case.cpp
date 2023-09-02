#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char opr;
	cout<<"enter the two number:\n";
	cin>>n1>>n2;
	cout<<"enter the operator:";
	cin>>opr;
	switch (opr)
	{
		case '+':
			sum=n1+n2;
			break;
		case '-':
			sum=n1-n2;
			break;
		case '*':
		    sum=n1*n2;
			break;
		
	}
	cout<<"sum="<<sum;
}
