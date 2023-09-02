#include<iostream>
using namespace std;
class employe
{
	public:
		int emid;
		string name;
		string desig;
		int salary;
		void getDetails()
		{
			cout<<"enter the employe ID, Name, Designation,salary"<<endl;
			cin>>emid>>name>>desig>>salary;
		}
		void displayDetails()
		{
			cout<<endl;
			cout<<"employe ID:"<<emid<<endl;
			cout<<"name:"<<name<<endl;
			cout<<"designation"<<desig<<endl;
			cout<<"salary:"<<salary<<endl;
		}
};
int main()
{
	employe em1,em2;
	cout<<"employe 1"<<endl;
	em1.getDetails();
	em1.displayDetails();
	cout<<endl;
	
	cout<<"employe 2"<<endl;
	em2.getDetails();
	em2.displayDetails();
}
