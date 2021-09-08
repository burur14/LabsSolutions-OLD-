#include <iostream>

int main() {
	double x;
	double y;

	std::cin >> x;
	std::cin >> y;

	bool result = false;
	if (y >= x / 2) {
		if ((x - 2)*(x - 2) + y*y  <= 4){
			result = true;
		}
	}

	std::cout << std::boolalpha << result << std::endl;
}