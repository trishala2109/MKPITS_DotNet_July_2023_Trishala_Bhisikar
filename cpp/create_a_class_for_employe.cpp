#include<iostream>
using namespace std;
class employe
{
	public:
		int emid,salary;
		string name;
		string desig;
		
		void getdDetails()
		{
			cout<<"enter the employe ID, Name, Designation,salary";
			cin>>emid>>name>>desig>>salary;
		}
		void displaydetails()
		{
			cout<<endl;
			cout<<"employe ID:"<<emid;
			cout<<"name:"<<name;
			cout<<"designation"<<desig;
			cout<<"salary:"<<salary;
		}
};
int main()
{
	employe em1,em2;
	cout<<"employe 1"<<endl;
	em1.getDetails();
	em1.displaydetails();
	
	cout<<"employe 2"<<endl;
	em2.geteDetails();
	em2.displaydetails();
}
