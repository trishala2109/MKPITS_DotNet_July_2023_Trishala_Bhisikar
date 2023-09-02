#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abilityName;
		public:
			void getName(string an)
			{
				abilityName=an;
			}
};
class Equipment
{
	protected:
		string item;
		public:
			void getequipmentsitem(string ei)
			{
				item=ei;
			}			
};
class Charecter:public Ability,public Equipment
{
	protected:
		string charecterName;
		public:
			void getcharecterName(string cn)
			{
				charecterName=cn;
			}
			void display()
			{
				cout<<"CHARECTER NAME:"<<charecterName<<endl;
				cout<<"ABILITY:"<<abilityName<<endl;
				cout<<"EQUIPMENTS:"<<item<<endl;
			}
};
int main()
{
	Charecter c1;
	c1.getName("angel");
	c1.getequipmentsitem("gun");
	c1.getcharecterName("attack");
	c1.display();
	return 0;
}

