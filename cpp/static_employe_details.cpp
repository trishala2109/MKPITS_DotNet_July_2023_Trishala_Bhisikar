#include<iostream>
using namespace std;
class Employee
{
	public:
		string empname;
		int empid;
		static string cname;
		Employee(string empname,int empid)
		{
			this->empname=empname;
			this->empid=empid;
		}
		void display()
		{
			cout<<"Enter the employee name:"<<empname<<endl;
			cout<<"Enter the employee ID:"<<empid<<endl;
			cout<<"Enter the Company name:"<<cname<<endl;
		}
};
 string Employee::cname="MKPIT";
int main()
{
	Employee E1=Employee("Trish",4568);
	E1.display();
	return 0;
}
