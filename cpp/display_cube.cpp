#include<iostream>
using namespace std;
int main()
{
	int num,cube,i;
	cout<<"enter the integer number :";
	cin>>num;
	for(i=1;i<=num;i++)
		cube=i*i*i;
	cout<<"cube of"<<i<<"is :"<<cube<<endl;
	return 0;
}
