#include<iostream>
using namespace std;
class Employe
{
	public:
		int empno;
		string empname;
		
		Employe(int empno,string empname)
		{
			this->empno=empno;
			this->empname=empname;
		}
		void display()
		{
			cout<<empno<<empname;
		}
};
int main()
{
	Employe e1 (123,"ragini");
	e1.display();
	return 0;
}
