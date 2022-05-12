# include<iostream>

using namespace std;

const int N = 100010;
int n, m;
int a[N], b[N];

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) cin >> a[i];
	for (int j = 0; j < m; j++) cin >> b[j];

	int i = 0;
	for (int j = 0; i < n && j < m; j++) {
		if (a[i] == b[j]) i++;
	}

	if (i == n) printf("Yes");
	else printf("No");

	return 0;
}
