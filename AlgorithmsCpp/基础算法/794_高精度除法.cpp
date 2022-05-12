# include<iostream>
# include<vector>
# include<algorithm>

using namespace std;

vector<int> C;
int r;

vector<int> div(vector<int>& A, int b, int& r) {
	r = 0;
	for (int i = A.size() - 1; i >= 0; i--) {
		r = r * 10 + A[i];
		C.push_back(r / b);
		r %= b;
	}

	reverse(C.begin(), C.end());
	while (C.size() > 1 && C.back() == 0) C.pop_back();
	return C;
}

int main() {
	string a; int b;
	cin >> a >> b;
	vector<int> A;
	for (int i = a.size() - 1; i >= 0; i--) A.push_back(a[i] - '0');
	auto C = div(A, b, r);
	for (int j = C.size() - 1; j >= 0; j--) printf("%d", C[j]);
	printf("\n%d", r);
	return 0;
}