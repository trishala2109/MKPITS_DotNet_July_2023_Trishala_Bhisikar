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
		int rarea()
		{
		  int ra;
		  ra=x*y;
		  return ra;	
		}
};
class triangle:public shape
{
	public:
		float tarea()
		{
			float ta;
			ta=0.5f*x*y;
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
	r.getdata(length,breath);
	ra=r.rarea();
	cout<<"AREA OF REACTANGLE:"<<ra<<endl;
	cout<<"ENTER THE BASE AND HEIGHT:"<<endl;
	cin>>base>>height;
	t.getdata(base,height);
	ta=t.tarea();
	cout<<"AREA OF TRIANGLE:"<<ta;
	return 0;
}
