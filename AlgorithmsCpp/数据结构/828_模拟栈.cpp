# include<iostream>

using namespace std;

const int N = 100010;
int m, st[N], top;

int main() {
	cin >> m;
	while (m--) {
		string s;
		cin >> s;
		if (s == "push") {
			int x;
			cin >> x;
			st[++top] = x;
		}
		else if (s == "query") {
			cout << st[top] << endl;
		}
		else if (s == "pop") {
			top--;
		}
		else {
			if (top) cout << "NO" << endl;
			else cout << "YES" << endl;
		}
	}
	return 0;
}