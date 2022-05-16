# include<iostream>
using namespace std;
int n, m;
const int N = 100010;
int q[N], cnt[N];

int find(int x) {
	if (q[x] != x) q[x] = find(q[x]);
	return q[x];
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		q[i] = i;
		cnt[i] = 1;
	}

	while (m--) {
		char op[5];
		int a, b;
		scanf("%s%d%d", op, &a, &b);
		if (op[0] == 'C') {
			if (find(a) == find(b)) continue;
			cnt[find(b)] += cnt[find(a)];
			q[find(a)] = find(b);
		}
		else if (op[1] == '1') {
			if (find(a) == find(b)) puts("Yes");
			else puts("No");
		}
		else {
			printf("%d\n", cnt[find(a)]);
		}
	}
	return 0;
}