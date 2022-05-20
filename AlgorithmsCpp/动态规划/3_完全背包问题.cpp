//# include<iostream>
//
//using namespace std;
//
//const int N = 1010;
//int n, m;
//int vi[N], wi[N];
//int dp[N][N];
//
//int main() {
//	cin >> n >> m;
//	for (int i = 1; i <= n; i++) {
//		int v, w;
//		cin >> v >> w;
//		vi[i] = v, wi[i] = w;
//	}
//
//	for (int i = 1; i <= n; i++) {
//		for (int j = 0; j <= m; j++) {
//			dp[i][j] = dp[i - 1][j];
//			if (j >= vi[i])
//			{
//				dp[i][j] = max(dp[i][j], dp[i][j - vi[i]] + wi[i]);
//			}
//		}
//	}
//
//	cout << dp[n][m] << endl;
//
//	return 0;
//}
//

# include<iostream>

using namespace std;

const int N = 1010;
int n, m;
int vi[N], wi[N];
int dp[N];

int main() {
	cin >> n >> m;
	for (int i = 1; i <= n; i++) {
		int v, w;
		cin >> v >> w;
		vi[i] = v, wi[i] = w;
	}

	for (int i = 1; i <= n; i++) {
		for (int j = vi[i]; j <= m; j++) {
			dp[j] = max(dp[j], dp[j - vi[i]] + wi[i]);
		}
	}

	cout << dp[m] << endl;

	return 0;
}

