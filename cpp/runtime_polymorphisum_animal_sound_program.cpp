#include<iostream>
using namespace std;
class Animal
{
	public:
		virtual void sound()
		{
			cout<<"create a sound: "<<endl;
		}
};
class Dog:public Animal
{
	public:
		void sound()
		{
			cout<<"Dog says:"<<endl<<"bark bark"<<endl;
			cout<<endl;
		}
};
class Cat:public Animal
{
	public:
		void sound()
		{
			cout<<"Cat says:"<<endl<<"Meow Meow"<<endl;
			cout<<endl;
		}
};
class Cow:public Animal
{
	public:
		void sound()
		{
			cout<<"Cow says:"<<endl<<"Moo Moo"<<endl;
		}
};
int main()
{
	Animal *A;
	Dog d;
	Cat c;
	Cow c1;
	A=&d;
	A->sound();
	A=&c;
	A->sound();
	A=&c1;
	A->sound();
	return 0;
}
