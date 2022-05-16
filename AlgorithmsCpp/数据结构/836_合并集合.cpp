# include<iostream>

using namespace std;

const int N = 100010;
int n, m;
int q[N];

int find(int x) {
	if (q[x] != x) q[x] = find(q[x]);
	return q[x];
}

int main()
{
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		q[i] = i;
	}

	while (m--) {
		char op[2];
		int a, b;
		scanf("%s%d%d", op, &a, &b);
		if (*op == 'M') {
			q[find(a)] = find(b);
		}
		else {
			if (find(a) == find(b)) {
				printf("Yes\n");
			}
			else {
				printf("No\n");
			}
		}
	}

	return 0;
}