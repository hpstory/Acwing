# include<iostream>
# include<cstring>

using namespace std;
const int N = 100010;
int n, cnt;
int h[N], ph[N], hp[N];

void heap_swap(int a, int b) {
	swap(ph[hp[a]], ph[hp[b]]);
	swap(hp[a], hp[b]);
	swap(h[a], h[b]);
}

void down(int x) {
	int p = x;
	if (x * 2 <= cnt && h[x * 2] < h[p]) p = x * 2;
	if (x * 2 + 1 <= cnt && h[x * 2 + 1] < h[p]) p = x * 2 + 1;
	if (p != x) {
		heap_swap(x, p);
		down(p);
	}
}

void up(int x) {
	while (x / 2 > 0 && h[x / 2] > h[x])
	{
		heap_swap(x / 2, x);
		x /= 2;
	}
}

int main() {
	int m = 0;
	cin >> n;
	while (n--) {
		char op[10];
		cin >> op;
		if (!strcmp(op, "I")) {
			int x;
			cin >> x;
			cnt++;
			m++;
			ph[m] = cnt, hp[cnt] = m;
			h[cnt] = x;
			up(cnt);
		}
		else if (!strcmp(op, "PM")) {
			cout << h[1] << endl;
		}
		else if (!strcmp(op, "DM")) {
			heap_swap(1, cnt);
			cnt--;
			down(1);
		}
		else if (!strcmp(op, "D")) {
			int k;
			cin >> k;
			k = ph[k];
			heap_swap(k, cnt);
			cnt--;
			down(k); up(k);
		}
		else if (!strcmp(op, "C")) {
			int k, x;
			cin >> k >> x;
			k = ph[k];
			h[k] = x;
			down(k); up(k);
		}
	}

	return 0;
}