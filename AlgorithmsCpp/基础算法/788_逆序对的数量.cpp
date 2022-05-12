#include<iostream>

using namespace std;

const int N = 100010;
int n;
int q[N], temp[N];
long long c;

long long merge_sort(int l, int r) {
	if (l >= r) return 0;
	int mid = (l + r) >> 1;
	c = merge_sort(l, mid) + merge_sort(mid + 1, r);

	int k = 0, i = l, j = mid + 1;
	while (i <= mid && j <= r) {
		if (q[i] <= q[j]) temp[k++] = q[i++];
		else
		{
			temp[k++] = q[j++];
			c += mid - i + 1;
		}
	}

	while (i <= mid) temp[k++] = q[i++];
	while (j <= r) temp[k++] = q[j++];

	for (int a = l, b = 0; a <= r; a++, b++) q[a] = temp[b];
	return c;
}

int main() {
	scanf("%d", &n);
	for (int i = 0; i < n; i++) scanf("%d", &q[i]);
	cout << merge_sort(0, n - 1) << endl;
	return 0;
}
