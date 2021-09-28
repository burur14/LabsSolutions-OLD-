using namespace std;
#include <iostream>

int main(){
	int x;
	::cin >> x;

	double a1 = 1;
	double a2 = (a1 + (x / a1)) / 2;
	double tmp;
	while (abs(a2 - a1) > 0.0001) {
		
		a1 = a2;
		a2 = (a1 + (x / a1)) / 2;

	}
	::cout << a2 << endl;
	return 0;
}