#include<iostream>
using namespace std;
class Employee
{
	//constructor
	public:
	Employee()
	{
		cout<<"constructor called"<<endl;
	}
	//destructor
	 ~Employee()
	{
		cout<<"destructor called"<<endl;
	}
};
int main()
{
	Employee e1;
	Employee e2; 
	return 0;
}
