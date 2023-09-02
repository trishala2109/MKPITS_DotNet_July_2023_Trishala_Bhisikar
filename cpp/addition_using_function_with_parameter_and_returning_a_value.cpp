#include<iostream>
using namespace std;
int addition(int n1,int n2)
{
	int result=n1+n2;
	return result;
}
int main()
{
char ch='y';
do
  {
  	int num1,num2,result;
    cout<<"enter the two number:";
    cin>>num1>>num2;
    result=num1+num2;
    cout<<"result="<<result<<endl;
    cout<<"do you want to another press y"<<endl;
    cin>>ch;
  }
  while(ch=='y');
}

