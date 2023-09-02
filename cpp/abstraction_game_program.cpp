#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tiktaktoe:public Game
{
	public:
		void start()
		{
			cout<<"Tiktaktoe Game is start"<<endl;
		}
		void play()
		{
			cout<<"Tiktaktoe Game is play"<<endl;
		}
		void stop()
		{
			cout<<"Tiktaktoe Game is stop"<<endl;
			cout<<endl;
		}
};
class Cheese:public Game
{
	public:
		void start()
		{
			cout<<"Cheese Game is start"<<endl;
		}
		void play()
		{
			cout<<"Cheese Game is play"<<endl;
		}
		void stop()
		{
			cout<<"Cheese Game is stop"<<endl;
			cout<<endl;
		}
};
int main()
{
	Tiktaktoe T;
	T.start();
	T.play();
	T.end();
	
	Cheese c;
	c.start();
	c.play();
	c.end();
	return 0;
}
