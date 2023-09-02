#include<iostream>
using namespace std;
class Engine
{
	public:
		int power;
		void start()
		{
			cout<<"start the engine"<<endl;
		}
		void stop()
		{
			cout<<"stop the engine"<<endl;
		}
};
class Vehical
{
	public:
		string brand;
		void accelrate()
		{
			cout<<"car accelrate"<<endl;
		}
		void breack()
		{
			cout<<"brack applied"<<endl;
		}
		void displayBrand()
		{
		   cout<<"Brand:Maruti"<<brand<<endl;	
		}
};
class Car :public Engine,public Vehical
{
	public:
		void drive()
		{
			start();
			accelrate();
			cout<<"car is driving"<<endl;
		}
		void park()
		{
			stop();
			breack();
			cout<<"car is parking"<<endl;
		}
};
int main()
{
	Car c;
	c.displayBrand();
	c.drive();
	c.park();
	return 0;
}
