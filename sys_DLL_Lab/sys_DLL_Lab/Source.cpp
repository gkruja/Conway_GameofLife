#include <iostream>
#include <vector>
#include "DList.h"

using namespace std;

int main(void)
{
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

	cout << "\n\n\n\n";
	system("pause");
	return 0;
}