#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
		public:
			void dispaly()
			{
				cout<<"ROLL NO:"<<rno;
			}
			void setdata(int r)
			{
				rno=r;
			}
};
int main()
{
	student s1;
	int rn;
	cout<<"ENTER THE ROLL NO:";
	cin>>rn;
	s1.setdata(rn);
	s1.dispaly(); 
	return 0;
}
