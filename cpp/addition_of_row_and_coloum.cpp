#include<iostream>
using namespace std;
int main()
{
	int i,j;
	int arry[2][2]={{5,2},{3,4}};
	int sum=0;
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[i][j];
		}
		cout<<"sum of row="<<sum<<endl<<i+1;
	}
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[j][i];
		}
		cout<<"sum of coloum="<<sum<<endl<<i+1;
	}
}
