#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student:public person
{
	public:
		void getdata(string s)
		{
			name=s;
		}
		void displaydata()
		{
			cout<<"NAME:"<<name;
		}
};
int main()
{
	student s1;
	s1.getdata("trish");
	s1.displaydata();
	return 0;
}
