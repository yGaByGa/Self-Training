#include "stdafx.h"
#include <iostream>
#include <string>
#include <sstream>

using namespace std;

int main()
{
	int a, b;
	char symbol = '#';
	string input = "";

	getline(cin, input);

	a = input[0] - '0';
	b = input[2] - '0'; 
	symbol = input[4];

	cout << "input[0] = " << a << endl;
	cout << "input[2] = " << b << endl;
	cout << "input[4] = " << input[4] << endl;

	return 0;
}