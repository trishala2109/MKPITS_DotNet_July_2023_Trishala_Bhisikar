#include<iostream>
using namespace std;
class MediaPlayer
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class Audioplayer:public MediaPlayer
{
	public:
		void play()
		{
			cout<<"Start the Audio "<<endl;
		}
		void pause()
		{
			cout<<"Pause the Audio"<<endl;
		}
		void stop()
		{
			cout<<"Stop the Audio"<<endl;
			cout<<endl;
		}
};
class Videoplayer:public MediaPlayer
{
	public:
		void play()
		{
			cout<<"Start the Video "<<endl;
		}
		void pause()
		{
			cout<<"Pause the Video"<<endl;
		}
		void stop()
		{
			cout<<"Stop the Video"<<endl;
			cout<<endl;
		}
};
int main()
{
	MediaPlayer *M;
	Audioplayer a;
	Videoplayer v;
	M=&a;
	M->play();
	M->pause();
	M->stop();
	M=&v;
	M->play();
	M->pause();
	M->stop();
	return 0;
}
