# include<iostream>
# include<vector>

using namespace std;

vector<int> C;

bool cmp(vector<int> A, vector<int> B) {
	if (A.size() != B.size()) return A.size() > B.size();
	for (int i = A.size() - 1; i >= 0; i--) {
		if (A[i] != B[i]) return A[i] > B[i];
	}

	return true;
}

vector<int> sub(vector<int>& A, vector<int>& B) {
	int t = 0;
	for (int i = 0; i < A.size(); i++) {
		t = A[i] - t;
		if (i < B.size()) t -= B[i];
		C.push_back((t + 10) % 10);
		t = t < 0 ? 1 : 0;
	}

	while (C.size() > 1 && C.back() == 0)
	{
		C.pop_back();
	}

	return C;
}

int main() {
	string a, b;
	cin >> a >> b;
	vector<int> A, B;
	for (int i = a.size() - 1; i >= 0; i--) A.push_back(a[i] - '0');
	for (int j = b.size() - 1; j >= 0; j--) B.push_back(b[j] - '0');
	
	if (cmp(A, B)) {
		auto C = sub(A, B);
	}
	else {
		auto C = sub(B, A);
		printf("-");
	}

	for (int k = C.size(); k >= 0; k--) printf("%d", C[k]);
	return 0;
}
