#include<iostream>
using namespace std;
class student 
{
	public:
		int rollno;
		string name;
		string course;
		
		void getData()
		{
			cout<<"enter roll no , name, course"<<endl;
			cin>>rollno>>name>>course;
		}
		void displayData()
		{
			cout<<endl;
			cout<<"roll no:"<<rollno<<endl;
			cout<<"name:"<<name<<endl;
			cout<<"course:"<<course<<endl;
		}
};
int main()
{
	student std1,std2,std3;
	cout<<"student 1"<<endl;
	std1.getData();
	std1.displayData();
	cout<<endl;
	
	cout<<"student 2"<<endl;
	std2.getData();
	std2.displayData();
	cout<<endl;
	
	cout<<"student 3"<<endl;
	std3.getData();
	std3.displayData();
	return 0;
}
