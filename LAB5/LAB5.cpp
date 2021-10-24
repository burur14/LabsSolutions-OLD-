#include <iostream>
#include <cmath>

int main() {
	int sum;
	for (int i = 100; i < 1000; i++) {
		int tmp = i;
		sum = 0;
		while (tmp >= 1) {
			sum += pow((tmp % 10), 3);
			tmp /= 10;
		}
		if (sum == i) {
			std::cout << i << " ";
		}
	}
}