# include<iostream>
# include<queue>
# include<unordered_map>

using namespace std;

queue<string> q;
unordered_map<string, int> d;
int dx[4] = { 0,-1,0,1 }, dy[4] = { 1, 0, -1, 0 };

int bfs(string start) {
	string end = "12345678x";
	d[start] = 0;
	q.push(start);
	while (!q.empty()) {
		string t = q.front();
		q.pop();
		int distance = d[t];
		if (t == end) return distance;

		int k = t.find('x');
		int x = k / 3, y = k % 3;

		for (int i = 0; i < 4; i++) {
			int a = x + dx[i], b = y + dy[i];
			if (a >= 0 && a < 3 && b >= 0 && b < 3) {
				swap(t[k], t[a * 3 + b]);
				if (!d.count(t))
				{
					d[t] = distance + 1;
					q.push(t);
				}

				swap(t[k], t[a * 3 + b]);
			}
		}
	}

	return -1;
}

int main() {
	string s;
	for (int i = 0; i < 9; i++) {
		char c;
		cin >> c;
		s += c;
	}

	cout << bfs(s) << endl;
	return 0;
}