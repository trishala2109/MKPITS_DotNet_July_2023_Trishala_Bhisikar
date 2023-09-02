#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
		void getpersondata(string n, int m)
		{
			name=n;
			mobileno=m;
		}
};
class Employee:public person
{
	public:
		int emid;
		int salary;
		void getemployeedata(int e,int s)
		{
			emid=e;
			salary=s;
		}
		void displayData()
		{
			cout<<"NAME:"<<name<<endl;
			cout<<"MOBILE NO:"<<mobileno<<endl;
			cout<<"EMPLOYEE ID:"<<emid<<endl;
			cout<<"SALARY:"<<salary<<endl;
		}
};
int main()
{
	string ename;
	int mn,eno,sal;
	cout<<"ENTER EMPLOYEE DETAILS:"<<endl;
	cin>>ename>>mn>>eno>>sal;
	Employee emp;
	emp.getpersondata(ename,mn);
	emp.getemployeedata(eno,sal);
	emp.displayData();
	return 0;
}
