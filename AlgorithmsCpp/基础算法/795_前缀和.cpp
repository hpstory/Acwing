# include<iostream>

using namespace std;

const int N = 100010;
int n, m, l, r;
int q[N], s[N];

int main() {
	cin >> n >> m;
	for (int i = 1; i <= n; i++) cin >> q[i];
	for (int j = 1; j <= n; j++) s[j] = s[j - 1] + q[j];
	while (m--) {
		cin >> l >> r;
		printf("%d\n", s[r] - s[l - 1]);
	}

	return 0;
}