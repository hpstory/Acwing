#include <iostream>

using namespace std;

const int N = 1E6 + 10;
int n;
int q[N];

void quick_sort(int q[], int left, int right) {
	// 数组中小于等于1个元素时直接返回，不需要排序
	if (left >= right) return;

	int i = left - 1, j = right + 1;
	int pivot = q[rand() % (right - left + 1) + left];

	while (i < j)
	{
		do i++; while (q[i] < pivot);
		do j--; while (q[j] > pivot);
		if (i < j) swap(q[i], q[j]);
	}

	quick_sort(q, left, j);
	quick_sort(q, j + 1, right);
}

int main() {
	scanf("%d", &n);
	for (int i = 0; i < n; i++) scanf("%d", &q[i]);
	quick_sort(q, 0, n - 1);
	for (int i = 0; i < n; i++) printf("%d ", q[i]);
	return 0;
}
