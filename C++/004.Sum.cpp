#include "stdafx.h"
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int a, b, c, min, max;
	int result;
	cin >> a >> b >> c;

	min = std::min(std::min(a, b), c);
	max = std::max(std::max(a, b), c);

	result = max + min;

	cout << result << endl;

	return 0;
}