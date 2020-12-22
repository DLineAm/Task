#include <windows.h>
int main(){
	for(int i=0;i<50;i++){
		if(i%2==0)
		Beep(i*20,100);
		if(i%3==0)
		Beep(i*50,100);
	}
	for(int i=50;i<0;i--){
		if(i%2==0)
		Beep(i*50,100);
		if(i%3==0)
		Beep(i*20,100);
	}
	Beep(100,1000);
	return 0;
}
