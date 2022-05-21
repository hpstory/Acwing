# include<iostream>

using namespace std;
const int N = 110;
int n, m;
int v[N], w[N];
int dp[N];

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {

		int s;
		cin >> s;
		for (int j = 0; j < s; j++) {
			cin >> v[j] >> w[j];
		}

		for (int j = m; j >= 0; j--) {
			for (int k = 0; k < s; k++) {
				if (v[k] <= j) {
					dp[j] = max(dp[j], dp[j - v[k]] + w[k]);
				}
			}
		}
	}

	cout << dp[m] << endl;
	return 0;
}