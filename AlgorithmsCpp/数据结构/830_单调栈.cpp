# include<iostream>

using namespace std;

const int N = 100010;
int n, top;
int st[N];


int main() {
	cin >> n;
	while (n--) {
		int x;
		cin >> x;
		while (top && st[top] >= x) top--;
		if (top) {
			cout << st[top] << " ";
		}
		else {
			cout << -1 << " ";
		}

		st[++top] = x;
	}

	return 0;
}