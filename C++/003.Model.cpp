#include "stdafx.h"
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	int a, b;
	char symbol = '#';
	string input = "";

	cin >> a >> b >> symbol;

	for (size_t i = 0; i < std::min(a, b); i++)
	{
		for (size_t i = 0; i < std::max(a, b); i++)
		{
			cout << symbol;
		}
		cout << "\n";
	}

	return 0;
}