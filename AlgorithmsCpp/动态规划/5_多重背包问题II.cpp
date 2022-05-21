# include<iostream>
# include<vector>
# include<algorithm>
using namespace std;

const int N = 2010;
int n, m;
int v, w, s;
int dp[N];

struct Good {
	int v, w;
};

int main() {
	vector<Good> goods;
	cin >> n >> m;
	for (int i = 1; i <= n; i++) {
		cin >> v >> w >> s;
		for (int k = 1; k <= s; k *= 2) {
			s -= k;
			goods.push_back({ v * k, w * k });
		}

		if (s > 0) goods.push_back({ v * s, w * s });
	}

	for (auto good : goods) {
		for (int j = m; j >= good.v; j--) {
			dp[j] = max(dp[j], dp[j - good.v] + good.w);
		}
	}

	cout << dp[m] << endl;
	return 0;
}