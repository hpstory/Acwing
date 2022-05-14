# include<iostream>

using namespace std;

const int N = 100010;

int m, head, idx;
int e[N], ne[N];

void init() {
	head = -1;
	idx = 0;
}

void add_to_head(int x) {
	e[idx] = x;
	ne[idx] = head;
	head = idx;
	idx++;
}

void add(int k, int x) {
	e[idx] = x;
	ne[idx] = ne[k];
	ne[k] = idx;
	idx++;
}

void remove(int k) {
	// head不是头节点, head理解为一个指针
	if (k == -1) head = ne[head];
	else ne[k] = ne[ne[k]];
}

int main() {
	cin >> m;
	init();
	while (m--) {
		char s;
		cin >> s;
		if (s == 'H') {
			int x;
			cin >> x;
			add_to_head(x);
		}
		else if (s == 'D') {
			int k;
			cin >> k;
			remove(k - 1);
		}
		else {
			int k, x;
			cin >> k >> x;
			add(k - 1, x);
		}
	}

	for (int i = head; i != -1; i = ne[i]) printf("%d ", e[i]);
	return 0;
}