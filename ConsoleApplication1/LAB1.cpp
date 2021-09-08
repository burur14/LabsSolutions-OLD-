#include <iostream>

int main() {
	int m;
	int n;

	std::cin >> m;
	std::cin >> n;

	double div = (double)m / (double)n;

	int lastIntNum = (int)div % 10;
	int firstDecimal = (int)(div * 10) % 10;

	std::cout << lastIntNum << std::endl << firstDecimal << std::endl;

	return 0; 
}

