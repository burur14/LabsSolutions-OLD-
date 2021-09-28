#include <iostream>

int main() {
	int n;
	std::cin >> n;
	int k1 = 1;
	int k2 = 1;
	int count = 2;

	while (count != n) {
		count++;
		k1 = k2;
		k2 = (k1 * (4 * count - 6)) / count;
	}

	std::cout << k2 << std::endl;
	return 0;
}