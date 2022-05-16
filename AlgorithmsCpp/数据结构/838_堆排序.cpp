# include<iostream>

using namespace std;

int n, m;
const int N = 100010;
int h[N], cnt;

void down(int x) {
	int t = x;
	if (x * 2 <= cnt && h[x * 2] < h[t]) t = x * 2;
	if (x * 2 + 1 <= cnt && h[x * 2 + 1] < h[t]) t = x * 2 + 1;
	if (x != t) {
		swap(h[x], h[t]);
		down(t);
	}
}

int main() {
	cin >> n >> m;
	for (int i = 1; i <= n; i++) {
		scanf("%d", &h[i]);
		cnt++;
	}

	for (int i = n / 2; i > 0; i--) {
		down(i);
	}

	while (m--) {
		printf("%d ", h[1]);
		h[1] = h[cnt--];
		down(1);
	}
}