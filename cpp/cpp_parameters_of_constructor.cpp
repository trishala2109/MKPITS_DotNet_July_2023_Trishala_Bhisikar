#include<iostream>
using namespace std;
class employee
{
	public:
	    int empno;
    	string empname;
    	
    	employee(int eno,string en)
    	{
    		empno=eno;
    		empname=en;
		}
		void dispaly()
		{
			cout<<"enter the employe no:"<<empno<<endl;
			cout<<"enter the employe name:"<<empname;
		}
};
int main()
{
	int eno;
	string en;
	cout<<"enter the employee no:";
	cin>>eno;
	cout<<"enter the employe name:";
	cin>>en;
	employee emp1(eno,en);
	emp1.dispaly();
	return 0;
}
