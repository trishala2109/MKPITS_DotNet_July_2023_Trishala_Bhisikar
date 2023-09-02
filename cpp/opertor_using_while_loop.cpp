#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0,count;
	char opr;
	cout<<"enter the two numbers:"<<endl;
	cin>>n1>>n2;
	cout<<"enter the operator:"<<endl;
	cin>>opr;
	while(count>sum)
	{
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
	}
	
	cout<<"sum="<<sum;
}
