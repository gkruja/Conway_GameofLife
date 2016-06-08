//Yes, you need all this for memory leaks
#include <Windows.h>

#define _CRTDBG_MAP_ALLOC
#include <cstdlib>
#include <crtdbg.h>

#include <iostream>

using namespace std;


int main(void)
{

	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);

	int num = 13;

	cout << "This is the value for num:" << num;
	cout << "\nThis is the address for num: 0x" << &num;

	cout << "\n\nWhat would you like the nnew unmber to be: ";
	cin >> num;

	cout << "\n\nThis is the value for num:" << num;
	cout << "\nThis is the address for num: 0x" << &num;
	cout << "\n\n\n";
	system("pause");
	return 0;
}