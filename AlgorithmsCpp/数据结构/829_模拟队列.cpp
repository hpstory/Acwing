# include<iostream>

using namespace std;

const int N = 100010;

int m, q[N], head, tail = -1;

int main() {
	cin >> m;
	while (m--) {
		string op;
		cin >> op;
		if (op == "push") {
			int x;
			cin >> x;
			q[++tail] = x;
		}
		else if (op == "pop") {
			head++;
		}
		else if (op == "empty") {
			if (tail >= head) printf("NO\n");
			else printf("YES\n");
		}
		else {
			cout << q[head] << endl;
		}
	}

	return 0;
}