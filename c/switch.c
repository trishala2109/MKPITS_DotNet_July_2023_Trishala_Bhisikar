#include<stdio.h>
int main()
{
   int day_no;
   printf("enter day no:\n");
   scanf("%d",&day_no);
   switch(day_no)
   {
   	 case 1:
   	 	printf("\n Monday");
   	 	break;
   	case 2:
   	 		printf("\n Tuesday");
   	 		break;
   	case 3:
   	 		printf("\n Wednesday");
	default:
   	 		printf("Invalid");
			break;
   }	
}
