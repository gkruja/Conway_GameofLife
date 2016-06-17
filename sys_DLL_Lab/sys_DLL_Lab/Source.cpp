#include <iostream>
#include <vector>
#include "DList.h"

using namespace std;

int main(void)
{
	DList<char> cList;
	//cList.push_back('c');
	//cList.push_back('a');
	//cList.push_back('t');
	//cList.push_back('s');

	cList.pop_back('c');
	cList.pop_back('a');
	cList.pop_back('t');
	cList.pop_back('s');


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