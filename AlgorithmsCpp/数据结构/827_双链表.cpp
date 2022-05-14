# include<iostream>

using namespace std;
const int N = 100010;
int m, e[N], r[N], l[N], index;

void init() {
	r[0] = 1;
	l[1] = 0;
	index = 2;
}

void insert(int k, int x) {
	e[index] = x;
	r[index] = r[k];
	l[index] = k;
	l[r[k]] = index;
	r[k] = index;
	index++;
}

void remove(int k) {
	r[l[k]] = r[k];
	l[r[k]] = l[k];
}

int main() {
	init();
	cin >> m;
	while (m--) {
		string s;
		cin >> s;
		if (s == "D") {
			int k;
			cin >> k;
			remove(k + 1);
		}
		else if (s == "L") {
			int x;
			cin >> x;
			insert(0, x);
		}
		else if (s == "R") {
			int x;
			cin >> x;
			insert(l[1], x);
		}
		else if (s == "IL") {
			int k, x;
			cin >> k >> x;
			insert(l[k + 1], x);
		}
		else {
			int k, x;
			cin >> k >> x;
			insert(k + 1, x);
		}
	}

	for (int i = r[0]; i != 1; i = r[i]) printf("%d ", e[i]);
	return 0;
}