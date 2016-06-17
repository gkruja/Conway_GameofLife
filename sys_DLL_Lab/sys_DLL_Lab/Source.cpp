#include <iostream>
#include <vector>
#include "DList.h"
//Yes, you need all this for memory leaks
#include <Windows.h>

#define _CRTDBG_MAP_ALLOC
#include <cstdlib>
#include <crtdbg.h>
using namespace std;

int main(void)
{
	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);

	DList<char> cList;
	cList.push_back('c');
	cList.push_back('a');
	cList.push_back('t');
	cList.push_back('s');

	cList.Push_front('c');
	cList.Push_front('a');
	cList.Push_front('t');
	cList.Push_front('s');


	int i = 0;
	for (; i < cList.GetSize(); ++i)
		cout << cList[i] << '\n';

	//for (example.size())
	//	example[i]->Update();

	//for (example.size())
	//	example[i]->Render() const;

	//cList.clear();

	cout << "\n\n\n\n";


	cList.erase(4);


	for (i=0; i < cList.GetSize(); ++i)
		cout << cList[i] << '\n';


	cout << "\n\n\n\n";
	system("pause");
	return 0;
}