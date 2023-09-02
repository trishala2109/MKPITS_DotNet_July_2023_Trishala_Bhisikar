#include<iostream>
using namespace std;
class Animal
{
	public:
		void eat()
		{
			cout<<"eating "<<endl;
		}
};
class Dog:public Animal
{
	public:
		void bark()
		{
			cout<<"dog bark";
		}
};
int main()
{
	Dog d1;
	d1.eat();
	d1.bark();
	return 0;
}
