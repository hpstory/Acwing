# include<iostream>

using namespace std;

const int N = 100010;
int n;
int a[N], s[N];

int main() {
	cin >> n;
	for (int i = 0; i < n; i++) cin >> a[i];

	int result = 0;
	for (int i = 0, j = 0; i < n; i++) {
		s[a[i]]++;
		while (s[a[i]] > 1) s[a[j]]--, j++;
		result = max(result, i - j + 1);
	}

	printf("%d", result);
	return 0;
}
