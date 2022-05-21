//# include<iostream>
//
//using namespace std;
//
//int n, m;
//int v, w, s;
//const int N = 110;
//int dp[N][N];
//
//int main() {
//	cin >> n >> m;
//	for (int i = 1; i <= n; i++) {
//		cin >> v >> w >> s;
//		for (int j = 0; j <= m; j++) {
//			for (int k = 0; k <= s && v * k <= j; k++) {
//				dp[i][j] = max(dp[i][j], dp[i - 1][j - v * k] + w * k);
//			}
//		}
//	}
//
//	cout << dp[n][m] << endl;
//	return 0;
//}

# include<iostream>

using namespace std;

int n, m;
int v, w, s;
const int N = 110;
int dp[N];

int main() {
	cin >> n >> m;
	for (int i = 1; i <= n; i++) {
		cin >> v >> w >> s;
		for (int j = m; j >= 0; j--) {
			for (int k = 0; k <= s && v * k <= j; k++) {
				dp[j] = max(dp[j], dp[j - v * k] + w * k);
			}
		}
	}

	cout << dp[m] << endl;
	return 0;
}