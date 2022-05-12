# include<iostream>

using namespace std;

const int N = 100010;
int n;

int lowbit(int x) {
	return x & -x;
}

int main() {
	cin >> n;
	while (n--) {
		int x;
		cin >> x;
		int result = 0;
		while (x) {
			x -= lowbit(x);
			result++;
		}

		printf("%d ", result);
	}

}