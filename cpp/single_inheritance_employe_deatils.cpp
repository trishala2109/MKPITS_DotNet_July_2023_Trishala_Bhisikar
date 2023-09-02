#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string designation;
};
class employee: public person
{
	public:
		int salary;
		int emid;
		int year;

void getData()
{
	cout<<"enter name,ID,designation,salary,year"<<endl;
	cin>>name>>emid>>designation>>salary>>year;
}
void displayDetails()
{
	cout<<endl;
	cout<<"name:"<<name<<endl;
	cout<<"employe ID:"<<emid<<endl;
	cout<<"designation:"<<designation<<endl;
	cout<<"salary:"<<salary<<endl;
	cout<<"join year:"<<year;
}
};
int main()
{
	employee emp1;
    emp1.getData();
    emp1.displayDetails();
	
	return 0;
}
