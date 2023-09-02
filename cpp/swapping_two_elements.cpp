#include<iostream>
using namespace std;
int main()
{
	int n1=10,n2=20,temp;
	int *p1=&n1;
	int *p2=&n2;
	cout<<"before swapping"<<endl<<*p1<<endl<<*p2<<endl;
    temp=*p1;
    *p1=*p2;
    *p2=temp;
    cout<<"after swapping"<<endl<<*p1<<endl<<*p2<<endl;
}
