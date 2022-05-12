#include<iostream>

using namespace std;

const int N = 100010;
int n, q, k;
int a[N];

int main() {
	scanf("%d%d", &n, &q);
	for (int i = 0; i < n; i++) scanf("%d", &a[i]);
	while (q--) {
		scanf("%d", &k);
		int l = 0, r = n - 1;
		while (l < r) {
			int mid = l + r >> 1;
			if (a[mid] < k) l = mid + 1;
			else r = mid;
		}

		if (a[l] != k) printf("-1 -1\n");
		else {
			printf("%d ", l);
			r = n - 1;
			while (l < r) {
				int mid = l + r + 1 >> 1;
				if (a[mid] > k) r = mid - 1;
				else l = mid;
			}

			printf("%d\n", l);
		}
	}

	return 0;
}