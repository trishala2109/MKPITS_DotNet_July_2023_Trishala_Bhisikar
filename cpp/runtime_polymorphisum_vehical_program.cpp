#include<iostream>
using namespace std;
class Vehical
{
	public:
		virtual void start()
		{
			cout<<"start the engine"<<endl;
		}
		virtual void stop()
		{
			cout<<"stop the engine"<<endl;
		}
};
class Car:public Vehical
{
	public:
		void start()
		{
			cout<<"Car Engine is Start"<<endl;
		}
		void stop()
		{
			cout<<"Car Engine is Stop"<<endl;
			cout<<endl;
		}
};
class Motorcycle:public Vehical
{
	public:
		void start()
		{
			cout<<"Motorcycle Engine is Start"<<endl;
		}
		void stop()
		{
			cout<<"Motorcycle Engine is stop"<<endl;
			cout<<endl;
		}
};
class Truck:public Vehical
{
	public:
		void start()
		{
			cout<<"Truck Engine is Start"<<endl;
		}
		void stop()
		{
			cout<<"Truck Engine is Stop"<<endl;
		}
};
int main()
{
	Vehical *V;
	Car c;
	Motorcycle m;
	Truck t;
	V=&c;
	V->start();
	V->stop();
	V=&m;
	V->start();
	V->stop();
	V=&t;
	V->start();
	V->stop();
	return 0;
}
