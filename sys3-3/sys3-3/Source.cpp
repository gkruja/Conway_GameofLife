//Yes, you need all this for memory leaks
#include <Windows.h>

#define _CRTDBG_MAP_ALLOC
#include <cstdlib>
#include <crtdbg.h>

#include <iostream>



using namespace std;

struct Info
{
	int age;
	char* name;
};

int main(void)
{
	//Also need this for memory leak code stuff
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	_CrtSetBreakAlloc(-1);

	cout << "How many Record would you like? ";
	int count = -1;
	cin >> count;
	Info** temp;
	temp = new Info*[count];
	int i = 0;
	for (; i < count; ++i)
	{
		char buffer[32];
		
		temp[i] = nullptr;
		temp[i] = new Info();
		cout << "\nEnter record " << i << "'s age: ";

		cin >> temp[i]->age;

		cout << "\nEnter record " << i << "'s name: ";

		cin.ignore(INT_MAX, '\n');
		cin.getline(buffer, 32, '\n');
		temp[i]->name = new char[strlen(buffer)+1];
		strcpy_s(temp[i]->name, strlen(buffer) + 1, buffer);
	}

	for (i = 0; i < count; ++i)
		cout << "\n\n\This record's age is " << temp[i]->age << " and their name is " << temp[i]->name << '\n';

	//delete temp;

	for (i = 0; i < count; ++i)
		delete temp[i];

	delete[] temp;



	system("pause");
	return 0;
}