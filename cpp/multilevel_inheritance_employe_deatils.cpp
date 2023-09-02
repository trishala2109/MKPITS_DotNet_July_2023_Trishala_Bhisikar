#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
};
class Employee :public person
{
	public:
		int salary;
		int emid;
};
class parttimeEmployee:public Employee
{
	public:
		int nohours;
};
int main()
{
	Employee e1;
	e1.name="trishala";
	e1.mobileno=768;
	e1.salary=25000;
	e1.emid=876;
	cout<<"EMPLOYEE DETAILS:"<<endl;
	cout<<e1.name<<endl<<e1.mobileno<<endl<<e1.salary<<endl<<e1.emid<<endl;
	
	parttimeEmployee p1;
	p1.name="sujit";
	p1.mobileno=91569529;
	p1.salary=300000;
	p1.emid=763;
	p1.nohours=3;
	cout<<endl;
	cout<<"PART TIME EMPLOYEE DETAILS:"<<endl;
	cout<<p1.name<<endl<<p1.mobileno<<endl<<p1.salary<<endl<<p1.emid<<endl<<p1.nohours;
	return 0;
}
