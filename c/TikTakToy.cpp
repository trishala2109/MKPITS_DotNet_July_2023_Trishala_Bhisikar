#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class tik_tak_toe:public Game
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
		void end()
		{
			cout<<"Tiktaktoe Game is end"<<endl;
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
		void end()
		{
			cout<<"Cheese Game is end"<<endl;
		}
};
int main()
{
	tik_tak_toe t;
	t.start();
	t.play();
	t.end();
	Cheese c;
	c.start();
	c.play();
	c.end();
	return 0;
}
