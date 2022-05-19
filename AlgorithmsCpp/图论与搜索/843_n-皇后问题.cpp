# include<iostream>

using namespace std;

const int N = 10;
int n;
char q[N][N];
bool col[N], x[N], y[N];

void dfs(int u) {
	if (u == n) {
		for (int i = 0; i < n; i++) {
			puts(q[i]);
		}

		puts("");
		return;
	}

	for (int i = 0; i < n; i++) {
		if (!col[i] && !x[u + i] && !y[i - u + n])
		{
			q[u][i] = 'Q';
			col[i] = x[u + i] = y[i - u + n] = true;
			dfs(u + 1);
			col[i] = x[u + i] = y[i - u + n] = false;
			q[u][i] = '.';
		}
	}
}

int main() {
	cin >> n;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			q[i][j] = '.';
		}
	}
	dfs(0);

	return 0;
}