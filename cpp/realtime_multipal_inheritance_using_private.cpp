#include<iostream>
using namespace std;
class Ability
{
	private:
		string abilityName;
		public:
			void getabilityName(string an)
			{
				abilityName=an;
			}
			void dispaly()
			{
				cout<<"ABILITY:"<<abilityName<<endl;
			}
};
class Equipment
{
	private:
		string equipmentItem;
		public:
			void getEquipmentsitem(string ei)
			{
				equipmentItem=ei;
			}	
			void display()
			{
			   cout<<"EQUIPMETS:"<<equipmentItem<<endl;	
			}		
};
class Charecter:public Ability,public Equipment
{
	private:
		string charecterName;
		public:
			void getcharecterName(string cn,string an,string ei)
			{
			   	getabilityName(an);
				charecterName=cn;
				getEquipmentsitem(ei);
			}
			void display()
			{
			cout<<"CHARECTER:"<<charecterName<<endl;
			Ability::dispaly();
			Equipment::display();
			}
			
};
int main()
{
	Charecter c1;
    c1.getcharecterName("marvel","attack","gun");
	c1.display();
	return 0;
}

