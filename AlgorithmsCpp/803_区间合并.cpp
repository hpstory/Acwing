# include<iostream>
# include<vector>
# include<algorithm>

using namespace std;
typedef pair<int, int> PII;
int n;
vector<PII> segs, res;

int main() {
	cin >> n;
	for (int i = 0; i < n; i++) {
		int l, r;
		cin >> l >> r;
		segs.push_back({l, r});
	}

	int st = -2e9, ed = -2e9;
	sort(segs.begin(), segs.end());
	for (auto seg : segs) {
		if (ed < seg.first) {
			if (st != -2e9) res.push_back({ st, ed });
			st = seg.first;
			ed = seg.second;
		}
		else {
			ed = max(ed, seg.second);
		}

		if (st != -2e9) res.push_back({ st, ed });
	}

	printf("%d", res.size());
	return 0;
}