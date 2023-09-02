#include<iostream>
using namespace std;
class Employee
{
	public:
		int empno; 
		string empname;
	    Employee()
		{
			empno=123;
			empname="trish";
		}
		void display()
		{
			cout<<"enter the employee no:"<<empno<<endl;
			cout<<"enter the employee name:"<<empname<<endl;
		}
};
int main()
{
	Employee emp1;
	emp1.display();
	return 0;
}
