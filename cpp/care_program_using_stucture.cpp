#include<iostream>
using namespace std;
class car
{
	public:
	string make;
	string model;
	int year;
	
	void startengine()
	{
		cout<<"engine started"<<endl;
	}
	void brake()
	{
		cout<<"break applied";
	}
};
int main()
{
	car c1;
	c1.make="maruti";
	c1.model="suv";
	c1.year=2022;
    cout<<"make:"<<endl<<c1.make<<endl;
	cout<<"model:"<<endl<<c1.model<<endl;
	cout<<"year:"<<endl<<c1.year<<endl;
	
	c1.startengine();
	c1.brake();
}
