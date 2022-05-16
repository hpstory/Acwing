# include<iostream>

using namespace std;

const int N = 100010, M = 31 * N;
int n, son[M][2], idx, a[N];

void insert(int a) {
	int q = 0;
	for (int i = 30; i >= 0; i--) {
		int u = a >> i & 1;
		if (!son[q][u]) son[q][u] = ++idx;
		q = son[q][u];
	}
}

int query(int a)
{
	int q = 0, result = 0;
	for (int i = 30; i >= 0; i--) {
		int u = a >> i & 1;
		if (son[q][!u])
		{
			q = son[q][!u];
			result = result * 2 + !u;
		}
		else
		{
			q = son[q][u];
			result = result * 2 + u;
		}

	}

	return result;
}

int main() {
	cin >> n;
	for (int i = 0; i < n; i++) {
		scanf("%d", &a[i]);

	};

	int result = 0;
	for (int i = 0; i < n; i++) {
		insert(a[i]);
		int t = query(a[i]);
		result = max(result, a[i] ^ t);
	}

	printf("%d", result);
	return 0;
}