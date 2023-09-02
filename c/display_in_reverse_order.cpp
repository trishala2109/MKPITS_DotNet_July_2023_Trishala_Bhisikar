#include<iostream>
using namespace std;
int main()
{
	int n,i,nums[100];
	cout<<"enter the number";
	cin>>n;
	//accepting value
	for(i=0;i<n;i++)
	{
		cout<<"enter the number:";
		cin>>nums[i];
	}
	for(i=n-1;i>=0;i--)
	{
		cout<<"number="<<nums[i]<<endl;
	}
}
