# include<iostream>

using namespace std;

const int N = 100010;
// son[][]�洢�ӽڵ��λ�ã���֧���26����
// cnt[]�洢��ĳ�ڵ��β���ַ���������ͬʱҲ�������ã�
// idx��ʾ��ǰҪ����Ľڵ��ǵڼ���,ÿ����һ���ڵ�ֵ+1
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
