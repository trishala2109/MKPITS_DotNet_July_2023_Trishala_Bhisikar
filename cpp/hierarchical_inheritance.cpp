#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
		void getdata(int a,int b)
		{
			x=a;
			y=b;
		}
};
class rectangle:public shape
{
	public:
		int rarea(int l,int b)
		{
		  int ra;
		  ra=l*b;
		  return ra;	
		}
};
class triangle:public shape
{
	public:
		float tarea(int b,int h)
		{
			float ta;
			ta=0.5f*b*h;
			return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breath,height,base;
	int ra;
	float ta;
	cout<<"ENTER THE LENGTH AND BREATH :"<<endl;
	cin>>length>>breath;
	ra=r.rarea(length,breath);
	cout<<"AREA OF REACTANGLE:"<<ra<<endl;
	cout<<"ENTER THE BASE AND HEIGHT:"<<endl;
	cin>>base>>height;
	ta=t.tarea(base,height);
	cout<<"AREA OF TRIANGLE:"<<ta;
	return 0;
}
