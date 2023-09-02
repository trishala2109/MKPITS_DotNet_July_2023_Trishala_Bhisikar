#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char opr;
	cout<<"enter the two numbers:"<<endl;
	cin>>n1>>n2;
	cout<<"enter the opr(+,-,*)";
	cin>>opr;
	if(opr=='+')
	{
		sum=n1+n2;
	}
	else if(opr=='-')
	{
		sum=n1-n2;
	}
	else if(opr=='*')
	{
	sum=n1*n2;
    }
    cout<<"sum="<<sum;
    
}
