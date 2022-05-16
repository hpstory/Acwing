# include<iostream>

using namespace std;
const int N = 1000010;
int n, k;
int a[N], q[N];

int main() {
	scanf("%d%d", &n, &k);
	for (int i = 0; i < n; i++) scanf("%d", &a[i]);
	int head = 0, tail = -1;
	for (int i = 0; i < n; i++) {
		// 队列里存的是下标, 队列head位置的数永远都是滑动窗口的最小值/最大值
		if (head <= tail && i - k + 1 > q[head]) head++;
		while (head <= tail && a[q[tail]] >= a[i]) tail--;
		q[++tail] = i;
		if (i >= k - 1) printf("%d ", a[q[head]]);
	}

	puts("");

	head = 0, tail = -1;
	for (int i = 0; i < n; i++) {
		if (head <= tail && i - k + 1 > q[head]) head++;
		while (head <= tail && a[q[tail]] <= a[i]) tail--;
		q[++tail] = i;
		if (i >= k - 1) printf("%d ", a[q[head]]);
	}

	return 0;
}