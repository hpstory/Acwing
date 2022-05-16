# include<iostream>

using namespace std;

const int N = 100010;
// son[][]存储子节点的位置，分支最多26条；
// cnt[]存储以某节点结尾的字符串个数（同时也起标记作用）
// idx表示当前要插入的节点是第几个,每创建一个节点值+1
int n, son[N][26], cnt[N], idx;
char str[N];

void insert(char *str) {
	int p = 0;
	for (int i = 0; str[i]; i++) {
		int u = str[i] - 'a';
		if (!son[p][u]) son[p][u] = ++idx;
		p = son[p][u];
	}

	cnt[p]++;
}

int query(char *str) {
	int p = 0;
	for (int i = 0; str[i]; i++) {
		int u = str[i] - 'a';
		if (!son[p][u]) return 0;
		p = son[p][u];
	}

	return cnt[p];
}

int main() {
	cin >> n;
	while (n--) {
		char op[2];
		scanf("%s%s", op, str);
		if (*op == 'I') {
			insert(str);
		}
		else {
			cout << query(str) << endl;
		}
	}
	return 0;
}
