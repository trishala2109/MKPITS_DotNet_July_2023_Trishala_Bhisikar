#include<iostream>
using namespace std;

class student
{
   public:
    string name,grade;
    int std,rollno,marks;

    string calculategrade()
	 {
        if (marks >= 90)
		 {
            return "A";
         }
	    else if (marks >= 80)
		 {
            return "B";
         }
		else if (marks >= 70)
		 {
            return "C";
         } 
		else if (marks >= 60)
		 {
            return "D";
         }
	    else 
		{
            return "F";
        }
    }
    void displayInformation() 
	{
        cout<<"Name:"<<name<<endl;
        cout<<"Class:"<<std<<endl;
        cout<<"Roll No:"<<rollno<<endl;
        cout<<"Marks:"<< marks<<endl;
        cout<<"Grade:"<<grade<<endl;
    }
};

int main() 
{
    student s1,s2;
    cout<<"Enter student 1 details:"<<endl;
    cout<<"Name:";
    cin>>s1.name;
    cout<<"Class:";
    cin>>s1.std;
    cout<<"Roll No:";
    cin>>s1.rollno;
    cout<<"Marks:";
    cin>>s1.marks;
    s1.grade=s1.calculategrade();
    cout<<endl;
    cout<<"Enter student 2 details:"<<endl;
    cout<<"Name: ";
    cin>>s2.name;
    cout<<"Class:";
    cin>>s2.std;
    cout<<"Roll No:";
    cin>>s2.rollno;
    cout<<"Marks:";
    cin>>s2.marks;
    s2.grade=s2.calculategrade();
    cout<<endl;
    cout<<"Student 1 details:"<<endl;
    s1.displayInformation();
    cout<<endl;
    cout<<"Student 2 details:"<<endl;
    s2.displayInformation();
    return 0;
}
