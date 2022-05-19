# include<iostream>
# include<queue>

using namespace std;
typedef pair<int, int> PII;
const int N = 110;
int n, m;
int g[N][N];
int d[N][N];
queue<PII> q;

int dx[4] = { 0,1,0, -1 }, dy[4] = { 1, 0, -1, 0 };

int bfs() {
	q.push({ 0, 0 });
	while (!q.empty()) {
		PII x = q.front();
		q.pop();
		for (int i = 0; i < 4; i++) {
			int r = x.first + dx[i];
			int c = x.second + dy[i];
			if (r >= 0 && r < n && c >= 0 && c < m && g[r][c] == 0 && d[r][c] == -1) {
				d[r][c] = d[x.first][x.second] + 1;
				q.push({ r, c });
			}
		}
	}

	return d[n - 1][m - 1];
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			cin >> g[i][j];
			d[i][j] = -1;
		}
	}
	d[0][0] = 0;

	cout << bfs() << endl;

	return 0;
}